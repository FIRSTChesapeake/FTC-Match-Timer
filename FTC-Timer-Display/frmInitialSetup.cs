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
using FTC_Timer_Display.InitializationControls;

namespace FTC_Timer_Display
{
    public partial class frmInitialSetup : Office2007Form
    {
        private SetupSteps _currentStep = SetupSteps.Welcome;
        private InitialData _origData { get; set; }
        private InitialData _workData;
        private InitialData.RunType _lastRunType = InitialData.RunType.None;
        private bool _firstRun = true;

        public frmInitialSetup(InitialData template)
        {
            InitializeComponent();
            // Save our template
            _origData = template;
            _workData = template;
            _lastRunType = template.runType;
            // Remember if the data we started with was fresh or remembered.
            _firstRun = _workData.runType == InitialData.RunType.None;
            // set the title text
            this.Text = GeneralFunctions.AppFunctions.makeWindowTitle(this.Text);
            // Load the welcome HTML
            // Get the welcome message
            lblWelcome.Text = GeneralFunctions.FileFunctions.readDocsFile("welcome.html", GeneralFunctions.FileFunctions.genericFileOopsHTML);
            // Skip the welcome screen if desired
            chkSkipWelcome.Checked = Properties.Settings.Default.skipWelcome;
            if (chkSkipWelcome.Checked) MoveOneStep(true);
        }

        private void frmInitialSetup_Load(object sender, EventArgs e)
        {

        }

        private void navButtonsHandler(object sender, EventArgs e)
        {
            if (sender.Equals(btnPrev))
            {
                MoveOneStep(false);
            }
            else if (sender.Equals(btnNext))
            {
                MoveOneStep(true);
            }
            else if (sender.Equals(btnStartOver))
            {
                string msg = "Are you sure you want to clear your changes and start over?";
                DialogResult dr = MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.No) return;
                this._workData = this._origData;
                MoveToStep(SetupSteps.Welcome);
            }
            else if (sender.Equals(btnFinish))
            {
                this.Tag = _workData;
                this.Visible = false;
            }
            else if (sender.Equals(btnQuit))
            {
                string msg = "Are you sure you want to exit?";
                DialogResult dr = MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.No) return;
                Application.Exit();
            }
        }

        private enum SetupSteps
        {
            NotSet = -1,
            Welcome = 0,
            PreReview = 1,
            AppMode = 2,
            Globals = 3,
            Server = 4,
            Client = 5,
            Review = 6
        }

        private void MoveOneStep(bool forward)
        {
            executeStepActions(_currentStep, false);
            SetupSteps step = fetchStepMovement(_currentStep, forward);
            MoveToStep(step);
            executeStepActions(_currentStep, true);
        }

        private void MoveToStep(SetupSteps step)
        {
            log("Moving to step {0}", step);
            if (step != SetupSteps.NotSet)
            {
                int tabID = (int)step;
                tabsMain.SelectedTabIndex = tabID;
                // Setup button availability
                btnStartOver.Enabled = allowsStartOver(step);
                btnFinish.Enabled = allowsFinish(step);
                btnPrev.Enabled = fetchStepMovement(step, false) == SetupSteps.NotSet ? false : true;
                btnNext.Enabled = fetchStepMovement(step, true) == SetupSteps.NotSet ? false : true;
                // Save as current step
                _currentStep = step;
            }
        }

        private void executeStepActions(SetupSteps step, bool before)
        {
            try
            {
                switch (step)
                {
                    case SetupSteps.PreReview:
                        if (before) settingsViewPre.fill(this._workData);
                        break;
                    case SetupSteps.AppMode:
                        if (before) appModeSelection.SetData(this._workData);
                        else appModeSelection.GetData(ref this._workData);
                        break;
                    case SetupSteps.Globals:
                        if (before) globalOpts.SetData(this._workData);
                        else globalOpts.GetData(ref this._workData);
                        break;
                    case SetupSteps.Server:
                        if (before) serverOpts.SetData(this._workData);
                        else serverOpts.GetData(ref this._workData);
                        break;
                    case SetupSteps.Client:
                        if (before) clientOpts.SetData(this._workData);
                        else clientOpts.GetData(ref this._workData);
                        break;
                    case SetupSteps.Review:
                        if (before) settingsViewPost.fill(this._workData);
                        break;

                }
            }
            catch (Exception ex)
            {
                string msg = "Exception executing Step '{0}' {1} change actions.";
                log(msg, ex, step, before ? "pre" : "post");
            }
        }

        private SetupSteps fetchStepMovement(SetupSteps step, bool forward)
        {
            SetupSteps next = SetupSteps.NotSet;
            SetupSteps prev = SetupSteps.NotSet;
            // Figure out what's next/prev and what is allowed.
            switch (step)
            {
                case SetupSteps.Welcome:
                    if (_firstRun) next = SetupSteps.AppMode;
                    else next = SetupSteps.PreReview;
                    break;
                case SetupSteps.PreReview:
                    prev = SetupSteps.Welcome;
                    next = SetupSteps.AppMode;
                    break;
                case SetupSteps.AppMode:
                    if (_firstRun) prev = SetupSteps.Welcome;
                    else prev = SetupSteps.PreReview;
                    next = SetupSteps.Globals;
                    break;
                case SetupSteps.Globals:
                    prev = SetupSteps.AppMode;
                    if (_workData.isServer) next = SetupSteps.Server;
                    else if (_workData.isClient) next = SetupSteps.Client;
                    else next = SetupSteps.Review;
                    break;
                case SetupSteps.Server:
                    prev = SetupSteps.Globals;
                    if (_workData.isClient) next = SetupSteps.Client;
                    else next = SetupSteps.Review;
                    break;
                case SetupSteps.Client:
                    if (_workData.isServer) prev = SetupSteps.Server;
                    else prev = SetupSteps.Globals;
                    next = SetupSteps.Review;
                    break;
                case SetupSteps.Review:
                    if (_workData.isClient) prev = SetupSteps.Client;
                    else if (_workData.isServer) prev = SetupSteps.Server;
                    else prev = SetupSteps.Globals;
                    break;
            }
            return forward ? next : prev;
        }

        private bool allowsStartOver(SetupSteps step)
        {
            return false; // This isn't working! _orig is going byref to working.
            switch (step)
            {
                case SetupSteps.PreReview:
                    return true;
                default:
                    return true;
            }
        }
        private bool allowsFinish(SetupSteps step)
        {
            switch (step)
            {
                case SetupSteps.PreReview:
                    return true;
                case SetupSteps.Review:
                    return true;
                default:
                    return false;
            }
        }
        private void log(string message, params object[] args)
        {
            if (!Properties.logging.Default.logInitialSetupSteps) return;
            string msg = LogMgr.make(message, "InitSetup", 0, args);
            LogMgr.logger.Debug(msg);
        }
        private void log(string message, Exception ex, params object[] args)
        {
            string msg = LogMgr.make(message, "InitSetup", 0, args);
            LogMgr.logger.Error(msg, ex);
        }

        private void chkSkipWelcome_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.skipWelcome = chkSkipWelcome.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnClearAllSettings_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure you want to clear all settings?";
            DialogResult dr = MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            _origData = new InitialData();
            _workData = new InitialData();
            chkSkipWelcome.Checked = false;
            _lastRunType = InitialData.RunType.ServerClient;
            _firstRun = true;
        }
    }
}
