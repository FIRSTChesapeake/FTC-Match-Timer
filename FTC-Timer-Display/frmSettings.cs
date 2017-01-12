using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FTC_Timer_Display.SettingsControls;
//using System.Diagnostics;

namespace FTC_Timer_Display
{
    public partial class frmSettings : DevComponents.DotNetBar.OfficeForm
    {
        private InitialData _initData;
        private frmDisplay _dispForm;

        public frmSettings(ref InitialData initData, ref frmDisplay dispForm)
        {
            InitializeComponent();
            // Set the titlebar
            this.Text = GeneralFunctions.AppFunctions.makeWindowTitle(this.Text);

            _initData = initData;
            _dispForm = dispForm;

            // Select default sound setting based on init.
            bool localSettings = initData.isServer || initData.runType == InitialData.RunType.Local;
            rdoSoundLocal.Checked = localSettings;
            rdoSoundRemote.Checked = !localSettings;
            // Only allow timing if we're a server or local.
            timingsControl.Enabled = localSettings;
            // Only allow server settings when we're a server
            headerServerOptions.Enabled = localSettings;
            flowServerOptions.Enabled = localSettings;
            

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadSettings()
        {
            log("Loading Settings");
            // Only servers broadcast their pit displays
            if (!_initData.isServer)
            {
                rdoPitOff.Checked = true;
                flowPit.Enabled = false;
            }
            // Enable / Disable sound settings
            flowSoundLocation.Enabled = _initData.isServer || _initData.runType == InitialData.RunType.Local;
            rdoSoundRemote.Enabled = _initData.isServer;
            // Load custom image if it exists and we have a display.
            if (_dispForm != null)
            {
                Image img1 = GeneralFunctions.FileFunctions.LoadImgFromFile(Properties.Settings.Default.customLogoPath1);
                if (img1 != null) picCurrentLogo1.Image = img1;

                Image img2 = GeneralFunctions.FileFunctions.LoadImgFromFile(Properties.Settings.Default.customLogoPath2);
                if (img2 != null) picCurrentLogo1.Image = img2;
            }
            else
            {
                tableBranding.Enabled = false;
            }
            // misc options
            chkDateTime.Checked = Properties.Settings.Default.displayShowDateTime;
            chkShowHelp.Checked = Properties.Settings.Default.showHelp;
            
            chkPreventMovement.Checked = Properties.Settings.Default.preventRunningMovement;
            chkUseLargeActive.Checked = Properties.Settings.Default.useLargeActive;
            chkShowFieldNumber.Checked = Properties.Settings.Default.showDisplayFieldNumbers;
            // Timing
            timingsControl.LoadValues();
            // Sound Testing
            soundControl.LoadSounds();
            log("Settings loaded.");
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
                if (rdoSoundBoth.Checked)
                {
                    return MatchData.SoundLocations.Both;
                }
                else if (this._initData.isServer)
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
                else if (value == MatchData.SoundLocations.Both) rdoSoundBoth.Checked = true;
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
            // if the user is performing the action, we'll never destroy this window
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                CloseHandler();
            }

        }

        private void CloseHandler()
        {
            // if there are unsaved settings, warn the user.
            string unsavedLocations = "";
            if (timingsControl.hasChanges) unsavedLocations += " Match Timings\n";
            if (loggingControl.hasChanges) unsavedLocations += " Logging Settings\n";
            if (unsavedLocations != "")
            {
                string msg = string.Format("You have unsaved changes on these tab(s):\n'{0}'Close without saving?", unsavedLocations);
                DialogResult dr = MessageBox.Show(msg, "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.No) return;
            }
            // if we make it here, make window !visible.
            this.Visible = false;
        }

        private void LogoChangeHandler(object sender, EventArgs e)
        {
            try
            {
                if (sender.Equals(btnResetLogo))
                {
                    picCurrentLogo1.Image = Properties.Resources.FCLogoBlack;
                    picCurrentLogo2.Image = Properties.Resources.FCLogoBlack;
                    Properties.Settings.Default.customLogoPath1 = "";
                    Properties.Settings.Default.customLogoPath2 = "";
                }
                else
                {
                    OpenFileDialog dial = new OpenFileDialog();
                    dial.Filter = "PNG Files (*.png)|*.png";
                    dial.Title = "Please select your logo location.";
                    dial.ShowDialog();
                    if (dial.FileName == null || dial.FileName == "") return;
                    Image img = GeneralFunctions.FileFunctions.LoadImgFromFile(dial.FileName);
                    if (img == null) return;

                    if (sender.Equals(btnChangeLogo1))
                    {
                        picCurrentLogo1.Image = img;
                        Properties.Settings.Default.customLogoPath1 = dial.FileName;
                    }
                    if (sender.Equals(btnChangeLogo2))
                    {
                        picCurrentLogo2.Image = img;
                        Properties.Settings.Default.customLogoPath2 = dial.FileName;
                    }
                }

                Properties.Settings.Default.Save();
                reInitDisplay();
            }
            catch
            {
                
            }
        }

        private void reInitDisplay()
        {
            if (_dispForm != null) _dispForm.initializeDisplay();
        }

        private void chkDateTime_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.displayShowDateTime = chkDateTime.Checked;
            Properties.Settings.Default.Save();
            reInitDisplay();
        }

        private void frmSettings_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true) this.LoadSettings();
        }

        private void chkShowHelp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.showHelp = chkShowHelp.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkPreventMovement_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.preventRunningMovement = chkPreventMovement.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseHandler();
        }

        /// <summary>
        /// Logs the specified message as info.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        private void log(string message, params object[] args)
        {
            LogMgr.logger.Info(LogMgr.make(message, "frmSettings", 0, args));
        }

        private void chkUseLargeActive_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.useLargeActive = chkUseLargeActive.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkDontShowFieldNumber_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.showDisplayFieldNumbers = chkShowFieldNumber.Checked;
            Properties.Settings.Default.Save();
        }
    }
}