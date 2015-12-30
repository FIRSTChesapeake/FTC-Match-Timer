using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;

namespace FTC_Timer_Display
{
    public static class GeneralFunctions
    {
        // App Info
        public static string appVersion
        {
            get
            {
                return string.Format("Version {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            }
        }
        public static string appName
        {
            get
            {
                return Application.ProductName;
            }
        }

        public static string makeWindowTitle(string windowTitle, bool withVersion = false)
        {
            string v = withVersion ? string.Format(" {0}", appVersion) : "";
            return string.Format("{0}{1} - {2}", appName, v, windowTitle);
        }
    }
}
