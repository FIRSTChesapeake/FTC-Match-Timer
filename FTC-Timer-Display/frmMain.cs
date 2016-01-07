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
using System.Diagnostics;

namespace FTC_Timer_Display
{
    public partial class frmMain : Office2007Form
    {
        InitialData initData;
        myUdpClient.UdpComms comms;

        frmDisplay display;
        frmSettings settings;

        private DateTime _lastReceiveTime = DateTime.Now.AddMonths(-1);

        private bool _isReceiving
        {
            get
            {
                TimeSpan t = new TimeSpan(0, 0, Properties.Settings.Default.DeadFieldDelay);
                if (DateTime.Now > _lastReceiveTime.Add(t)) return false;
                return true;
            }
        }

        private List<SingleClient> _allClients = new List<SingleClient>();
        BindingList<ButtonX> fieldButtonList = new BindingList<ButtonX>();

        private SingleClient _selectedClient
        {
            get
            {
                if (_allClients.Count == 0) return null;
                foreach (SingleClient c in _allClients) if (c.isSelected) return c;
                return null;
            }
        }

        private SingleClient _thisClient
        {
            get
            {
                if (this.display == null) return null;
                foreach (SingleClient c in _allClients) if (initData.fieldID == c.matchData.fieldID) return c;
                return null;
            }
        }

        private void SaveSettings()
        {
            if (initData == null) return;
            // Only saved if we're in server mode.
            if (initData.isServer)
            {
                // Save the fields we have added.
                if (_allClients.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    bool first = true;

                    LogMgr.logger.Debug(LogMgr.make("Saving Fields", "frmMain.SaveSettings"));
                    foreach (SingleClient c in _allClients)
                    {
                        LogMgr.logger.Debug(LogMgr.make("Saving Field {0}", "frmMain.SaveSettings", 1, c.matchData.fieldID));
                        if (!first) sb.Append(",");
                        first = false;
                        sb.Append(c.matchData.fieldID.ToString());
                    }
                    Properties.Settings.Default.FieldList = sb.ToString();
                    LogMgr.logger.Debug(LogMgr.make("Fields Saved", "frmMain.SaveSettings"));
                }
            }
            else
            {
                Properties.Settings.Default.FieldList = "";
            }
            // Save these settings
            Properties.Settings.Default.Save();
            // Tell initData to save it's settings
            initData.SaveSettings();
        }
        private void LoadSettings()
        {
            // Display config that relates to all the settings.
            lblMode.Text = initData.runTypeString;
            if (!initData.isMultiDivision) lblDivIDLabel.Text = "Event:";
            setDivisionDisplay(initData.divID, initData.divName);
            // Load the last used fields
            if (initData.isServer && initData.loadPreviousFields)
            {
                string csv = Properties.Settings.Default.FieldList;
                string[] list = csv.Split(',');
                if (list.Length > 0)
                {
                    LogMgr.logger.Info(LogMgr.make("Loading Fields", "frmMain.LoadSettings"));
                    foreach (string s in list)
                    {
                        try
                        {
                            if (s == "") continue;
                            LogMgr.logger.Debug(LogMgr.make("Loading Field {0}", "frmMain.LoadSettings", 1, s));
                            int i = int.Parse(s);
                            this.AddField(i);
                        }
                        catch (Exception ex)
                        {
                            LogMgr.logger.Error(LogMgr.make("Exception loading fields", "frmMain.LoadSettings"), ex);
                        }
                    }
                    LogMgr.logger.Info(LogMgr.make("{0} Field(s) loaded.", "frmMain.LoadSettings", 0, list.Length));
                }
            }
        }

        public frmMain(InitialData init)
        {
            InitializeComponent();
            LogMgr.logger.Info(LogMgr.make("Initializing Main Form", "frmMain.Constr"));
            // Show the loading window
            frmLoading.StartLoadScreen("Initializing Systems..");
            // Set the titlebar
            this.Text = GeneralFunctions.AppFunctions.makeWindowTitle(this.Text);
            // show version
            lblVer.Text = GeneralFunctions.AppFunctions.appVersion;
            // Set the init Data
            this.initData = init;
            // Init the MatchType dropdown, default to qualification
            cboMatchType.DataSource = Enum.GetValues(typeof(MatchData.MatchTypes));
            cboMatchType.SelectedIndex = 2;
            // Init the sound generator
            frmLoading.UpdateDisplay("Loading pre-generated sounds..");
            SoundGenerator.init(soundLoadChange);
            // Init the list of field buttons for mass changes.
            fieldButtonList.Add(btnStart);
            fieldButtonList.Add(btnStop);
            fieldButtonList.Add(btnPause);
            fieldButtonList.Add(btnReset);
            fieldButtonList.Add(btnAdvance);
            fieldButtonList.Add(btnTimeoutStart);
            fieldButtonList.Add(btnTimeoutCancel);
            // Initialize the PacDriver if we're a server
            if (initData.isServer) PacDevices.UsbButtonDevices.init(this, pacButtonHandler);
        }

        private void pacButtonHandler(object sender, PacDevices.UsbButtonDevices.ButtonStates buttonState)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => pacButtonHandler(sender, buttonState)));
            }
            else
            {
                lblPacButtonState.Text = string.Format("<div align='center'>{0}</div>", buttonState.ToString());
                switch (buttonState)
                {
                    case PacDevices.UsbButtonDevices.ButtonStates.NotFound:
                        lblPacButtonState.BackColor = Color.Red;
                        break;
                    case PacDevices.UsbButtonDevices.ButtonStates.InitialPress:
                    case PacDevices.UsbButtonDevices.ButtonStates.PressedWaiting:
                        lblPacButtonState.BackColor = Color.Yellow;
                        break;
                    case PacDevices.UsbButtonDevices.ButtonStates.InitialRelease:
                    case PacDevices.UsbButtonDevices.ButtonStates.Released:
                        lblPacButtonState.BackColor = Color.Green;
                        break;
                }
                if (nextExpectedButton == null || !nextExpectedButton.Enabled) return;
                if (buttonState == PacDevices.UsbButtonDevices.ButtonStates.InitialRelease)
                {
                    FieldControlButtonsHandler(nextExpectedButton, new EventArgs());
                }
            }
        }

        private void soundLoadChange(object sender, int newPercent)
        {
            if (!frmLoading.isShowing) return;
            frmLoading.UpdateDisplay("Loading Sounds...", newPercent);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLoading.UpdateDisplay("Loading Settings..");
            // Load all settings
            this.LoadSettings();

            // Init the local timer if needed.
            if (initData.runType == InitialData.RunType.Server)
            {
                tableDisplayControl.Enabled = false;
            }
            else
            {
                
                display = new frmDisplay(initData);
                AddField(initData.fieldID);
            }
            // Init the settings window. - do this after we decide whether we need a display
            settings = new frmSettings(ref this.initData, ref display);
            // Setup Comms if needed
            if (initData.runType != InitialData.RunType.Local)
            {
                comms = new myUdpClient.UdpComms(initData.divID, initData.fieldID, NewDataReceived);
                if (initData.runType == InitialData.RunType.Client)
                {
                    btnCycleListener.Enabled = true;
                    comms.ListenControl(true);
                }
            }
            frmLoading.CloseForm();
        }

        private void ClientDisplayRequestHandler(object sender, SingleClient.SingleClientRequest e)
        {
            // Ignore the selection unless specific conditions are met.
            SingleClient c = (SingleClient)sender;
            bool canSelectField = _selectedClient == null || !_selectedClient.matchData.isMatchActive || !Properties.Settings.Default.preventRunningMovement;
            switch (e)
            {
                case SingleClient.SingleClientRequest.SelectMe:
                    if (!canSelectField || !initData.isServer) return;
                    selectFieldNumber(c.matchData.fieldID);
                    break;
                case SingleClient.SingleClientRequest.TimeoutStart:
                    frmStartTimeout wind = new frmStartTimeout(c.matchData.matchType, ref _allClients, c);
                    wind.ShowDialog();
                    break;
            }
        }

        private void AddField(int fieldID)
        {
            if (fieldExists(fieldID)) return;
            flowFields.Controls.Clear();
            int width = flowFields.Width - 10;
            SingleClient client = new SingleClient(initData, fieldID, width, sendFieldDataHandler, ClientDisplayRequestHandler);
            client.matchData.matchType = _currentMatchType;
            _allClients.Add(client);
            _allClients.Sort();
            foreach (SingleClient c in _allClients) flowFields.Controls.Add(c.fieldDisplayObj);
            selectFieldNumber(0);
        }

        private void RemoveField(SingleClient client)
        {
            if (!_allClients.Contains(client)) return;
            flowFields.Controls.Clear();
            _allClients.Remove(client);
            _allClients.Sort();
            foreach (SingleClient c in _allClients) flowFields.Controls.Add(c.fieldDisplayObj);
            selectFieldNumber(0);
        }

        private bool fieldExists(int fieldID)
        {
            foreach (SingleClient c in _allClients)
            {
                if (c.matchData.fieldID == fieldID) return true;
            }
            return false;
        }

        private void sendFieldDataHandler(object sender, MatchData data)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    object o = this.Invoke(new Action(() => sendFieldDataHandler(sender, data)));
                }
                else
                {
                    // Check for sound data and decide if we need to play it here.
                    ProcessSoundRequests(data);
                    // Add the match length to the package
                    data.matchLength = (int)MatchTimingData.matchLength.TotalSeconds;
                    // Send the data to the right field (local or remote)
                    if (initData.isForMe(data))
                    {
                        display.SetDisplay(data);
                        _lastReceiveTime = DateTime.Now;
                        lblLastSvrIP.Text = "Local";
                    }
                    else if (comms != null)
                    {
                        data.soundLocation = settings.soundLocation;
                        SingleClient c = (SingleClient)sender;
                        comms.BroadcastMatchData(data, c.RecvPort);
                    }
                }
            }
            catch { }
        }

        private void ProcessSoundRequests(MatchData data)
        {
            // Nothing to play.
            if (data.soundPackage == null) return;
            bool shouldPlay = false;
            // If we're the server and sound should play on the server.
            if (initData.isServer && settings.soundLocation == MatchData.SoundLocations.Server) shouldPlay = true;
            // If the package is for me (the client) and sound is set to play on the client.
            else if (initData.isForMe(data) && settings.soundLocation == MatchData.SoundLocations.Client) shouldPlay = true;
            // If the sound location is 'both' then everyone is playing the sounds
            else if (settings.soundLocation == MatchData.SoundLocations.Both) shouldPlay = true;

            if (shouldPlay) SoundGenerator.PlaySound(data.soundPackage);
        }

        private void setDivisionDisplay(int divID, string divName)
        {
            StringBuilder sb = new StringBuilder();
            if (divID == 0)
            {
                if(divName == "") lblDivID.Text = "Not Named";
                else lblDivID.Text = divName;
            }
            else
            {
                if (divName != "") lblDivID.Text = string.Format("{0} ({1})", divName, divID);
                else lblDivID.Text = string.Format("Division {0}", divID);
            }
        }

        private void NewDataReceived(object sender, MatchData data)
        {
            if (display == null) return;
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => NewDataReceived(sender, data)));
            }
            else
            {
                if (initData.isForMe(data))
                {
                    ProcessSoundRequests(data);
                    setDivisionDisplay(data.divID, data.divisionName);
                    _thisClient.matchData = data;
                    cboMatchType.SelectedItem = data.matchType;
                    numMatchNumberMajor.Value = data.matchNumberMajor;
                    numMatchNumberMinor.Value = data.matchNumberMinor;
                    settings.soundLocation = data.soundLocation;
                    display.SetDisplay(data);
                    _lastReceiveTime = DateTime.Now;
                    lblLastSvrIP.Text = "Remote Server";
                }
            }
        }

        private void ErrorCodeExit(int code, string message = "")
        {
            if (code > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("There was an error that can not be handled and we must quit.");
                if (message != "") sb.AppendFormat("Error Message was: {0}{1}", message, Environment.NewLine);
                sb.AppendFormat("Error Code was: {0}{1}", code, Environment.NewLine);
                MessageBox.Show(sb.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Environment.ExitCode = code;
            Application.Exit();
        }

        /// <summary>
        /// Handles the Tick event of the displayTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PerodicTick(object sender, EventArgs e)
        {
            // Listener Status
            if (comms == null)
            {
                lblListenStatus.Text = "Controlled Locally";
                btnCycleListener.Text = "Local Required";
                tableFieldControl.Enabled = true;
            }
            else if (initData.runType == InitialData.RunType.Server)
            {
                lblListenStatus.Text = "No Local Timer";
                btnCycleListener.Text = "No Local Timer";
                tableFieldControl.Enabled = _selectedClient != null;
            }
            else
            {
                tableFieldControl.Enabled = !comms.isListening;
                if (comms.isListening)
                {
                    lblListenStatus.Text = "Listening to Server";
                    btnCycleListener.Text = "Switch to Local Control";
                }
                else
                {
                    if (initData.runType == InitialData.RunType.ServerClient)
                    {
                        btnCycleListener.Text = "Must Control Here";
                    }
                    else
                    {
                        btnCycleListener.Text = "Switch to Server Control";
                    }
                    lblListenStatus.Text = "Controlled Locally";
                }
            }
            // Display Status
            setLocalDisplayControlButtons();

            // Set the "last received" display
            lblLastRecvTime.Text = _lastReceiveTime.ToLongTimeString();
            if (_isReceiving)
            {
                picRcvTime.Image = Properties.Resources.indicator_green;
            }
            else
            {
                picRcvTime.Image = Properties.Resources.indicator_red;
                if (display != null) display.deadField();
            }
            // Load the help features if requested.
            toolTipMgr.Enabled = Properties.Settings.Default.showHelp;

            // Allow the user to pick a different field when no match is running if this is a server
            if (initData.isServer)
            {
                bool canSelectField = _selectedClient == null || !_selectedClient.matchData.isMatchActive || !Properties.Settings.Default.preventRunningMovement;
                tableFiledListMgmt.Enabled = canSelectField && initData.isServer;
                foreach (SingleClient c in _allClients) c.allowDisplayToStart = canSelectField;
            }
            else
            {
                tableFiledListMgmt.Enabled = false;
                flowFields.Enabled = false;
            }

            // Allow config windows when no clients are running
            btnSettings.Enabled = !_anyActiveMatches;

            ////  EVERYTHING BELOW HERE requires a selected client.
            if (_selectedClient == null) return;
            // Set the header
            headerFieldHead.Text = _selectedClient.DisplayString;
            // Allow user to edit field if it's not running
            cboMatchType.Enabled = _anyNotActiveMatchClients;
            numMatchNumberMajor.Enabled = _selectedClient.isMatchChangeable;
            numMatchNumberMinor.Enabled = _selectedClient.isMatchChangeable && MatchData.TypeUsesMinor(_currentMatchType);
            // Set the readonly values
            lblCurrentPeriod.Text = _selectedClient.matchData.matchPeriod.ToString();
            lblMatchStatus.Text = _selectedClient.matchData.matchStatus.ToString();
            lblTimerValue.Text = _selectedClient.matchData.timerValue.ToString();
            // enable the proper buttons
            btnStart.Enabled = _selectedClient.matchData.isWaitingForStart;
            btnPause.Enabled = _selectedClient.matchData.matchStatus == MatchData.MatchStatus.Running;
            btnStop.Enabled = _selectedClient.matchData.matchStatus == MatchData.MatchStatus.Paused;
            btnReset.Enabled = !_selectedClient.isMatchActive;
            btnAdvance.Enabled = !_selectedClient.isMatchActive;
            // Handle timeout buttons
            bool canTimeout = !_selectedClient.isMatchActive || _selectedClient.matchData.matchStatus == MatchData.MatchStatus.Timeout;
            btnTimeoutStart.Enabled = canTimeout;
            btnTimeoutCancel.Enabled = _selectedClient.matchData.matchStatus == MatchData.MatchStatus.Timeout;

            // Set button labels based on match status - Start
            if (_selectedClient.matchData.matchStatus == MatchData.MatchStatus.Paused) btnStart.Text = "Resume Match\n(F1)";
            else btnStart.Text = "Start Match\n(F1)";
            // Set button labels based on match status - Timeout
            if (_selectedClient.matchData.matchStatus == MatchData.MatchStatus.Timeout) btnTimeoutStart.Text = "Extend Timeout\n(F6)";
            else btnTimeoutStart.Text = "Start Timeout\n(F6)";

            // Pulse the button we're expecting to use
            ActivateNextButton();
            // Set the color of the Pac Button if it exists based on the Activate above
            PacDevices.UsbButtonDevices.setColor(new PacDevices.UsbButtonDevices.ButtonColorSettings(nextExpectedButton.BackColor, Color.Empty));
            // Update Match Progress
            progressDisplay.SetMatchProgress(_selectedClient.matchData);
            // Send the pit data
            SendPitData();
        }

        private void setLocalDisplayControlButtons()
        {
            if (display == null)
            {
                tableDisplayControl.Enabled = false;
            }
            else
            {
                tableDisplayControl.Enabled = true;
                frmDisplay.DisplayStatus status = display.displayStatus;
                btnDisplayHide.Checked = status == frmDisplay.DisplayStatus.Hide;
                btnDisplayWindow.Checked = status == frmDisplay.DisplayStatus.Windowed;
                btnDisplayFullscreen.Checked = status == frmDisplay.DisplayStatus.Fullscreen;
            }
        }

        private void selectFieldNumber(int field)
        {
            if (_allClients.Count == 0) return;
            // Return to the first field if asked for field zero
            if (field == 0) field = _allClients[0].matchData.fieldID;

            foreach (SingleClient c in _allClients)
            {
                if (c.matchData.fieldID == field) c.isSelected = true;
                else c.isSelected = false;
            }
        }

        private int nextFieldNumber
        {
            get
            {
                if (_selectedClient == null) return -1;
                int currentField = _selectedClient.matchData.fieldID;
                foreach (SingleClient cc in _allClients)
                {
                    if (cc.matchData.fieldID > currentField) return cc.matchData.fieldID;
                }
                return _allClients[0].matchData.fieldID;
            }
        }

        private void SendPitData()
        {
            if (_selectedClient == null) return;
            if (settings.pitDataSelection == PitData.PitDataSelections.Off) return;
            List<MatchData> list = new List<MatchData>();
            if (settings.pitDataSelection == PitData.PitDataSelections.ActiveOnly)
            {
                list.Add(_selectedClient.matchData);
            }
            else
            {
                foreach (SingleClient c in _allClients) list.Add(c.matchData);
            }
            PitData p = new PitData(list);
            p.pitDataSelection = settings.pitDataSelection;
            p.activeField = _selectedClient.matchData.fieldID;
            p.scoringAddress = Properties.Settings.Default.ScoringServerLocation;
            p.scrollSpeed = Properties.Settings.Default.ScoringScroll;
            if (PitData.sendClearData) p.clearData = true;
            PitData.sendClearData = false;
            if(comms != null) comms.BroadcastPitData(p);
        }

        private void ActivateNextButton()
        {
            if (_selectedClient == null) return;
            ButtonX nxt = nextExpectedButton;
            foreach (ButtonX b in fieldButtonList)
            {
                // Set buttons accordingly.
                if (b.Equals(nxt)) b.Pulse();
                else b.StopPulse();
            }
        }
        private ButtonX nextExpectedButton
        {
            get
            {
                if (_selectedClient == null) return null;
                ButtonX btn = null;
                switch (_selectedClient.matchData.matchStatus)
                {
                    case MatchData.MatchStatus.Stopped:
                        // If the match is not running and the start button is available, we're ready to start the next match
                        if (btnStart.Enabled) btn = btnStart;
                        // If the match completed, then we're ready to move to the next match
                        else if (_selectedClient.matchData.matchPeriod == MatchData.MatchPeriods.Complete) btn = btnAdvance;
                        // Otherwise, we must have aborted the previous match, so let's do it again!
                        else btn = btnReset;
                        break;
                    case MatchData.MatchStatus.Paused:
                        // If the match is paused, the expected button is Start, obviously.
                        btn = btnStart;
                        break;
                    case MatchData.MatchStatus.Running:
                        // If we're running, we really don't want to do do anything, but the pause buttn is the best option.
                        btn = btnPause;
                        break;
                    case MatchData.MatchStatus.Timeout:
                        // We're running a timeout.
                        btn = btnTimeoutCancel;
                        break;
                }
                return btn;
            }
            
        }

        private void MatchTypeChangeHandler(object sender, EventArgs e)
        {
            // Start the match major numbers over.
            numMatchNumberMajor.Value = 1;
            // If we're using minors for this type, set that default
            if(MatchData.TypeUsesMinor(_currentMatchType) && tableFieldControl.Enabled){
                numMatchNumberMinor.Value = 1;
                numMatchNumberMinor.Minimum = 1;
            }
            else
            {
                numMatchNumberMinor.Minimum = 0;
                numMatchNumberMinor.Value = 0;
            }
            // Tell all fields about the new match type
            foreach (SingleClient c in _allClients)
            {
                c.matchData.matchType = _currentMatchType;
            }
            // Select the first field again.
            if (_selectedClient != null)
            {
                selectFieldNumber(0);
                SetMatchNumber();
            }
        }

        private MatchData.MatchTypes _currentMatchType
        {
            get
            {
                MatchData.MatchTypes type;
                if (Enum.TryParse<MatchData.MatchTypes>(cboMatchType.SelectedValue.ToString(), out type))
                {
                    return type;
                }
                else
                {
                    return MatchData.MatchTypes.Unknown;
                }
            }
        }

        private void MatchNumberChangeHandler(object sender, EventArgs e)
        {
            SetMatchNumber();
        }

        private void SetMatchNumber()
        {
            if (_selectedClient == null) return;
            int newMajor = int.Parse(numMatchNumberMajor.Value.ToString());
            _selectedClient.matchData.matchNumberMajor = newMajor;
            int newMinor = int.Parse(numMatchNumberMinor.Value.ToString());
            _selectedClient.matchData.matchNumberMinor = newMinor;
        }

        private void FieldControlButtonsHandler(object sender, EventArgs e)
        {
            if (sender.Equals(btnStart))
            {
                SetMatchNumber();
                _selectedClient.MatchPower(true);
            }
            else if (sender.Equals(btnPause) || sender.Equals(btnStop))
            {
                _selectedClient.MatchPower(false);
            }
            else if (sender.Equals(btnReset))
            {
                SetMatchNumber();
                _selectedClient.ResetMatch();
            }
            else if (sender.Equals(btnAdvance))
            {
                AutoAdvanceMatch();
            }
            else if (sender.Equals(btnTimeoutStart))
            {
                frmStartTimeout wind = new frmStartTimeout(_currentMatchType, ref _allClients);
                wind.ShowDialog();
            }
            else if (sender.Equals(btnTimeoutCancel))
            {
                _selectedClient.ResetMatch();
            }
        }

        private void AutoAdvanceMatch()
        {
            if(_selectedClient == null) return;
            // If timeouts are available and it's enabled, call an automatic timeout on the current field.
            if(Properties.Settings.Default.autoElimTimeouts && MatchTimingData.matchTypeAllowsTimeout(_currentMatchType))
            {
                // Only start the timeout if the field is idle - aka not already running a timeout.
                if(!_selectedClient.isMatchActive)
                    _selectedClient.StartTimeout(SingleClient.TimeoutData.defaultEventTimeout);
            }
            // Select the next field
            selectFieldNumber(nextFieldNumber);
            
            bool usesMinor = false;
            int majorMax = MatchTimingData.getMatchTypeMinorMatchCount(_currentMatchType, out usesMinor);
            if (usesMinor)
            {
                int major = (int)numMatchNumberMajor.Value;
                int minor = (int)numMatchNumberMinor.Value;
                if (major == majorMax)
                {
                    major = 1;
                    minor++;
                }
                else
                {
                    major++;
                }
                numMatchNumberMajor.Value = major;
                numMatchNumberMinor.Value = minor;
            }
            else
            {
                numMatchNumberMajor.Value++;
            }

            SetMatchNumber();
            // if the field is idle, reset for this match. (if it's not, it's likely on a timeout and that'll reset it when it ends)
            if (!_selectedClient.isTimerRunning) _selectedClient.ResetMatch();
        }

        private void HandleFieldListMgmtButtons(object sender, EventArgs e)
        {
            if (sender.Equals(btnAddField))
            {
                frmRemoteFieldCreate wind = new frmRemoteFieldCreate(_allClients.Count + 1);
                wind.ShowDialog();
                if (wind.Tag == null) return;
                int newID = (int)wind.Tag;
                AddField(newID);
            }
            else
            {
                if (initData.isForMe(_selectedClient.matchData))
                {
                    string msg = "Can not remove local field.\nIf you do not want a local field, hold shift while restarting the application and select Server Only.";
                    MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RemoveField(_selectedClient);
                }
            }
        }

        private void btnCycleListener_Click(object sender, EventArgs e)
        {
            if (comms == null) return;
            if (comms.isListening)
            {
                comms.ListenControl(false);
                settings.soundLocation = MatchData.SoundLocations.Client;
            }
            else
            {
                comms.ListenControl(true);
            }
            foreach (SingleClient c in _allClients)
            {
                c.isLocalControl = !comms.isListening;
            }
        }

        private bool _anyActiveMatches
        {
            get
            {
                foreach (SingleClient c in _allClients) if (c.isMatchActive) return true;
                return false;
            }
        }
        private bool _anyNonIdleClients
        {
            get
            {
                foreach (SingleClient c in _allClients)
                {
                    if (c.isTimerRunning) return true;
                    if (c.isMatchActive) return true;
                }
                return false;
            }
        }
        private bool _anyNotActiveMatchClients
        {
            get
            {
                foreach (SingleClient c in _allClients) if (!c.isMatchActive) return true;
                return false;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the user from closing the app while a match is running.
                if (_anyNonIdleClients)
                {
                    if (ModifierKeys != Keys.Shift)
                    {
                        string msgWarn = "Matches Are Running!\nHold Shift and click Close if you're sure you want to quit.";
                        MessageBox.Show(msgWarn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Cancel = true;
                        return;
                    }
                }

                string msgSure = "Are you sure you want to exit?";
                DialogResult dr = MessageBox.Show(msgSure, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            SaveSettings();
            PacDevices.UsbButtonDevices.shutdown();
            if (comms != null)
            {
                comms.ListenControl(false);
            }
        }

        private void SoundSettingChangeHandler(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;
            foreach (SingleClient c in _allClients)
            {
                c.matchData.soundLocation = settings.soundLocation;
            }
        }

        private void LocalMuteHandler(object sender, EventArgs e)
        {
            SoundGenerator.isMuted = !SoundGenerator.isMuted;
            btnMute.Image = SoundGenerator.isMuted ? Properties.Resources.mute_on : Properties.Resources.mute_off;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            // Simulate field control button presses with Function Keys.
            ButtonX b = null;
            switch (e.KeyData)
            {
                case Keys.F1: b = btnStart; break;
                case Keys.F2: b = btnAdvance; break;
                case Keys.F3: b = btnReset; break;
                case Keys.F6: b = btnTimeoutStart; break;
                case Keys.F7: b = btnTimeoutCancel; break;
                case Keys.F11: b = btnPause; break;
                case Keys.F12: b = btnStop; break;
            }
            if (b != null && b.Enabled)
            {
                FieldControlButtonsHandler(b, new EventArgs());
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://github.com/VirginiaFIRST/FTC-Match-Timer", "Github Repo");
        }

        private void picLicense_Click(object sender, EventArgs e)
        {
            OpenLink("https://creativecommons.org/licenses/by-sa/4.0/", "Software License");
        }

        private void OpenLink(string link, string title)
        {
            if (!_selectedClient.isMatchChangeable)
            {
                string msg = "External Links aren't allowed while a match is running.";
                MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                GeneralFunctions.AppFunctions.OpenLink(link, title);
            }
        }

        private void pitDataSelectionHandler(object sender, EventArgs e)
        {
            PitData.sendClearData = true;
        }

        private void linkSetScoring_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSetScoringServer wind = new frmSetScoringServer();
            wind.ShowDialog();
        }

        private void picVafLogoClickHandler(object sender, EventArgs e)
        {
            OpenLink(@"http://www.virginiafirst.org", "VirginiaFIRST Homepage");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void changeDisplayStateButtonHandler(object sender, EventArgs e)
        {
            if (display == null) return;
            frmDisplay.DisplayStatus newStatus = frmDisplay.DisplayStatus.Hide;
            if (sender.Equals(btnDisplayWindow)) newStatus = frmDisplay.DisplayStatus.Windowed;
            if (sender.Equals(btnDisplayFullscreen)) newStatus = frmDisplay.DisplayStatus.Fullscreen;
            display.displayStatus = newStatus;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmInitialSetup wind = new frmInitialSetup(this.initData);
            wind.Show();
        }
    }
}
