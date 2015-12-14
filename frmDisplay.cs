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
            clockFace.Value = data.timerValue;
            // Timer Display Colon
            clockFace.blink = data.timerRunning;
            // Match Number
            lblMatchNumber.Text = data.matchHeaderString;
            // Am I the selected client?
            picState.Image = data.isSelectedClient ? Properties.Resources.indicator_green : Properties.Resources.indicator_yellow;
            // Match Progress
            matchPeriodCtrl.SetDisplay(data);
            // Set the date and time labels
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        public void deadField()
        {
            picState.Image = Properties.Resources.indicator_red;
        }

        private void frmDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
