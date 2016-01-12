using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC_Timer_Display
{
    public partial class SingleClientDisplay : UserControl
    {
        public event EventHandler GeneralClick;
        public event EventHandler<RadialCommands> RadialAction;

        public SingleClientDisplay(int fieldID, int recvPort, bool local, EventHandler clickHandler, EventHandler<RadialCommands> radialHandler, int width)
        {
            InitializeComponent();
            GeneralClick += clickHandler;
            RadialAction += radialHandler;
            this.Width = width;
            string sLocal = local ? "*" : "";
            lblFieldName.Text = string.Format("FIELD {0}{1}", fieldID.ToString(), sLocal);
            if (local)
            {
                this.isOnline = true;
                toolTips.SetToolTip(lblFieldName, "Local");
            }
            else toolTips.SetToolTip(lblFieldName, recvPort.ToString());
        }

        public bool isOnline = false;

        public void UpdateDisplay(MatchData data, bool isSelected, bool allowStart)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => UpdateDisplay(data, isSelected, allowStart)));
            }
            else
            {
                // Are we selected?
                this.BackColor = isSelected ? Color.LightBlue : Color.Transparent;
                // Match Number
                lblMatch.Text = string.Format("{0} {1}", data.matchTypeShort, data.matchNumberString);
                // Update Display
                Image img = Properties.Resources.indicator_red;
                if (!this.isOnline)
                {
                    img = Properties.Resources.offline;
                    lblState.Text = "OFFILINE";
                }
                else if (data.matchStatus == MatchData.MatchStatus.Running)
                {
                    img = Properties.Resources.indicator_green;
                    lblState.Text = data.timerValue.ToString();
                }
                else if (data.matchStatus == MatchData.MatchStatus.Paused)
                {
                    img = Properties.Resources.indicator_yellow;
                    lblState.Text = "Paused";
                }
                else if (data.matchStatus == MatchData.MatchStatus.Timeout)
                {
                    img = Properties.Resources.indicator_blue;
                    lblState.Text = data.timerValue.ToString();
                }
                else
                {
                    img = Properties.Resources.indicator_red;
                    lblState.Text = data.matchStatus.ToString();
                }
                tableIndicator.BackgroundImage = img;
                // Update radial menu
                radialStart.Visible = (data.isWaitingForStart && allowStart) || data.matchStatus == MatchData.MatchStatus.Paused;
                radialStart.Text = data.isWaitingForStart && data.matchStatus == MatchData.MatchStatus.Paused ? "Resume" : "Start";
                radialPause.Visible = data.matchStatus == MatchData.MatchStatus.Running;
                radialStop.Visible = data.matchStatus == MatchData.MatchStatus.Paused;
                radialReset.Visible = !data.isMatchActive && data.matchStatus != MatchData.MatchStatus.Timeout;
                radialTimeout.Visible = !data.isMatchActive;
                radialTimeout.Text = data.matchStatus == MatchData.MatchStatus.Timeout ? "Extend" : "Timeout";
                radialStopTimeout.Visible = data.matchStatus == MatchData.MatchStatus.Timeout;
            }
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            if (GeneralClick != null)
            {
                EventHandler handler = GeneralClick;
                handler(this, null);
            }
        }

        public enum RadialCommands
        {
            None,
            Start,
            Pause,
            Stop,
            Reset,
            Timeout,
            AbortTimeout
        }

        private void radialHandler(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.RadialMenuItem item = (DevComponents.DotNetBar.RadialMenuItem)sender;
            RadialCommands cmd = RadialCommands.None;
            if (item.Equals(radialStart)) cmd = RadialCommands.Start;
            else if (item.Equals(radialPause)) cmd = RadialCommands.Pause;
            else if (item.Equals(radialStop)) cmd = RadialCommands.Stop;
            else if (item.Equals(radialReset)) cmd = RadialCommands.Reset;
            else if (item.Equals(radialTimeout)) cmd = RadialCommands.Timeout;
            else if (item.Equals(radialStopTimeout)) cmd = RadialCommands.AbortTimeout;

            if (cmd != RadialCommands.None && RadialAction != null)
            {
                EventHandler<RadialCommands> handler = RadialAction;
                handler(this, cmd);
            }
        }
    }
}
