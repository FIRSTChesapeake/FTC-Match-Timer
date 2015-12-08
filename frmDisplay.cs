using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lblMatchStatus.Text = "WAITING FOR FIRST DATA";
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
        public void SetDisplay(MatchData data)
        {
            // Timer Display
            int m = data.timerValue.Minutes;
            int s = data.timerValue.Seconds;
            int s1 = 0;
            int s2 = s;
            if (s > 9)
            {
                try
                {
                    string str = s.ToString();
                    s1 = int.Parse(str.Substring(0, 1));
                    s2 = int.Parse(str.Substring(1, 1));
                }
                catch { }
            }
            SetDigit(ref imgMinute, m);
            SetDigit(ref imgSecond1, s1);
            SetDigit(ref imgSecond2, s2);
            SetColon();
            // Match Number
            lblMatchNumber.Text = data.matchHeaderString;
            // Match Progress
            lblMatchStatus.Text = data.matchFooterString;
        }

        private void SetColon()
        {
            if (imgColon.Image == Properties.Resources.Rcolonoff) SetColon(true);
            else SetColon(false);
        }
        private void SetColon(bool value)
        {
            if (value) imgColon.Image = Properties.Resources.Rcolon;
            else imgColon.Image = Properties.Resources.Rcolonoff;
        }

        private void SetDigit(ref PictureBox digit, int value)
        {
            Image i;
            switch (value)
            {
                case 0: i = Properties.Resources.R0; break;
                case 1: i = Properties.Resources.R1; break;
                case 2: i = Properties.Resources.R2; break;
                case 3: i = Properties.Resources.R3; break;
                case 4: i = Properties.Resources.R4; break;
                case 5: i = Properties.Resources.R5; break;
                case 6: i = Properties.Resources.R6; break;
                case 7: i = Properties.Resources.R7; break;
                case 8: i = Properties.Resources.R8; break;
                case 9: i = Properties.Resources.R9; break;
                default: i = Properties.Resources.Rdigitoff; break;
            }
            digit.Image = i;
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
