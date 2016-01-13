using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;

namespace FTC_Timer_Display.myUdpClient
{
    public class UdpComms
    {
        public static readonly int udpPortSend = 5400;
        public int udpPortRecv{ get; private set; }
        private IPEndPoint Broadcast = new IPEndPoint(IPAddress.Broadcast, udpPortSend);

        private bool _listening = false;
        private UdpClient _udp = null;

        public event EventHandler<MatchData> NewMatchData;
        public event EventHandler<PitData> NewPitData;
        public event EventHandler<ScoringData> NewScoringData;
        public event EventHandler<ClientReply> NewClientReply;

        public event EventHandler<myUdpException> StopExceptionEvent;

        public bool isListening { get { return _listening; } }

        private readonly string logName;

        /// <summary>
        /// Initializes a new instance of the <see cref="UdpComms"/> class for use with field communications.
        /// </summary>
        /// <param name="divID">The division identifier.</param>
        /// <param name="fieldID">The field identifier.</param>
        /// <param name="NewDataHandler">Handler that wants the data when it's received.</param>
        public UdpComms(int divID, int fieldID, EventHandler<MatchData> NewDataHandler, EventHandler<myUdpException> StopExceptionHandler)
        {
            StopExceptionEvent += StopExceptionHandler;
            logName = string.Format("udpComms-{0}-{1}", divID, fieldID);
            NewMatchData += NewDataHandler;
            udpPortRecv = CreateRecvPort(divID, fieldID);
            ConfigurePort();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UdpComms"/> class for use with pit screens.
        /// </summary>
        /// <param name="NewDataHandler">Handler that wants the data when it's received.</param>
        public UdpComms(EventHandler<PitData> NewDataHandler, EventHandler<myUdpException> StopExceptionHandler)
        {
            StopExceptionEvent += StopExceptionHandler;
            logName = "udpComms-Pit";
            NewPitData += NewDataHandler;
            udpPortRecv = CreateRecvPort(0, 0);
            ConfigurePort();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UdpComms"/> class for sniffing up scoring udp broadcasts.
        /// </summary>
        /// <param name="scoringPort">The scoring port.</param>
        /// <param name="NewDataHandler">Handler that wants the data when it's received.</param>
        public UdpComms(int scoringPort, EventHandler<ScoringData> NewDataHandler, EventHandler<myUdpException> StopExceptionHandler)
        {
            StopExceptionEvent += StopExceptionHandler;
            logName = "udpComms-Score";
            NewScoringData += NewDataHandler;
            udpPortRecv = scoringPort;
            ConfigurePort();
        }

        /// <summary>
        /// Creates the recv port for fields based on a base port and the division/field that is provided.
        /// </summary>
        /// <param name="div">The division.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public static int CreateRecvPort(int div, int field)
        {
            int portMod = (10 * div) + field;
            int port = udpPortSend + portMod;
            return port;
        }
        /// <summary>
        /// Configures the port for the given data and turns on broadcasting.
        /// </summary>
        private void ConfigurePort()
        {
            try
            {
                _udp = new UdpClient(udpPortRecv);
                _udp.EnableBroadcast = true;
                EndPoint localEndpoint = _udp.Client.LocalEndPoint;
                log("Recv Port Configured to '{0}'", localEndpoint.ToString());
            }
            catch (SocketException ex)
            {
                RaiseStopException("Port Already in use.", ex);
            }
            catch (Exception ex)
            {
                log("Exception Configuring Port", ex);
            }
        }

        /// <summary>
        /// Logs the specified message as error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The exception thrown</param>
        /// <param name="args">The arguments.</param>
        private void log(string message, Exception ex, params object[] args)
        {
            LogMgr.logger.Error(LogMgr.make(message, logName, 0, args), ex);
        }
        /// <summary>
        /// Logs the specified message as info.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        private void log(string message, params object[] args)
        {
            LogMgr.logger.Info(LogMgr.make(message, logName, 0, args));
        }

        /// <summary>
        /// Controls whether the UDP port is listening for packets or not.
        /// </summary>
        /// <param name="status">Boolean. Whether to Listen for packets.</param>
        public void ListenControl(bool status)
        {
            log("Setting Listening to {0}..", status);
            if (status)
            {
                if (!_listening)
                {
                    if (_udp.Client == null) ConfigurePort();
                    StartListening();
                    log("Listening Started.");
                }
            }
            else
            {
                if (_udp != null)
                {
                    _listening = false;
                    _udp.Close();
                    log("Listening Stoppped.");
                }
            }
        }
        /// <summary>
        /// Internal function to start listening (initially or after receiving something.)
        /// </summary>
        private void StartListening()
        {
            try
            {
                _listening = true;
                _udp.BeginReceive(ReceiveCallback, null);
            }
            catch (Exception ex)
            {
                _listening = false;
                log("Exception Starting Listening", ex);
            }
        }
        /// <summary>
        /// Receives the callback from the UDP port.
        /// </summary>
        /// <param name="ar">The async result of the return.</param>
        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, udpPortRecv);
                byte[] bytes = _udp.EndReceive(ar, ref endpoint);
                BinaryFormatter bf = new BinaryFormatter();
                object data = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(bytes, 0, bytes.Length);
                    ms.Seek(0, SeekOrigin.Begin);
                    data = (object)bf.Deserialize(ms);
                }
                try
                {
                    UdpContainer managedPackage = (UdpContainer)data;
                    managedPackage.fromEndpoint = endpoint;
                    HandleManagedPackage(managedPackage);
                }
                catch (InvalidCastException)
                {
                    // It's not a managed package - this will expand to actual handle the scoring data soon.
                    Debug.WriteLine(string.Format("Non-Managed Package Received on port {0}.", this.udpPortRecv));
                }
                StartListening();
            }
            catch (ObjectDisposedException)
            {
                // Nada
            }
            catch (Exception ex)
            {
                log("Unhandled Exception Receiving Callback.", ex);
            }
        }
        /// <summary>
        /// Handles the managed packages we control.
        /// </summary>
        /// <param name="data">The package.</param>
        private void HandleManagedPackage(UdpContainer data)
        {
            try
            {
                // If the package contains MatchData
                if (data.packageType == UdpContainer.UdpPackageTypes.MatchData)
                {
                    MatchData matchData = (MatchData)data.package;
                    matchData.fromEndpoint = data.fromEndpoint;
                    if (NewMatchData != null && matchData != null)
                    {
                        EventHandler<MatchData> handler = NewMatchData;
                        handler(this, matchData);
                    }
                }
                else if (data.packageType == UdpContainer.UdpPackageTypes.PitData)
                {
                    PitData pitData = (PitData)data.package;
                    if (NewPitData != null && pitData != null)
                    {
                        EventHandler<PitData> handler = NewPitData;
                        handler(this, pitData);
                    }
                }
                else if (data.packageType == UdpContainer.UdpPackageTypes.ClientReply)
                {
                    ClientReply clientReply = (ClientReply)data.package;
                    clientReply.fromEndpoint = data.fromEndpoint;
                    if (NewClientReply != null && clientReply != null)
                    {
                        EventHandler<ClientReply> handler = NewClientReply;
                        handler(this, clientReply);
                    }
                }
            }
            catch (Exception ex)
            {
                log("Exception Handing Managed Package", ex);
            }
        }

        public void SendClientReply(ClientReply reply)
        {
            try
            {
                UdpContainer pack = new UdpContainer(UdpContainer.UdpPackageTypes.ClientReply, reply);
                SendObject(pack, reply.fromEndpoint);
            }
            catch (Exception ex)
            {
                log("Exception sending client reply", ex);
            }
        }

        /// <summary>
        /// Broadcasts the match data to the given field port.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="fieldPort">The field port.</param>
        public void BroadcastMatchData(MatchData data, int fieldPort)
        {
            try
            {
                UdpContainer pack = new UdpContainer(UdpContainer.UdpPackageTypes.MatchData, data);
                IPEndPoint sendTo = new IPEndPoint(IPAddress.Broadcast, fieldPort);
                SendObject(pack, sendTo);
            }
            catch (Exception ex)
            {
                log("Exception Broadcasting Match Data", ex);
            }
        }

        /// <summary>
        /// Broadcasts the pit data to any listening pit displays.
        /// </summary>
        /// <param name="data">The data.</param>
        public void BroadcastPitData(PitData data)
        {
            try
            {
                UdpContainer pack = new UdpContainer(UdpContainer.UdpPackageTypes.PitData, data);
                int port = udpPortSend;
                IPEndPoint sendTo = new IPEndPoint(IPAddress.Broadcast, port);
                SendObject(pack, sendTo);
            }
            catch (Exception ex)
            {
                log("Exception Broadcasting Pit Data", ex);
            }
        }

        /// <summary>
        /// Sends the raw object to the given endpoint.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="sendTo">The send to.</param>
        private void SendObject(UdpContainer data, IPEndPoint sendTo)
        {
            try
            {
                if (_udp != null && _udp.Client != null)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bf.Serialize(ms, data);
                        byte[] bytes = ms.ToArray();
                        _udp.Send(bytes, bytes.Length, sendTo);
                    }
                }
            }
            catch (Exception ex)
            {
                string ip = sendTo == null ? "NULL" : string.Format("{0}:{1}", sendTo.Address, sendTo.Port);
                log("Exception sending object to '{0}'", ex, ip);
            }
        }

        private void RaiseStopException(string message, SocketException ex)
        {
            myUdpException udpEx = myUdpException.Make<myUdpException>(ex);
            udpEx.appMessage = message;
            log("Raising Stop Exception: '{0}'.", udpEx, message);
            if (StopExceptionEvent != null)
            {
                EventHandler<myUdpException> handler = StopExceptionEvent;
                handler(this, udpEx);
            }
        }
    }
}
