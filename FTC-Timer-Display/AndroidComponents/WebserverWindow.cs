using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ZXing.QrCode;
using ZXing.Common;
using ZXing.OneD;
using ZXing;

namespace FTC_Timer_Display.AndroidComponents
{
    public partial class WebserverWindow : DevComponents.DotNetBar.OfficeForm
    {
        public WebserverWindow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblServerStatus.Text = AndroidWebserver.isRunning ? "Running" : "Stopped";
        }

        private void btnToggleServer_Click(object sender, EventArgs e)
        {
            //TODO: Make port configurable
            if (!AndroidWebserver.isRunning) AndroidWebserver.Start();
            else AndroidWebserver.Stop();
        }

        private void WebserverWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void WebserverWindow_Load(object sender, EventArgs e)
        {
            bool isAdmin = GeneralFunctions.AppFunctions.isRunningAsAdmin;
            btnToggleServer.Enabled = isAdmin;
            lblAdminWarning.Visible = !isAdmin;
        }

        public void AddLogEvent(string eventString)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => AddLogEvent(eventString)));
            }
            else
            {
                try
                {
                    string s = string.Format("====== {0} ======");
                    listLog.Items.Add(s);
                    listLog.SelectedIndex = listLog.Items.Count - 1;
                }
                catch { }
            }
        }

        public void AddLogAction(string username, string ip, string action)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => AddLogAction(username, ip, action)));
            }
            else
            {
                try
                {
                    string s = string.Format("{0} | {1} | {2}", ip, username, action);
                    listLog.Items.Add(s);
                    listLog.SelectedIndex = listLog.Items.Count - 1;
                }
                catch { }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listLog.Items.Clear();
        }

        public void SetQR(string host, int port, string key)
        {
            
            string settingsString = string.Format("{0}|{1}|{2}", host, port, key);
            string appString = string.Format("http://{0}:{1}/app?key={2}", host, port, key);

            imgQR.Image = GenerateQR(settingsString);
            imgApp.Image = GenerateQR(appString);
            lblHost.Text = host;
            lblPort.Text = port.ToString();
            lblKey.Text = key;
        }

        public void ClearQR()
        {
            imgQR.Image = null;
            imgApp.Image = null;
            lblHost.Text = "None";
            lblPort.Text = "None";
            lblKey.Text = "None";
        }

        private static Image GenerateQR(string data)
        {
            QRCodeWriter w = new QRCodeWriter();
            BitMatrix matrix = w.encode(data, ZXing.BarcodeFormat.QR_CODE, 100, 100);
            BarcodeWriter writer = new BarcodeWriter();
            Bitmap bitmap = writer.Write(matrix);
            return bitmap;
        }
    }
}