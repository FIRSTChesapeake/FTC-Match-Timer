using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FTC_Timer_Display
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                Debug.WriteLine("Settings Reset");
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
