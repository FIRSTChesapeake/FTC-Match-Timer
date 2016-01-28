using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace FTC_Timer_Display.AndroidComponents
{
    public static class AndroidWebserver
    {
        private static HttpListener _listener;
        private static Thread _listenThread;
        private static bool _halt = false;

        private static AndroidStatusReply _lastStatus = null;
        private static WebserverWindow _configWindow = new WebserverWindow();

        private static string remoteKey = "";

        public static event EventHandler<AndroidCommandPackage> AndroidCommandRecvd;

        static AndroidWebserver()
        {
            
        }

        public static MatchData matchData
        {
            set
            {
                _lastStatus = new AndroidStatusReply(value);
            }
        }

        public static bool ConfigDisplay
        {
            get { return _configWindow.Visible; }
            set { _configWindow.Visible = value; }
        }

        /// <summary>
        /// Stop server and dispose all functions.
        /// </summary>
        public static void Stop()
        {
            if(_listener == null || _listenThread == null) return;
            _halt = true;
            //_listenThread.Abort();
            _listener.Stop();
            _configWindow.ClearQR();
            _configWindow.AddLogEvent("HttpServer Stopped");
        }

        public static void Start()
        {
            // default port
            Start(5300);
        }

        public static void Start(int port)
        {
            GenerateKey();
            _configWindow.SetQR(localAddress, port, remoteKey);
            _halt = false;
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://*:" + port.ToString() + "/");
            _listener.Start();
            _listenThread = new Thread(new ThreadStart(ListenerLoop));
            _listenThread.Start();
            _configWindow.AddLogEvent("HttpServer Started");
        }

        public static void GenerateKey()
        {
            Random r = new Random();
            int i = r.Next(10000, 99999);
            remoteKey = i.ToString();
        }

        private static string localAddress
        {
            get
            {
                try
                {
                    IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (IPAddress ip in host.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetwork) return ip.ToString();
                    }
                    return "";
                }
                catch
                {
                    return "";
                }
            }
        }

        public static bool isRunning
        {
            get
            {
                if (_listener == null || _listenThread == null) return false;
                if (_listenThread.ThreadState != System.Threading.ThreadState.Running) return false;
                if (!_listener.IsListening) return false;
                return true;
            }
        }

        private static void ListenerLoop()
        {
            while (!_halt)
            {
                try
                {
                    HttpListenerContext context = _listener.GetContext();
                    Process(context);
                }
                catch
                {

                }
            }

        }
        private static void Process(HttpListenerContext context)
        {
            string query = context.Request.Url.PathAndQuery;
            if (query == "/favicon.ico") return;
            log("REQUEST: {0}", false, query);
            try
            {
                string[] split1 = query.Split('?');
                string cmd = split1[0].Replace("/", "");
                if (split1.Length != 2)
                {
                    log("Malformed HTTP request from {0}", new Exception(), context.Request.RemoteEndPoint.Address);
                    RespondWithError(context, HttpStatusCode.BadRequest, "One or more vars not given");
                    return;
                }
                string[] stringArgs = split1[1].Split('&');
                Dictionary<string, string> args = new Dictionary<string, string>();
                foreach (string s in stringArgs)
                {
                    string[] ss = s.Split('=');
                    if (ss.Length != 2) continue;
                    args.Add(ss[0], ss[1]);
                }
                // Check auth
                string username = args.ContainsKey("username") ? args["username"] : context.Request.RemoteEndPoint.Address.ToString();
                if (!checkAuth(args))
                {
                    log("Received command packet from bad client: {0}", new Exception(), username);
                    RespondWithError(context, HttpStatusCode.Unauthorized, "Bad Auth Key Given");
                    return;
                }
                switch (cmd)
                {
                    case "app":
                        SendAPK(context);
                        break;
                    case "status":
                        if (_lastStatus == null) return;
                        RespondToStatus(context);
                        break;
                    case "control":
                        AndroidCommandPackage pack = new AndroidCommandPackage(args["args"], username);
                        log("Android Remote '{0}' sent command '{1}'", true, username, pack.cmd);
                        _configWindow.AddLogAction(username, context.Request.RemoteEndPoint.Address.ToString(), pack.cmd.ToString());
                        string reply = "NOT HANDLED";
                        if (AndroidCommandRecvd != null)
                        {
                            EventHandler<AndroidCommandPackage> handler = AndroidCommandRecvd;
                            handler(null, pack);
                            reply = "HANDLED";
                        }
                        // sleep 1 second to allow the timer system to give us a new match data packet before we send it to the client
                        Thread.Sleep(1000);
                        RespondToStatus(context, reply);
                        break;
                }
            }
            catch(Exception ex)
            {
                log("Exception Parsing Command", ex);
            }
        }

        private static void SendAPK(HttpListenerContext context)
        {
            try
            {
                string filePath = string.Format(@"{0}\lib\TimerRemote.apk", GeneralFunctions.AppFunctions.AppPath);
                if (!File.Exists(filePath))
                {
                    log("Can't find APK!", new Exception());
                }

                InitializeResponse(ref context);
                context.Response.ContentType = "application/vnd.android.package-archive";
                context.Response.AppendHeader("Content-Disposition", "attachment; filename=TimerRemote.apk");

                byte[] buffer = new byte[1024 * 16];
                int nbytes;
                using (FileStream f = File.OpenRead(filePath))
                {
                    while ((nbytes = f.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        context.Response.OutputStream.Write(buffer, 0, nbytes);
                    }
                    f.Close();
                }
                context.Response.OutputStream.Flush();
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                context.Response.Close();
            }
            catch(Exception ex)
            {
                log("Failed to send APK to client.", ex);
            }
            
        }

        private static void RespondToStatus(HttpListenerContext context, string cmdReply = "")
        {
            InitializeResponse(ref context);
            string json = AndroidStatusReply.makeJson(_lastStatus, cmdReply);
            byte[] bytes = Encoding.ASCII.GetBytes(json);
            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
            context.Response.OutputStream.Flush();
            context.Response.StatusCode = (int)HttpStatusCode.OK;
            context.Response.OutputStream.Close();
            context.Response.Close();
        }

        private static void RespondWithError(HttpListenerContext context, HttpStatusCode code, string message)
        {
            InitializeResponse(ref context);
            context.Response.StatusDescription = message;
            context.Response.StatusCode = (int)code;
            context.Response.OutputStream.Close();
            context.Response.Close();
        }

        private static void InitializeResponse(ref HttpListenerContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.AddHeader("Date", DateTime.Now.ToString("r"));
            context.Response.AddHeader("Last-Modified", DateTime.Now.ToString("r"));
        }

        private static bool checkAuth(Dictionary<string, string> args)
        {
            if (!args.ContainsKey("key")) return false;
            if (args["key"] != remoteKey) return false;
            return true;
        }

        /// <summary>
        /// Logs the specified message as error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The exception thrown</param>
        /// <param name="args">The arguments.</param>
        private static void log(string message, Exception ex, params object[] args)
        {
            LogMgr.logger.Error(LogMgr.make(message, "AndroidWebSvr", 0, args), ex);
        }
        /// <summary>
        /// Logs the specified message as info.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        private static void log(string message, bool info, params object[] args)
        {
            string s = LogMgr.make(message, "AndroidWebSvr", 0, args);
            if (info) LogMgr.logger.Info(s);
            else LogMgr.logger.Debug(s);
        }
    }
}
