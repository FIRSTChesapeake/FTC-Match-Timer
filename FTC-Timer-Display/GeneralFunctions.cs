using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace FTC_Timer_Display
{
    public static class GeneralFunctions
    {
        public static class AppFunctions
        {
            public static readonly string AppPath = AppDomain.CurrentDomain.BaseDirectory;

            // App Info
            public static string appVersionString
            {
                get
                {
                    return string.Format("Version {0}", appVersion);
                }
            }
            public static Version appVersion
            {
                get
                {
                    return Assembly.GetExecutingAssembly().GetName().Version;
                }
            }

            public static string appName
            {
                get
                {
                    return Application.ProductName;
                }
            }
            // Make a window title
            public static string makeWindowTitle(string windowTitle, bool withVersion = false)
            {
                string v = withVersion ? string.Format(" {0}", appVersionString) : "";
                return string.Format("{0}{1} - {2}", appName, v, windowTitle);
            }
            // Open a link
            public static void OpenLink(string link, string title)
            {
                string msg = string.Format("This will open your web browser and navigate to the {0}.\nAre you sure you want to do this now?", title);
                DialogResult dr = MessageBox.Show(msg, "Open Link", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.No) return;
                Process.Start(link);
            }
        }
        public static class FileFunctions
        {
            public static readonly string docsPath = String.Format(@"{0}\{1}", AppFunctions.AppPath, "docs");
            public const string genericFileOopsPlain = "Well, this is embarrassing. We seemed to have failed to fetch this text. Sorry.";
            public static readonly string genericFileOopsHTML = string.Format("<div align='center'>{0}</div>", genericFileOopsPlain);

            // read a docs file into a string
            public static string readDocsFile(string file, string errorString = "")
            {
                try
                {
                    LogMgr.logger.Debug(LogMgr.make("Loading file '{0}' to string.", "readDocsFile", 0, file));
                    string fullPath = string.Format(@"{0}\{1}", docsPath, file);
                    string data = File.ReadAllText(fullPath);
                    LogMgr.logger.Debug(LogMgr.make("File '{0}' Loaded.", "readDocsFile", 1, file));
                    return data;
                }
                catch (Exception ex)
                {
                    LogMgr.logger.Error(LogMgr.make("Loading File '{0}' Failed.", "readDocsFile", 1, file), ex);
                    return errorString;
                }
            }
            /// <summary>
            /// Loads an image from a file path.
            /// </summary>
            /// <param name="path">The path to the image.</param>
            /// <returns>The image desired.</returns>
            public static Image LoadImgFromFile(string path)
            {
                try
                {
                    if (!File.Exists(path)) return null;
                    Image img = Image.FromFile(path);
                    return img;
                }
                catch
                {
                    return null;
                }
            }

        }
    }
}
