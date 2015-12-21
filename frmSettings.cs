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
    public partial class frmSettings : DevComponents.DotNetBar.OfficeForm
    {
        private InitialData _initData;
        private frmDisplay _dispForm;

        public frmSettings(ref InitialData initData, ref frmDisplay dispForm)
        {
            InitializeComponent();
            _initData = initData;
            _dispForm = dispForm;

            // Select default sound setting based on init.
            bool localSound = initData.isServer || initData.runType == InitialData.RunType.Local;
            rdoSoundLocal.Checked = localSound;
            rdoSoundRemote.Checked = !localSound;

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            // Only servers broadcast their pit displays
            if (!_initData.isServer)
            {
                rdoPitOff.Checked = true;
                grpPit.Enabled = false;
            }
            // Enable / Disable sound settings
            grpSoundOptions.Enabled = _initData.isServer || _initData.runType == InitialData.RunType.Local;
            rdoSoundRemote.Enabled = _initData.isServer;
            // Load custom image if it exists and we have a display.
            if (_dispForm != null)
            {
                string customPath = Properties.Settings.Default.customLogoPath;
                Image img = frmDisplay.loadImgFromFile(customPath);
                if (img != null)
                {
                    picCurrentLogo.Image = img;
                }
            }
            else
            {
                grpBranding.Enabled = false;
            }
        }

        public PitData.PitDataSelections pitDataSelection
        {
            get
            {
                if (rdoPitActive.Checked) return PitData.PitDataSelections.ActiveOnly;
                if (rdoPitAll.Checked) return PitData.PitDataSelections.AllFields;
                return PitData.PitDataSelections.Off;
            }
        }
        public MatchData.SoundLocations soundLocation
        {
            get
            {
                if (this._initData.isServer)
                {
                    if (rdoSoundLocal.Checked) return MatchData.SoundLocations.Server;
                    if (rdoSoundRemote.Checked) return MatchData.SoundLocations.Client;
                }
                else
                {
                    if (rdoSoundLocal.Checked) return MatchData.SoundLocations.Client;
                    if (rdoSoundRemote.Checked) return MatchData.SoundLocations.Server;
                }
                return MatchData.SoundLocations.Off;
            }
            set
            {
                if (value == MatchData.SoundLocations.Off) rdoSoundOff.Checked = true;
                else if (this._initData.isServer)
                {
                    if (value == MatchData.SoundLocations.Client) rdoSoundRemote.Checked = true;
                    else if (value == MatchData.SoundLocations.Server) rdoSoundLocal.Checked = true;
                }
                else
                {
                    if (value == MatchData.SoundLocations.Server) rdoSoundRemote.Checked = true;
                    else if (value == MatchData.SoundLocations.Client) rdoSoundLocal.Checked = true;
                }
            }
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void LogoChangeHandler(object sender, EventArgs e)
        {
            try
            {
                if (sender.Equals(btnChangeLogo))
                {
                    OpenFileDialog dial = new OpenFileDialog();
                    dial.Filter = "PNG Files (*.png)|*.png";
                    dial.Title = "Please select your logo location.";
                    dial.ShowDialog();
                    if (dial.FileName == null || dial.FileName == "") return;
                    Image img = frmDisplay.loadImgFromFile(dial.FileName);
                    if (img == null) return;
                    picCurrentLogo.Image = img;
                    Properties.Settings.Default.customLogoPath = dial.FileName;
                }
                else if (sender.Equals(btnResetLogo))
                {
                    picCurrentLogo.Image = Properties.Resources.vaflogo;
                    Properties.Settings.Default.customLogoPath = "";
                }
                Properties.Settings.Default.Save();
                _dispForm.initializeDisplay();
            }
            catch
            {
                
            }
        }

        private void chkDateTime_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.displayShowDateTime = chkDateTime.Checked;
            Properties.Settings.Default.Save();
            _dispForm.initializeDisplay();
        }

        private void chkAutoElimTimeout_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoElimTimeouts = chkAutoElimTimeout.Checked;
            Properties.Settings.Default.Save();
        }

        private void frmSettings_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}