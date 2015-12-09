using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public partial class frmMain : Form
    {
        InitialData initData;
        UdpComms comms;

        frmDisplay display;

        private List<SingleClient> _allClients = new List<SingleClient>();

        private SingleClient _selectedClient
        {
            get
            {
                return (SingleClient)listFields.SelectedItem;
            }
        }

        public MatchData.SoundLocations soundLocation
        {
            get
            {
                if (this.initData.isServer)
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
                else if (this.initData.isServer)
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
                    Debug.WriteLine("Saving Fields:");
                    Debug.Indent();
                    foreach (SingleClient c in _allClients)
                    {
                        Debug.WriteLine(string.Format("Saving Field: {0}", c.matchData.fieldID.ToString()));
                        if (!first) sb.Append(",");
                        first = false;
                        sb.Append(c.matchData.fieldID.ToString());
                    }
                    Debug.Unindent();
                    Debug.WriteLine(string.Format("Save String: {0}", sb.ToString()));
                    Properties.Settings.Default.FieldList = sb.ToString();
                }
                // Save the sould mode we're using.
                Properties.Settings.Default.SoundLocation = (int)soundLocation;
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
            // Load stored settings or request settings from user.
            int AppSettingsError = 0;
            initData = InitialData.LoadAppSettings(out AppSettingsError);
            // Handle the missing Data error. Without it, we cant' continue.
            if (initData == null || AppSettingsError != 0) ErrorCodeExit(AppSettingsError, "Error loading Settings Data");

            // Display config that relates to all the settings.
            lblMode.Text = initData.runType.ToString();
            lblDivID.Text = initData.divID.ToString();
            lblDivName.Text = initData.divName;

            if (initData.isServer)
            {
                string csv = Properties.Settings.Default.FieldList;
                string[] list = csv.Split(',');
                if (list.Length > 0)
                {
                    Debug.WriteLine("Loading Saved Fields:");
                    Debug.Indent();
                    foreach (string s in list)
                    {
                        //try
                        //{
                            if (s == "") continue;
                            Debug.Write(string.Format("Loading Field: {0}.. ", s));
                            int i = int.Parse(s);
                            this.AddField(i);
                            Debug.WriteLine("Done.");
                        //}
                        //catch { }
                    }
                    Debug.Unindent();
                    Debug.WriteLine("Done Loading Fields.");
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();
            // Init the MatchType dropdown, default to qualification
            cboMatchType.DataSource = Enum.GetValues(typeof(MatchData.MatchTypes));
            cboMatchType.SelectedIndex = 2;
            // Init the sound generator
            SoundGenerator.init();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Load all settings
            this.LoadSettings();

            // Init the local timer if needed.
            if (initData.runType == InitialData.RunType.Server)
            {
                lblFieldID.Text = "No Local Timer";
                linkToggleDisplay.Enabled = false;
            }
            else
            {
                
                display = new frmDisplay(initData);
                lblFieldID.Text = initData.fieldID.ToString();
                AddField(initData.fieldID);
            }

            // Select default sound setting based on init.
            rdoSoundLocal.Checked = initData.isServer;
            rdoSoundRemote.Checked = !initData.isServer;

            // Setup Comms if needed
            if (initData.runType != InitialData.RunType.Local)
            {
                comms = new UdpComms(initData.divID, initData.fieldID, NewDataReceived);
                if (initData.runType == InitialData.RunType.Client)
                {
                    btnCycleListener.Enabled = true;
                    comms.ListenControl(true);
                }
            }
        }

        private void AddField(int fieldID)
        {
            if (FieldExists(fieldID)) return;

            listFields.DataSource = null;
            SingleClient client = new SingleClient(initData.divID, initData.divName, fieldID, SendFieldDataHandler, initData.isServer);

            client.matchData.matchType = _currentMatchType;
            _allClients.Add(client);

            listFields.DisplayMember = "DisplayString";
            listFields.DataSource = _allClients;
            //listFields.Sorted = true;
        }

        private void RemoveField(SingleClient client)
        {
            if (!_allClients.Contains(client)) return;
            listFields.DataSource = null;
            _allClients.Remove(client);
            listFields.DisplayMember = "DisplayString";
            listFields.DataSource = _allClients;
            listFields.Sorted = true;
        }

        private bool FieldExists(int fieldID)
        {
            foreach (SingleClient c in _allClients)
            {
                if (c.matchData.fieldID == fieldID) return true;
            }
            return false;
        }

        private void SendFieldDataHandler(object sender, MatchData data)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    object o = this.Invoke(new Action(() => SendFieldDataHandler(sender, data)));
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
                        lblLastRecvTime.Text = DateTime.Now.ToLongTimeString();
                        lblLastSvrIP.Text = "Local";
                    }
                    else if (comms != null)
                    {
                        data.soundLocation = this.soundLocation;
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
            if (data.playSound == "") return;
            bool shouldPlay = false;
            // If we're the server and sound should play on the server.
            if (initData.isServer && soundLocation == MatchData.SoundLocations.Server) shouldPlay = true;
            // If the package is for me (the client) and sound is set to play on the client.
            else if (initData.isForMe(data) && soundLocation == MatchData.SoundLocations.Client) shouldPlay = true;

            if (shouldPlay) SoundGenerator.PlaySound(data.playSound);
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
                    lblDivName.Text = data.divisionName;
                    _selectedClient.matchData = data;
                    cboMatchType.SelectedItem = data.matchType;
                    numMatchNumberMajor.Value = data.matchNumberMajor;
                    numMatchNumberMinor.Value = data.matchNumberMinor;
                    soundLocation = data.soundLocation;
                    display.SetDisplay(data);
                    lblLastRecvTime.Text = DateTime.Now.ToLongTimeString();
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
                    lblListenStatus.Text = "Controlled Locally";
                    btnCycleListener.Text = "Switch to Server Control";
                }
            }
            ////  EVERYTHING BELOW HERE requires a selected client.
            if (_selectedClient == null) return;
            // Set the header
            lblFieldHead.Text = _selectedClient.DisplayString;
            // Set the Match Progress Display
            
            // Allow user to edit field if it's not running
            cboMatchType.Enabled = _selectedClient.canBeChanged;
            numMatchNumberMajor.Enabled = _selectedClient.canBeChanged;
            numMatchNumberMinor.Enabled = _selectedClient.canBeChanged && MatchData.TypeUsesMinor(_currentMatchType);
            // Set the readonly values
            lblCurrentPeriod.Text = _selectedClient.matchData.matchPeriod.ToString();
            lblMatchStatus.Text = _selectedClient.matchData.matchStatus.ToString();
            lblTimerValue.Text = _selectedClient.matchData.timerValue.ToString();
            // enable the proper buttons
            btnStart.Enabled = _selectedClient.matchData.waitingForStart;
            btnPause.Enabled = _selectedClient.matchData.matchStatus == MatchData.MatchStatus.Running;
            btnStop.Enabled = _selectedClient.matchData.matchStatus == MatchData.MatchStatus.Paused;
            btnReset.Enabled = !_selectedClient.matchData.activeMatch;
            btnAdvance.Enabled = !_selectedClient.matchData.activeMatch;
            linkSetMatchTimes.Enabled = !_selectedClient.matchData.activeMatch;
            // Enable / Disable sound settings
            grpSoundOptions.Enabled = initData.isServer;
            // Allow the user to pick a different field when no match is running
            bool canSelectField = _selectedClient == null || !_selectedClient.matchData.activeMatch;
            listFields.Enabled = canSelectField && initData.isServer;
            btnAddField.Enabled = canSelectField && initData.isServer;

            // Pulse the button we're expecting to use
            ActivateNextButton();
            // Update Match Progress
            MatchProgressDisplay();
        }

        private void MatchProgressDisplay()
        {
            // Progress Steps
            matchProgress.CurrentStep = ((int)_selectedClient.matchData.matchPeriod) + 1;
            // Period Display
            matchPercent.Value = _selectedClient.matchData.percentComplete;
        }

        private void ActivateNextButton()
        {
            List<ButtonX> list = new List<ButtonX>();
            list.Add(btnStart);
            list.Add(btnStop);
            list.Add(btnPause);
            list.Add(btnReset);
            list.Add(btnAdvance);
            ButtonX btn = null;
            switch (_selectedClient.matchData.matchStatus)
            {
                case MatchData.MatchStatus.Stopped:
                    if (btnStart.Enabled) btn = btnStart;
                    else if (_selectedClient.matchData.matchPeriod == MatchData.MatchPeriods.Complete) btn = btnAdvance;
                    else btn = btnReset;
                    break;
                case MatchData.MatchStatus.Paused:
                    btn = btnStart;
                    break;
                case MatchData.MatchStatus.Running:
                    btn = btnPause;
                    break;
            }
            foreach(ButtonX b in list)
            {
                if (b.Equals(btn)) b.Pulse();
                else b.StopPulse();
            }
        }

        private void MatchTypeChangeHandler(object sender, EventArgs e)
        {
            foreach (SingleClient c in _allClients)
            {
                c.matchData.matchType = _currentMatchType;
            }
            numMatchNumberMajor.Value = 1;
            if(MatchData.TypeUsesMinor(_currentMatchType) && tableFieldControl.Enabled){
                numMatchNumberMinor.Value = 1;
                numMatchNumberMinor.Minimum = 1;
            }
            else
            {
                numMatchNumberMinor.Minimum = 0;
                numMatchNumberMinor.Value = 0;
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
        }

        private void AutoAdvanceMatch()
        {
            if(_selectedClient == null) return;
            if (_allClients.Count == 1)
            {
                // Do nothing, we're staying right here.
            }
            if (listFields.SelectedIndex == _allClients.Count - 1)
            {
                // Wrap to the first field.
                listFields.SelectedIndex = 0;
            }
            else
            {
                // Move to the next field
                listFields.SelectedIndex = listFields.SelectedIndex + 1;
            }
            switch (_currentMatchType)
            {
                case MatchData.MatchTypes.Unknown:
                case MatchData.MatchTypes.Practice:
                case MatchData.MatchTypes.Qualification:
                case MatchData.MatchTypes.Finals:
                    numMatchNumberMajor.Value++;
                    break;
            }
            SetMatchNumber();
            _selectedClient.ResetMatch();
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
                    string msg = "Can not remove local field.\nIf you do not want a local field, restart the application as Server Only.";
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
            }
            else
            {
                comms.ListenControl(true);
            }
            foreach (SingleClient c in _allClients)
            {
                c.localControl = !comms.isListening;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the user from closing the app while a match is running.
                if (_selectedClient != null && _selectedClient.matchData.matchStatus != MatchData.MatchStatus.Stopped)
                {
                    if (ModifierKeys != Keys.Shift)
                    {
                        string msgWarn = "Match Running!\nHold Shift and click Close if you're sure you want to quit.";
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
                c.matchData.soundLocation = this.soundLocation;
            }
        }

        private void LocalMuteHandler(object sender, EventArgs e)
        {
            SoundGenerator.isMuted = chkLocalMute.Checked;
        }

        private void HandleOptionsLinkLabels(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender.Equals(linkToggleDisplay))
            {
                display.Visible = !display.Visible;
            }
            else if (sender.Equals(linkReInit))
            {
                int SettingsError = 0;
                InitialData data = InitialData.GetInitialData(initData, out SettingsError);
                if (data != null && SettingsError == 0)
                {
                    initData = data;
                    initData.SaveSettings();
                }
            }
            else if (sender.Equals(linkSetMatchTimes))
            {
                if (MatchTimingData.editTiming())
                {
                    SetMatchNumber();
                    _selectedClient.ResetMatch();
                }
            }
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
                case Keys.F11: b = btnPause; break;
                case Keys.F12: b = btnStop; break;
            }
            if (b != null)
            {
                FieldControlButtonsHandler(b, new EventArgs());
                return;
            }
        }
    }
}
