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
    public partial class frmStartTimeout : DevComponents.DotNetBar.OfficeForm
    {
        private List<SingleClient> _fields;

        public frmStartTimeout(MatchData.MatchTypes type, ref List<SingleClient> availableFields, SingleClient forcedSelected = null)
        {
            InitializeComponent();
            // Initialize field list
            _fields = availableFields;
            cboFields.DisplayMember = "DisplayString";
            cboFields.DataSource = _fields;
            if (forcedSelected == null)
            {
                foreach (SingleClient c in _fields) if (c.isSelected) cboFields.SelectedItem = c;
            }
            else
            {
                cboFields.SelectedItem = forcedSelected;
            }

            rdoSoundVoice.Enabled = SoundGenerator.voiceReady;
        }

        private void frmStartTimeout_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void RadioButtonChangeHandler(object sender, EventArgs e)
        {
            cboAlliance.Enabled = rdoAllianceCalled.Checked;
            txtCustomMsg.Enabled = rdoOther.Checked;
            if (rdoAllianceCalled.Checked) timeValue.Value = MatchTimingData.timeoutTeamLength;
            if (rdoOther.Checked) timeValue.Value = MatchTimingData.timeoutEventLength;
        }

        private string timeoutMessage
        {
            get
            {
                if (rdoAllianceCalled.Checked) return string.Format("{0} Timeout", cboAlliance.Text);
                return txtCustomMsg.Text;
            }
        }

        private SingleClient.TimeoutData.SoundTypes soundType
        {
            get
            {
                if (rdoSoundBuzzer.Checked) return SingleClient.TimeoutData.SoundTypes.Buzzer;
                if (rdoSoundVoice.Checked) return SingleClient.TimeoutData.SoundTypes.Voice;
                return SingleClient.TimeoutData.SoundTypes.None;
            }
        }

        private void HandleButtons(object sender, EventArgs e)
        {
            if (sender.Equals(btnStart))
            {
                SingleClient c = (SingleClient)cboFields.SelectedItem;
                SingleClient.TimeoutData data = new SingleClient.TimeoutData(timeValue.Value, timeoutMessage, soundType);
                if (rdoReplaceTime.Checked) c.ResetMatch();
                c.StartTimeout(data);
            }
            this.Close();
        }

        private void cboFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            SingleClient c = (SingleClient)cboFields.SelectedItem;
            bool allowed = true;
            // Allow / Disallow Alliance Timeout
            cboAlliance.Items.Clear();
            if (MatchTimingData.matchTypeAllowsTimeout(c.matchData.matchType) && !c.isMatchActive)
            {
                // We can call / extend either type of timeout
                timeValue.Value = MatchTimingData.timeoutTeamLength;
                rdoAllianceCalled.Checked = true;
                rdoAllianceCalled.Enabled = true;
                // TODO: Once we import the match schedule, we can customize this list based on the advancing teams.
                //          For now, we'll just list all possible alliances based on Quarterfinals count (even though we don't use Quarterfinals.)
                int allianceCount = MatchTimingData.getMatchTypeAllianceCount(MatchData.MatchTypes.Quarterfinals);
                for (int i = 1; i <= allianceCount; i++) cboAlliance.Items.Add(string.Format("Alliance {0}", i.ToString()));
                cboAlliance.SelectedIndex = 0;
            }
            else if(!c.isMatchActive)
            {
                // We can call / extend an event timeout, but not an alliance timeout
                timeValue.Value = MatchTimingData.timeoutEventLength;
                rdoOther.Checked = true;
                rdoAllianceCalled.Enabled = false;
            }
            else
            {
                // Timeouts caren't available for this field (it's running a match)
                allowed = false;
            }
            btnStart.Enabled = allowed;
            lblCantTimeout.Visible = !allowed;

            lblAlreadyRunning.Visible = c.matchData.matchStatus == MatchData.MatchStatus.Timeout;
            grpModify.Visible = c.matchData.matchStatus == MatchData.MatchStatus.Timeout;
            btnStart.Text = c.matchData.matchStatus == MatchData.MatchStatus.Timeout ? "Edit Timeout" : "Start Timeout";
        }
    }
}