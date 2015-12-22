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
        public frmStartTimeout(MatchData.MatchTypes type, bool alreadyRunning)
        {
            InitializeComponent();
            if (MatchTimingData.matchTypeAllowsTimeout(type))
            {
                timeValue.Value = MatchTimingData.timeoutTeamLength;
                // TODO: Once we import the match schedule, we can customize this list based on the advancing teams.
                //          For now, we'll just list all possible alliances based on Quarterfinals count (even though we don't use Quarterfinals.)
                int allianceCount = MatchTimingData.getMatchTypeAllianceCount(MatchData.MatchTypes.Quarterfinals);
                for (int i = 1; i <= allianceCount; i++) cboAlliance.Items.Add(string.Format("Alliance {0}", i.ToString()));
                cboAlliance.SelectedIndex = 0;
            }
            else
            {
                timeValue.Value = MatchTimingData.timeoutEventLength;
                rdoOther.Checked = true;
                rdoAllianceCalled.Enabled = false;
            }
            lblAlreadyRunning.Visible = alreadyRunning;
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
                SingleClient.TimeoutData data = new SingleClient.TimeoutData(timeValue.Value, timeoutMessage, soundType);
                this.Tag = data;
            }
            this.Visible = false;
        }
    }
}