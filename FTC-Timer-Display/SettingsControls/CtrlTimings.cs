using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Validator;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display.SettingsControls
{
    public partial class CtrlTimings : UserControl
    {
        public CtrlTimings()
        {
            InitializeComponent();
        }

        public void LoadValues()
        {
            timingMatch.Value = MatchTimingData.matchLength;
            timingAuto.Value = MatchTimingData.autoLength;
            timingNocross.Value = MatchTimingData.nocrossLength;
            timingEndgame.Value = MatchTimingData.endgameLength;
            timingTeamTimeout.Value = MatchTimingData.timeoutTeamLength;
            timingEventTimeout.Value = MatchTimingData.timeoutEventLength;
            timingDriver.Value = driverPeriod;

            chkCountdown.Checked = Properties.Settings.Default.useCountdown;
            timingCountdown.Enabled = Properties.Settings.Default.useCountdown;
            timingCountdown.Value = MatchTimingData.countdownStart;

            numQuarterfinalCount.Value = MatchTimingData.quarterfinalAlliances;
            numSemifinalCount.Value = MatchTimingData.semifinalAlliances;
            btnSave.Enabled = false;
            btnRevert.Enabled = false;
        }

        public bool hasChanges
        {
            get
            {
                return btnSave.Enabled;
            }
        }

        private void HandleButtons(object sender, EventArgs e)
        {
            if (sender.Equals(btnSave))
            {
                MatchTimingData.matchLength = timingMatch.Value;
                MatchTimingData.autoLength = timingAuto.Value;
                MatchTimingData.nocrossLength = timingNocross.Value;
                MatchTimingData.endgameLength = timingEndgame.Value;
                MatchTimingData.timeoutTeamLength = timingTeamTimeout.Value;
                MatchTimingData.timeoutEventLength = timingEventTimeout.Value;

                MatchTimingData.countdownStart = timingCountdown.Value;

                MatchTimingData.quarterfinalAlliances = (int)numQuarterfinalCount.Value;
                MatchTimingData.semifinalAlliances = (int)numSemifinalCount.Value;

                // save the countdown preference
                Properties.Settings.Default.useCountdown = chkCountdown.Checked;
                Properties.Settings.Default.Save();

                btnSave.Enabled = false;
                btnRevert.Enabled = false;
            }
            else if (sender.Equals(btnRevert))
            {
                string msg = "Are you sure you want to revert your changes?";
                DialogResult dr = MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.No) return;
                LoadValues();
            }
            else if (sender.Equals(btnDefaults))
            {
                string msg = "Are you sure you want to restore all default timing?";
                DialogResult dr = MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.No) return;
                MatchTimingData.SetDefaults();
                LoadValues();
            }
        }

        private void CustomValidation(object sender, ValidateValueEventArgs e)
        {
            CustomValidator validator = (CustomValidator)sender;
            e.IsValid = false;
            if (e.ControlToValidate.Equals(timingAuto))
            {
                if (timingAuto.Value < timingMatch.Value) e.IsValid = true;
            }
            else if (e.ControlToValidate.Equals(timingNocross))
            {
                if (timingNocross.Value < timingAuto.Value) e.IsValid = true;
            }
            else if (e.ControlToValidate.Equals(timingEndgame))
            {
                if (timingEndgame.Value < driverPeriod) e.IsValid = true;
            }
        }

        public TimeSpan driverPeriod
        {
            get
            {
                TimeSpan t = timingMatch.Value - timingAuto.Value;
                if (t.TotalSeconds < 0) return new TimeSpan(0, 0, 0);
                return t;
            }
        }

        private void TimingValueChanged(object sender, TimeSpan e)
        {
            timingDriver.Value = driverPeriod;
            btnSave.Enabled = true;
            btnRevert.Enabled = true;
        }

        private void chkCountdownChanged(object sender, EventArgs e)
        {
            timingCountdown.Enabled = chkCountdown.Checked;
            btnSave.Enabled = true;
            btnRevert.Enabled = true;
        }

        private void numPickerChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnRevert.Enabled = true;
        }
    }
}
