using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace FTC_Timer_Display
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // LOGGING!
            LogMgr.init("FTC-Timer-App");
            LogMgr.logger.Info(LogMgr.make("Application {0} Starting..", "Main", 0, GeneralFunctions.AppFunctions.appVersionString));
            if (Control.ModifierKeys == Keys.Shift)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                LogMgr.logger.Info(LogMgr.make("Settings Cleared", "Main"));
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load stored settings or request settings from user.
            int AppSettingsError = 0;
            InitialData initData = InitialData.LoadAppSettings(out AppSettingsError);
            // Handle the missing Data error. Without it, we cant' continue.
            if (initData == null || initData.runType == InitialData.RunType.None)
            {
                // Close quietly.
            }
            else
            {
                initData.lockMutex();
                LogMgr.logger.Info(LogMgr.make("Starting {0}!", "Main", 0, initData.runType));
                if (initData.runType == InitialData.RunType.PitDisplay)
                {
                    Application.Run(new frmPitDisplay(initData));
                }
                else
                {
                    Application.Run(new frmMain(initData));
                }

            }
        }
    }
}
