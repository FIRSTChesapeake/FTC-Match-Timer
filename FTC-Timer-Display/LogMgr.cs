using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using log4net.Repository;
using log4net.Core;
using log4net.Util;
using log4net.Appender;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace FTC_Timer_Display
{
    public static class LogMgr
    {
        private static readonly bool isDev = Process.GetCurrentProcess().ProcessName.ToLower().Contains("vshost");

        private const string configFileName = "log4net.config";

        private static ILog _log = null;
        public static ILog logger
        {
            get
            {
                if (!_isInit)
                {
                    if (isDev) throw new Exception("Logging called before init!");
                    else return null;
                }
                else
                {
                    return _log;
                }
            }
        }
        private static bool _isInit = false;

        static LogMgr()
        {
            
        }

        public static void init(string loggerName)
        {
            try
            {
                if (_isInit) return;

                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configFileName);
                Uri configUri = new Uri(configPath);
                // Configure Logger
                Debug.WriteLine(string.Format("Loading log4net configuration from '{0}'", configUri.ToString()));
                XmlConfigurator.Configure(configUri);
                _log = LogManager.GetLogger(loggerName);
                log4net.GlobalContext.Properties["fClass"] = "Global";
                _log.Info("Logger Initialized");
                _isInit = true;
            }
            catch (Exception ex)
            {
                // Maybe some better handling here later?
                throw ex;
            }
        }

        public static string make(string message, string from = "", int indent = 0, params object[] args)
        {
            // handle the limited From field.
            int maxLen = 20;
            if (from.Length > maxLen) from = from.Substring(0, maxLen);
            else from = from.PadRight(20, ' ');
            // Fill in any params if given.
            if (args.Length > 0)
            {
                message = string.Format(message, args);
            }
            // return the message formatted.
            return string.Format("[{0}] {1}{2}", from, makeIndent(indent), message);
        }

        private static string makeIndent(int indent)
        {
            if (indent < 1) return "";
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= indent; i++) sb.Append("    ");
            return sb.ToString();
        }

        public static string displayString(string propertyName)
        {
                switch (propertyName)
                {
                    case "logInitialSetupSteps": return "Log Initial Setup";
                    case "logMatchDataChanges": return "Log changes at the Match Level";
                    case "logSingleClientChanges": return "Log changes at Field Level (recommended)";
                    default: return "Unknown Setting. Better leave this alone?";
                }
        }

        public static List<string> LogLocation
        {
            get
            {
                List<string> ret = new List<string>();
                IAppender[] appenders = logger.Logger.Repository.GetAppenders();
                foreach (IAppender a in appenders)
                {
                    Type t = a.GetType();
                    if (t.Equals(typeof(FileAppender))) ret.Add(((FileAppender)a).File);
                    if (t.Equals(typeof(RollingFileAppender))) ret.Add(((RollingFileAppender)a).File);
                }
                return ret;
            }
        }
    }
}
