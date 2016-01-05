using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Threading;

namespace FTC_Timer_Display
{
    public partial class frmLoading : DevComponents.DotNetBar.OfficeForm
    {

        private static frmLoading _screen;
        public static Thread _thread;

        public static bool isShowing
        {
            get
            {
                return _screen != null;
            }
        }

        public static void StartLoadScreen(string initialMessage)
        {
            // Only allow 1 loading screen
            if (_screen != null) return;
            LogMgr.logger.Debug(LogMgr.make("Loading screen initialized", "frmLoading"));
            _thread = new Thread((ThreadStart)delegate { ShowForm(initialMessage); });
            _thread.IsBackground = true;
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private static void ShowForm(string label)
        {
            _screen = new frmLoading(label);
            Application.Run(_screen);
        }

        public static void CloseForm()
        {
            try
            {
                _screen.Invoke(new CloseDelegate(frmLoading.CloseFormInternal));
                LogMgr.logger.Debug(LogMgr.make("Loading screen stopped", "frmLoading"));
            }
            catch { }
        }

        public static void UpdateDisplay(string newDisplay, int percent = -1)
        {
            try
            {
                _screen.Invoke(new UpdateDelegate(frmLoading.UpdateFormInternal), newDisplay, percent);
            }
            catch { }
        }

        private delegate void CloseDelegate();
        public static void CloseFormInternal()
        {
            _screen.Close();
            _screen = null;
            _thread = null;
        }
        private delegate void UpdateDelegate(string newMessage, int percent);
        public static void UpdateFormInternal(string newMessage, int percent)
        {
            _screen.updateDisplay(newMessage, percent);
        }

        private frmLoading(string initialMessage)
        {
            InitializeComponent();
            this.Text = GeneralFunctions.AppFunctions.makeWindowTitle(this.Text, false);
        }

        private void updateDisplay(string newMessage, int percent)
        {
            this.lblCurrent.Text = newMessage;
            if (percent != -1)
            {
                pb.ProgressType = eProgressItemType.Standard;
                percent = Math.Min(percent, 100);
                percent = Math.Max(percent, 0);
                pb.Value = percent;
            }
            else
            {
                pb.ProgressType = eProgressItemType.Marquee;
            }
        }
    }
}