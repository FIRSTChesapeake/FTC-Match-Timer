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

namespace FTC_Timer_Display
{
    public partial class frmTimings : Office2007Form
    {
        public frmTimings()
        {
            InitializeComponent();
            LoadValues();
        }

        private void LoadValues()
        {
            timingMatch.Value = MatchTimingData.matchLength;
            timingAuto.Value = MatchTimingData.autoLength;
            timingNocross.Value = MatchTimingData.nocrossLength;
            timingEndgame.Value = MatchTimingData.endgameLength;
            timingDriver.Value = driverPeriod;
        }

        private void HandleButtons(object sender, EventArgs e)
        {
            if (sender.Equals(btnSave))
            {
                MatchTimingData.matchLength = timingMatch.Value;
                MatchTimingData.autoLength = timingAuto.Value;
                MatchTimingData.nocrossLength = timingNocross.Value;
                MatchTimingData.endgameLength = timingEndgame.Value;

                this.Tag = true;
                this.Visible = false;
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
        }
    }
}
