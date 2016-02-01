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
            this.initializeDisplay();
        }

        public void initializeDisplay()
        {
            lblMatchNumber.Text = String.Format("DIVISION {0} FIELD {1} INITIALIZED", initData.divID, initData.fieldID);
            loadCustomLogo();
        }

        private void loadCustomLogo()
        {
            // load custom logo if defined.
            string logoPath = Properties.Settings.Default.customLogoPath;
            Image img = GeneralFunctions.FileFunctions.LoadImgFromFile(logoPath);
            if (img != null)
            {
                logoTableLeft.BackgroundImage = img;
                logoTableRight.BackgroundImage = img;
            }
            else
            {
                logoTableLeft.BackgroundImage = Properties.Resources.vaflogo_new;
                logoTableRight.BackgroundImage = Properties.Resources.vaflogo_new;
            }
            lblDate.Visible = Properties.Settings.Default.displayShowDateTime;
            lblTime.Visible = Properties.Settings.Default.displayShowDateTime;
        }

        private void frmDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user pressed F11 or Escape while in Fullscreen, go back to windowed.
            if ((e.KeyData == Keys.F11 || e.KeyData == Keys.Escape) && displayStatus == DisplayStatus.Fullscreen)
            {
                displayStatus = DisplayStatus.Windowed;
            }
            // If the user pressed F11 while we're in windowed, go Fullscreen
            else if (e.KeyData == Keys.F11 && displayStatus == DisplayStatus.Windowed)
            {
                displayStatus = DisplayStatus.Fullscreen;
            }
        }

        public DisplayStatus displayStatus
        {
            set
            {
                switch (value)
                {
                    case DisplayStatus.Hide:
                        ChangeFullscreen(false);
                        this.Visible = false;
                        break;
                    case DisplayStatus.Windowed:
                        this.Visible = true;
                        ChangeFullscreen(false);
                        break;
                    case DisplayStatus.Fullscreen:
                        this.Visible = true;
                        ChangeFullscreen(true);
                        break;
                }
            }
            get
            {
                if (!this.Visible) return DisplayStatus.Hide;
                else if (this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None) return DisplayStatus.Fullscreen;
                else return DisplayStatus.Windowed;
            }
        }

        public enum DisplayStatus
        {
            Hide,
            Windowed,
            Fullscreen
        }

        private void ChangeFullscreen(bool val)
        {
            if (val)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        public void SetDisplay(MatchData data)
        {
            // Timer Color
            clockFace.faceColor = data.matchStatus == MatchData.MatchStatus.Timeout ? ClockFace.FaceColor.Green : ClockFace.FaceColor.Red;
            // Timer Display
            clockFace.Value = data.timerValue;
            // Timer Display Colon
            clockFace.blink = data.isTimerRunning;
            // Match Number
            lblMatchNumber.Text = data.matchHeaderString;
            // Am I the selected client on the server?
            setFieldStatusDisplay(data.isSelectedByServer, data.useLargeActive);
            // Match Progress
            matchPeriodCtrl.SetDisplay(data);
            // Set the date and time labels
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void setFieldStatusDisplay(bool isSelected, bool isLarge)
        {
            lblFieldDataStatus.BackColor = isSelected ? Color.Green : Color.Yellow;
            lblFieldDataStatus.Text = isSelected ? "FIELD IS ACTIVE" : "FIELD ON STANDBY";
            picInd.Image = isSelected ? Properties.Resources.indicator_green : Properties.Resources.indicator_yellow;
            // Display the indicator the user wants to show.
            lblFieldDataStatus.Visible = isLarge;
            picInd.Visible = !isLarge;
        }

        public void deadField()
        {
            lblFieldDataStatus.Text = "ERROR: FIELD NOT RECEIVING DATA!";
            lblFieldDataStatus.BackColor = Color.Red;
            picInd.Image = Properties.Resources.indicator_red;
        }

        private void frmDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                ChangeFullscreen(false);
                this.Visible = false;
            }
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the VisibleChanged event of the frmDisplay control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void frmDisplay_VisibleChanged(object sender, EventArgs e)
        {
            loadCustomLogo();
        }

        private void lblFieldDataStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
