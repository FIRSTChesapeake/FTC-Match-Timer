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
    public partial class PitFieldDisplay : UserControl
    {
        private DateTime _lastComms = DateTime.Now.AddMonths(-1);
        private MatchData _lastData = null;

        public PitFieldDisplay() { }
        public PitFieldDisplay(MatchData data, bool activeField = false)
        {
            InitializeComponent();
            UpdateData(data, activeField);
        }

        public bool isThisField(MatchData data, PitData.PitDataSelections displaySelect)
        {
            if (data.divID != _lastData.divID) return false;
            if (displaySelect == PitData.PitDataSelections.ActiveOnly) return true;
            if (data.fieldID == _lastData.fieldID) return true;
            return false;
        }

        public void UpdateData(MatchData data, bool activeField = false)
        {
            _lastComms = DateTime.Now;
            string div = data.divisionName == "" ? string.Format("Division {0}", data.divID) : string.Format("{0} Division", data.divisionName);
            lblHeader.Text = string.Format("{0} Field {1}", div, data.fieldID.ToString());
            lblMatchNumber.Text = string.Format("{0} {1}", data.matchType.ToString(), data.matchNumberString);
            lblMatchState.Text = data.matchStatus.ToString();
            lblMatchPeriod.Text = data.matchPeriod.ToString();
            lblMatchTime.Text = data.timerValue.ToString();

            if (activeField) lblHeader.BackColor = Color.Green;
            else lblHeader.BackColor = Color.Yellow;

            _lastData = data;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            // If we receive anything at all.. set the ind light
            TimeSpan t = new TimeSpan(0, 0, Properties.Settings.Default.DeadFieldDelay);
            if (DateTime.Now > _lastComms.Add(t)) picMainComms.Image = Properties.Resources.indicator_red;
            else picMainComms.Image = Properties.Resources.indicator_green;
            // Match State Indicator
            switch (_lastData.matchStatus)
            {
                case MatchData.MatchStatus.Stopped: picMatchState.Image = Properties.Resources.indicator_red; break;
                case MatchData.MatchStatus.Paused: picMatchState.Image = Properties.Resources.indicator_yellow; break;
                case MatchData.MatchStatus.Running: picMatchState.Image = Properties.Resources.indicator_green; break;
            }
        }
    }
}
