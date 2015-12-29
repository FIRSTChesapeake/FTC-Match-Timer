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
            Image img = loadImgFromFile(logoPath);
            if (img != null)
            {
                logoTableLeft.BackgroundImage = img;
                logoTableRight.BackgroundImage = img;
            }
            else
            {
                logoTableLeft.BackgroundImage = Properties.Resources.vaflogo;
                logoTableRight.BackgroundImage = Properties.Resources.vaflogo;
            }
            lblDate.Visible = Properties.Settings.Default.displayShowDateTime;
            lblTime.Visible = Properties.Settings.Default.displayShowDateTime;
        }

        private void frmDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            
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
            // Timer Display
            clockFace.Value = data.timerValue;
            // Timer Display Colon
            clockFace.blink = data.timerRunning;
            // Match Number
            lblMatchNumber.Text = data.matchHeaderString;
            // Am I the selected client?
            setFieldStatusDisplay(data.isSelectedClient);
            // Match Progress
            matchPeriodCtrl.SetDisplay(data);
            // Set the date and time labels
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void setFieldStatusDisplay(bool isSelected)
        {
            lblFieldDataStatus.BackColor = isSelected ? Color.Green : Color.Yellow;
            lblFieldDataStatus.Text = isSelected ? "FIELD IS ACTIVE" : "FIELD ON STANDBY";
        }

        public void deadField()
        {
            lblFieldDataStatus.Text = "ERROR: FIELD NOT RECEIVING DATA!";
            lblFieldDataStatus.BackColor = Color.Red;
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

        public static Image loadImgFromFile(string path)
        {
            try
            {
                Image img = Image.FromFile(path);
                return img;
            }
            catch
            {
                return null;
            }
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
    }
}
