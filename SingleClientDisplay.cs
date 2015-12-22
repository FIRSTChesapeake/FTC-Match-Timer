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

        public event EventHandler WasClicked;

        public SingleClientDisplay(int fieldID, bool local, EventHandler clickHandler)
        {
            InitializeComponent();
            WasClicked += clickHandler;
            string sLocal = local ? "*" : "";
            lblFieldName.Text = string.Format("FIELD {0}{1}", fieldID.ToString(), sLocal);
        }

        public void UpdateDisplay(MatchData data, bool isSelected)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => UpdateDisplay(data, isSelected)));
            }
            else
            {
                // Are we selected?
                this.BackColor = isSelected ? Color.LightBlue : Color.Transparent;
                // Match Number
                lblMatch.Text = data.matchNumberString;
                // Update Display
                if (data.matchStatus == MatchData.MatchStatus.Running)
                {
                    picInd.Image = Properties.Resources.indicator_green;
                    lblState.Text = data.timerValue.ToString();
                }
                else if (data.matchStatus == MatchData.MatchStatus.Paused)
                {
                    picInd.Image = Properties.Resources.indicator_yellow;
                    lblState.Text = "Paused";
                }
                else if (data.matchStatus == MatchData.MatchStatus.Timeout)
                {
                    picInd.Image = Properties.Resources.indicator_blue;
                    lblState.Text = data.timerValue.ToString();
                }
                else
                {
                    picInd.Image = Properties.Resources.indicator_red;
                    lblState.Text = data.matchStatus.ToString();
                }
            }
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            if (WasClicked != null)
            {
                EventHandler handler = WasClicked;
                handler(this, null);
            }
        }
    }
}
