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

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (initData == null) GetInitialData();
            // Display config.
            lblMode.Text = initData.runType.ToString();
            lblDivID.Text = initData.divID.ToString();
            lblDivName.Text = initData.divName;

            // Init the MatchType dropdown, default to qualification
            cboMatchType.DataSource = Enum.GetValues(typeof(MatchData.MatchTypes));
            cboMatchType.SelectedIndex = 2;

            // Init the local timer if needed.
            if (initData.runType == InitialData.RunType.Server)
            {
                lblFieldID.Text = "No Local Timer";
                btnShowDisplay.Enabled = false;
            }
            else
            {
                bool timerStart = initData.runType == InitialData.RunType.ServerClient;
                display = new frmDisplay(initData);
                lblFieldID.Text = initData.fieldID.ToString();
                SingleClient localClient = new SingleClient(initData.divID, initData.divName, initData.fieldID, SendFieldDataHandler, timerStart);
                AddRemoveField(localClient);
            }

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

        private void AddRemoveField(SingleClient client, bool add = true)
        {
            listFields.DataSource = null;
            if (add)
            {
                client.matchData.matchType = _currentMatchType;
                _allClients.Add(client);
            }
            if (!add)
            {
                _allClients.Remove(client);
            }

            listFields.DisplayMember = "DisplayString";
            listFields.DataSource = _allClients;
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
                    if (initData.isForMe(data))
                    {
                        display.SetDisplay(data);
                        lblLastRecvTime.Text = DateTime.Now.ToLongTimeString();
                        lblLastSvrIP.Text = "Local";
                    }
                    else if (comms != null)
                    {
                        SingleClient c = (SingleClient)sender;
                        comms.BroadcastMatchData(data, c.RecvPort);
                    }
                }
            }
            catch { }
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
                    lblDivName.Text = data.divisionName;
                    _selectedClient.matchData = data;
                    cboMatchType.SelectedItem = data.matchType;
                    numMatchNumberMajor.Value = data.matchNumberMajor;
                    numMatchNumberMinor.Value = data.matchNumberMinor;
                    display.SetDisplay(data);
                    lblLastRecvTime.Text = DateTime.Now.ToLongTimeString();
                    lblLastSvrIP.Text = "Remote Server";
                }
            }
        }

        private void GetInitialData()
        {
            frmModeSelection wnd = new frmModeSelection();
            wnd.ShowDialog();
            if (wnd.Tag == null) CallNoDataExit(1);
            InitialData data = (InitialData)wnd.Tag;
            if (data.runType == InitialData.RunType.None) CallNoDataExit(2);
            initData = data;
        }

        private void CallNoDataExit(int part)
        {
            string msg = String.Format("Initialization Data is Missing. Quitting." + Environment.NewLine + "Part: {0}", part);
            MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        /// <summary>
        /// Handles the Tick event of the displayTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void displayTimer_Tick(object sender, EventArgs e)
        {
            if (_selectedClient == null) return;
            // Set the header
            lblFieldHead.Text = _selectedClient.DisplayString;
            // Allow user to edit field if it's not running
            cboMatchType.Enabled = _selectedClient.canBeChanged;
            numMatchNumberMajor.Enabled = _selectedClient.canBeChanged;
            numMatchNumberMinor.Enabled = _selectedClient.canBeChanged;
            // Set the readonly values
            lblCurrentPeriod.Text = _selectedClient.matchData.matchPeriod.ToString();
            lblMatchStatus.Text = _selectedClient.matchData.matchStatus.ToString();
            lblTimerValue.Text = _selectedClient.matchData.timerValue.ToString();
            // enable the proper inputs
            numMatchNumberMinor.Enabled = MatchData.TypeUsesMinor(_currentMatchType);;
            // enable the proper buttons
            btnStart.Enabled = _selectedClient.matchData.waitingForStart;
            btnPause.Enabled = _selectedClient.matchData.matchStatus == MatchData.MatchStatus.Running;
            btnStop.Enabled = _selectedClient.matchData.matchStatus == MatchData.MatchStatus.Paused;
            btnReset.Enabled = _selectedClient.matchData.matchStatus == MatchData.MatchStatus.Stopped;
            btnAdvance.Enabled = !_selectedClient.matchData.activeMatch;
            // Allow the user to pick a different field when no match is running
            bool canSelectField = _selectedClient == null || !_selectedClient.matchData.activeMatch;
            bool handlesMultiFields = initData.runType == InitialData.RunType.Server || initData.runType == InitialData.RunType.ServerClient;
            listFields.Enabled = canSelectField && handlesMultiFields;
            btnAddField.Enabled = canSelectField && handlesMultiFields;
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
        }

        private void MatchTypeChangeHandler(object sender, EventArgs e)
        {
            foreach (SingleClient c in _allClients)
            {
                c.matchData.matchType = _currentMatchType;
            }
            numMatchNumberMajor.Value = 1;
            if(MatchData.TypeUsesMinor(_currentMatchType)){
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

        private void MinorMatchNumberChangeHandler(object sender, EventArgs e)
        {

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
        }

        private void AutoAdvanceHandler(object sender, EventArgs e)
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

        private void HandleFieldMgmtButtons(object sender, EventArgs e)
        {
            if (sender.Equals(btnAddField))
            {
                frmRemoteFieldCreate wind = new frmRemoteFieldCreate(_allClients.Count + 1);
                wind.ShowDialog();
                if (wind.Tag == null) return;
                int newID = (int)wind.Tag;
                foreach (SingleClient c in _allClients)
                {
                    if (c.matchData.fieldID == newID)
                    {
                        string msg = "This Field already exists. Can not add it again.";
                        MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                SingleClient newClient = new SingleClient(initData.divID, initData.divName, newID, SendFieldDataHandler, true);
                AddRemoveField(newClient, true);
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
                    AddRemoveField(_selectedClient, false);
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
            if (comms != null)
            {
                comms.ListenControl(false);
            }
        }

        private void HandleDisplayBtns(object sender, EventArgs e)
        {
            if (sender.Equals(btnShowDisplay))
                display.Visible = !display.Visible;
            else
                if (display.Visible) display.ChangeFullscreen();
        }
    }
}
