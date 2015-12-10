using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public partial class frmDisplay : Form
    {
        private InitialData initData;
        private MatchData matchData = new MatchData();

        public frmDisplay(InitialData data)
        {
            InitializeComponent();
            initData = data;
            lblMatchNumber.Text = String.Format("DIVISION {0} FIELD {1} INITIALIZED", data.divID, data.fieldID);
            //lblMatchStatus.Text = "WAITING FOR FIRST DATA";
        }

        private void frmDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F11)
            {
                ChangeFullscreen();
            }
        }

        public void ChangeFullscreen()
        {
            ChangeFullscreen(!this.ControlBox);
        }

        public void ChangeFullscreen(bool val)
        {
            if (val)
            {
                this.WindowState = FormWindowState.Maximized;
                this.ControlBox = false;
            }
            else
            {
                this.ControlBox = true;
                this.WindowState = FormWindowState.Normal;
            }
        }

        public void SetDisplay(MatchData data, ClockFace.DigitSets digitSet)
        {
            // select the right clockface
            clockFace.digitSet = digitSet;
            // Timer Display
            clockFace.Value = data.timerValue;
            // Timer Display Colon
            clockFace.blink = data.matchStatus == MatchData.MatchStatus.Running;
            // Match Number
            lblMatchNumber.Text = data.matchHeaderString;
            // Match Progress
            //lblMatchStatus.Text = data.matchFooterString;
            // New Match Progress
            matchPeriodCtrl.SetDisplay(data);
        }

        private void frmDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }
    }
}
