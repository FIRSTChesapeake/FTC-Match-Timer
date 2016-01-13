using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public partial class frmPitDisplay : DevComponents.DotNetBar.OfficeForm
    {
        private Dictionary<string, string> urls = new Dictionary<string, string>();

        // TODO: Move these into a list/array so I can stop having bunches of vars.
        private string scoringServer1 = "";
        private string scoringServer2 = "";
        private int scrollSpeed1 = 10;
        private int scrollSpeed2 = 10;


        private myUdpClient.UdpComms comms;

        private DateTime _lastComms = DateTime.Now.AddMonths(-1);
        private bool _forceRefresh = false;
        //private DateTime _lastRefresh = DateTime.Now.AddMonths(-1);
        private static TimeSpan refreshDelay = new TimeSpan(0, 1, 0);

        public frmPitDisplay(InitialData init)
        {
            InitializeComponent();
            // setup URLs we want to display for each division
            urls.Add("results", "http://{0}:8080/MatchResults");
            urls.Add("ranking", "http://{0}:8080/Rankings");

            // Setup comms
            comms = new myUdpClient.UdpComms(DataReceived, CommStopExceptionHandler);
            comms.ListenControl(true);
        }

        private void CommStopExceptionHandler(object sender, myUdpClient.myUdpException e)
        {
            // Todo
        }

        private void DataReceived(object sender, PitData pitData)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => DataReceived(sender, pitData)));
            }
            else
            {
                // I hear ya!
                this._lastComms = DateTime.Now;
                // If the PitData package knows where our scoring server is, note that.
                if (pitData.divID == 1)
                {
                    scoringServer1 = pitData.scoringAddress;
                    scrollSpeed1 = pitData.scrollSpeed;
                }
                if (pitData.divID == 2)
                {
                    scoringServer2 = pitData.scoringAddress;
                    scrollSpeed2 = pitData.scrollSpeed;
                }
                // Which Flow Panel are we working with?
                FlowLayoutPanel flow = pitData.divID == 1 ? flowDiv1 : flowDiv2;
                // If the server says clear, do it.
                if (pitData.clearData) flow.Controls.Clear();
                // The pit data can contain more than 1 field.
                foreach (MatchData d in pitData.fieldData)
                {
                    bool activeField = pitData.activeField == d.fieldID;
                    bool found = false;
                    foreach (PitFieldDisplay f in flow.Controls)
                    {
                        if (f.isThisField(d, pitData.pitDataSelection))
                        {
                            f.UpdateData(d, activeField);
                            found = true;
                            continue;
                        }
                    }
                    if (!found)
                    {
                        PitFieldDisplay p = new PitFieldDisplay(d, activeField);
                        flow.Controls.Add(p);
                    }
                }
            }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            // If we receive anything at all.. set the ind light
            TimeSpan t = new TimeSpan(0, 0, Properties.Settings.Default.DeadFieldDelay);
            if (!comms.isListening) picMainComms.Image = Properties.Resources.indicator_red;
            else if (DateTime.Now > _lastComms.Add(t)) picMainComms.Image = Properties.Resources.indicator_yellow;
            else picMainComms.Image = Properties.Resources.indicator_green;

            // Refresh the match data browsers if we have the data
            if (scoringServer1 != "")
            {
                scrollBrowser(browserDiv1results, scoringServer1, scrollSpeed1, "results", _forceRefresh);
                scrollBrowser(browserDiv1ranking, scoringServer1, scrollSpeed1, "ranking", _forceRefresh);
            }
            if (scoringServer2 != "")
            {
                scrollBrowser(browserDiv2results, scoringServer2, scrollSpeed2, "results", _forceRefresh);
                scrollBrowser(browserDiv2ranking, scoringServer2, scrollSpeed2, "ranking", _forceRefresh);
            }
            _forceRefresh = false;
        }

        private void scrollBrowser(WebBrowser browser, string host, int speed, string urlKey, bool forceRefresh = false)
        {
            if (host == "") return;
            if (browser.Tag == null) browser.Tag = 0;
            int pos = (int)browser.Tag;
            // Time to change pages / refresh
            if ((!browser.IsBusy || _forceRefresh) && (browser.Document == null || pos >= browser.Document.Body.ScrollRectangle.Height || forceRefresh))
            {
                if (browser.Document != null) browser.Document.Window.ScrollTo(0, 0);
                pos = 0;
                string url = string.Format(urls[urlKey], host);
                browser.Navigate(url);
            }
            else if (browser.IsBusy)
            {
                // wait
            }
            else if (browser.Document != null)
            {
                pos = pos + speed;
                browser.Document.Window.ScrollTo(0, pos);
            }
            browser.Tag = pos;
        }

        private void frmPitDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F5:
                    _forceRefresh = true;
                    break;
            }
        }

        private void frmPitDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}