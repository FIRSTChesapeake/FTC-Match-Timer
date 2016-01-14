using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FTC_Timer_Display
{

    public class SingleClient : IComparable
    {
        private System.Timers.Timer _timer = new System.Timers.Timer();
        private MatchData _data;
        private bool _isEnabled = true;
        private bool _isMultiDivision = true;
        private bool _allowDisplayToStart = false;
        private TimeoutData.SoundTypes _timeoutSounds = TimeoutData.SoundTypes.None;

        public SingleClientDisplay fieldDisplayObj { get; private set; }
        public frmFieldInfo fieldInfoWindow { get; private set; }

        public bool allowDisplayToStart { get { return _allowDisplayToStart; } set { _allowDisplayToStart = value; } }

        private bool _isSelected = false;
        private readonly bool _isLocal;

        public event EventHandler<MatchData> SendData;
        public event EventHandler<SingleClientRequest> RequestMade;
        public event EventHandler<ClientReply> ClientReplyEvent;

        // client reply IDs
        private DateTime _lastClientVerifySent = DateTime.Now.AddMonths(-1);
        private DateTime _lastClientVerifyRecv = DateTime.Now.AddMonths(-1);
        private static TimeSpan verifyDelay = new TimeSpan(0, 0, 5);
        private bool _wasLastOnline = false;

        public bool isOnline
        {
            get
            {
                bool r = true;
                // If this is a local timer and this app is controlling it, obviously we're connected.
                if (this._isLocal && this._isEnabled) r = true;
                // Servers use Recv to know when a client is dead. Clients use it to know when they are dead.
                else if (_lastClientVerifyRecv.Add(verifyDelay.Add(verifyDelay)) < DateTime.Now) r = false;
                // Do some logging
                if (r != _wasLastOnline)
                {
                    string lStr = "SYSTEM IS NOW {0} WITH {1}";
                    // Who are we talking to
                    string lWho = "SERVER";                                         // We're a client and talking to a server.
                    if (this._isEnabled && this._isLocal) lWho = "LOCAL";           // We're a server and talking to ourselves.
                    else if (this._isEnabled) lWho = "CLIENT";                      // We're a server and talking to a client.
                    // What is the new state
                    string lState = r ? "ONLINE" : "OFFLINE";
                    // Write log
                    log(lStr, lState, lWho);
                    _wasLastOnline = r;
                }
                return r;
            }
        }

        /// <summary>
        /// Generates the verify code (ticks) when asked to send to client.
        /// </summary>
        /// <returns></returns>
        private long generateVerify()
        {
            if (_lastClientVerifySent.Add(verifyDelay) < DateTime.Now)
            {
                _lastClientVerifySent = DateTime.Now;
                fieldInfoWindow.Update(DateTime.Now);
                return _lastClientVerifySent.Ticks;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Whether the client is the selected field.
        /// </summary>
        public bool isSelected 
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected && value) log("I am now the selected field.");
                _isSelected = value;
                fieldDisplayObj.UpdateDisplay(_data, value, _allowDisplayToStart);
                _data.isSelectedByServer = value;
            }
        }
        /// <summary>
        /// Whether the match contained is active (an actual match).
        /// </summary>
        public bool isMatchActive
        {
            get
            {
                return this._data.isMatchActive;
            }
        }
        /// <summary>
        /// Whether the timer is running, reguardless of why.
        /// </summary>
        public bool isTimerRunning
        {
            get
            {
                return this._data.isTimerRunning;
            }
        }
        /// <summary>
        /// Whether the SingleClient instance is being controlled here.
        /// </summary>
        public bool isLocalControl { set { _isEnabled = value; } get { return _isEnabled; } }

        /// <summary>
        /// Function to check if this field is the one identified by the given field info.
        /// </summary>
        /// <param name="div"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public bool isThisField(int div, int field)
        {
            if (div != _data.divID) return false;
            if (field != _data.fieldID) return false;
            return true;
        }

        /// <summary>
        /// Whether the match data is allowed to be changed.
        /// </summary>
        public bool isMatchChangeable
        {
            get
            {
                if (_data.matchStatus == MatchData.MatchStatus.Stopped) return true;
                return false;
            }
        }

        /// <summary>
        /// Implementation to compare two fields for sorting.
        /// </summary>
        /// <param name="otherObj"></param>
        /// <returns></returns>
        int IComparable.CompareTo(object otherObj)
        {
            try
            {
                SingleClient other = (SingleClient)otherObj;
                // Div ID first.
                if (this.matchData.divID > other.matchData.divID) return 1;
                if (this.matchData.divID < other.matchData.divID) return -1;

                // Not fields
                if (this.matchData.fieldID > other.matchData.fieldID) return 1;
                if (this.matchData.fieldID < other.matchData.fieldID) return -1;
                // they are the same? What?
                return 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Internal function to log data from the instance.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        private void log(string message, params object[] args)
        {
            if (!Properties.logging.Default.logSingleClientChanges) return;
            string myName = string.Format("SingleClient-{0}-{1}", this.matchData.divID, this.matchData.fieldID);
            LogMgr.logger.Info(LogMgr.make(message, myName, 0, args));
        }

        /// <summary>
        /// get the raw match data
        /// </summary>
        public MatchData matchData
        {
            get { return _data; }
            set
            {
                _data = value;
                if(!this.isLocalControl) 
                    ClientEchoVerification();
            }
        }
        /// <summary>
        /// Get the UDP port number we use for this field from the comm port.
        /// </summary>
        public int RecvPort
        {
            get
            {
                return myUdpClient.UdpComms.CreateRecvPort(_data.divID, _data.fieldID);
            }
        }
        /// <summary>
        /// Get the string that is used to represent this client on the UI.
        /// </summary>
        public string DisplayString
        {
            get
            {
                if (_isMultiDivision) return String.Format("Division {0} Field {1}", _data.divID, _data.fieldID);
                else return String.Format("Field {0}", _data.fieldID);
            }
        }

        /// <summary>
        /// Handler for when a user clicks something on an associated SingleClientDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CtrlClickHandler(object sender, EventArgs e)
        {
            if (RequestMade != null)
            {
                EventHandler<SingleClientRequest> handler = RequestMade;
                handler(this, SingleClientRequest.SelectMe);
            }
        }
        /// <summary>
        /// Replies to the server with a Reply Package to let it know it's receiving
        /// </summary>
        private void ClientEchoVerification()
        {
            if (this.isLocalControl) return;
            if (_data.serverHeartbeat == -1) return;
            if (ClientReplyEvent != null)
            {
                // Save when we last heard a verification request so we know when we're dead
                _lastClientVerifyRecv = DateTime.Now;
                fieldInfoWindow.Update(DateTime.Now);
                // Raise the request event
                ClientReply c = new ClientReply(this);
                EventHandler<ClientReply> handler = ClientReplyEvent;
                handler(this, c);
            }
        }

        /// <summary>
        /// Receives the verification from the client and verifies the code is what we sent it last.
        /// </summary>
        /// <param name="reply">The reply.</param>
        public void ReceiveVerification(ClientReply reply)
        {
            // Test good - if this doesn't match, are we getting an old packet?
            if (_lastClientVerifySent.Ticks == reply.verification)
            {
                _lastClientVerifyRecv = DateTime.Now;
                // Check if the client is using the same version as the server
                fieldDisplayObj.isVersionMismatch = (reply.clientVersion != GeneralFunctions.AppFunctions.appVersion);
                // Update the info window
                fieldInfoWindow.Update(reply);
            }
            else
            {
                log("Receiving malformed reply verifications.");
            }
        }

        /// <summary>
        /// Handler for the radial menu of the associated SingleClientDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cmd"></param>
        private void CtrlRadialHandler(object sender, SingleClientDisplay.RadialCommands cmd)
        {
            switch (cmd)
            {
                case SingleClientDisplay.RadialCommands.None: return;
                case SingleClientDisplay.RadialCommands.Start:
                    this.MatchPower(true);
                    break;
                case SingleClientDisplay.RadialCommands.Pause:
                case SingleClientDisplay.RadialCommands.Stop:
                    this.MatchPower(false);
                    break;
                case SingleClientDisplay.RadialCommands.Timeout:
                    if (RequestMade != null)
                    {
                        EventHandler<SingleClientRequest> handler = RequestMade;
                        handler(this, SingleClientRequest.TimeoutStart);
                    }
                    break;
                case SingleClientDisplay.RadialCommands.Reset:
                case SingleClientDisplay.RadialCommands.AbortTimeout:
                    this.ResetMatch();
                    break;
                case SingleClientDisplay.RadialCommands.ShowInfo:
                    this.fieldInfoWindow.Show();
                    break;
            }
        }

        private void TimeoutRequest(bool start)
        {
            
        }

        /// <summary>
        /// Constructor to create a new SingleClient
        /// </summary>
        /// <param name="initData">The initial data object from the main form</param>
        /// <param name="fieldID">The field ID number of the new field</param>
        /// <param name="width">The desired width of the field's DisplayObject</param>
        /// <param name="SendDataHandler">Handler that will receive the requests to send new data to the network</param>
        /// <param name="RequestHandler">Handler that will receive the click events from the DisplayObject</param>
        public SingleClient(InitialData initData, int fieldID, int width,
            EventHandler<MatchData> SendDataHandler, EventHandler<SingleClientRequest> RequestHandler)
        {
            this._isLocal = (initData.fieldID == fieldID);
            SendData += SendDataHandler;
            RequestMade += RequestHandler;
            _data = new MatchData(initData, fieldID);
            _isMultiDivision = initData.isMultiDivision;
            ResetMatch();
            this.fieldDisplayObj = new SingleClientDisplay(fieldID, this.RecvPort, _isLocal, CtrlClickHandler, CtrlRadialHandler, width);
            this.fieldInfoWindow = new frmFieldInfo(initData.divID, fieldID, this.RecvPort);
            _timer.Interval = 1000;
            _timer.Elapsed += timer_Elapsed;
            _isEnabled = (initData.isServer || initData.runType == InitialData.RunType.Local);
            _timer.Start();
            log("Client Started!");
        }
        /// <summary>
        /// Handler for the meat-and-potatoes timer that does the actual counting.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // If we're not enabled, we are a client and need to only verify we're connected.
            if (!_isEnabled)
            {
                // Update the display object with data
                this.fieldDisplayObj.UpdateDisplay(_data, this.isSelected, _allowDisplayToStart);
                // Update the display object with our online status
                this.fieldDisplayObj.isOnline = this.isOnline;
            }
            // If we're enabled, we're a 'server' and need to do all the work.
            else
            {
                // Process timing
                ProcessTiming();
                // Add shared settings 
                _data.useLargeActive = Properties.Settings.Default.useLargeActive;
                _data.displayFieldNumber = Properties.Settings.Default.showDisplayFieldNumbers;
                // Send on down the road!
                if (SendData != null)
                {
                    EventHandler<MatchData> handler = SendData;
                    handler(this, _data);
                }
                // Forget the sound we just played (if any)
                _data.soundPackage = null;
            }
        }
        /// <summary>
        /// Called to reset the match data to start-of-match settings.
        /// </summary>
        public void ResetMatch()
        {
            _data.matchStatus = MatchData.MatchStatus.Stopped;
            _data.matchPeriod = MatchData.MatchPeriods.NotStarted;
            _data.timerValue = MatchTimingData.matchLength;
            _data.noCrossActive = false;
            log("Match Reset");
        }
        /// <summary>
        /// Starts a 
        /// </summary>
        /// <param name="data"></param>
        public void StartTimeout(TimeoutData data)
        {
            _data.timeoutMessage = data.message;
            if (_data.matchStatus == MatchData.MatchStatus.Timeout)
            {
                _data.timerValue = _data.timerValue.Add(data.value);
                this._timeoutSounds = data.soundType;
                log("Adding time to Timeout: {0}", data.value);
            }
            else if (_data.matchStatus == MatchData.MatchStatus.Stopped)
            {
                _data.timerValue = data.value;
                this._timeoutSounds = data.soundType;
                _data.matchStatus = MatchData.MatchStatus.Timeout;
                log("Timeout Started: {0}", data.value);
            }
            else
            {
                log("Timeout request failed! Field can not timeout now. Current State: {0}", _data.matchStatus.ToString());
            }
        }

        /// <summary>
        /// Controls whether the match is running or paused/stopped.
        /// </summary>
        /// <param name="running">New match state</param>
        public void MatchPower(bool running)
        {
            MatchData.MatchStatus newStatus = MatchData.MatchStatus.Running;
            if (!running && _data.matchStatus == MatchData.MatchStatus.Running) newStatus = MatchData.MatchStatus.Paused;
            else if (!running && _data.matchStatus == MatchData.MatchStatus.Paused) newStatus = MatchData.MatchStatus.Stopped;
            log("User requested MatchPower change from {0} to {1}", _data.matchStatus, newStatus.ToString());

            if (running)
            {
                if (!_data.isTimerRunning)
                {
                    if (_data.matchPeriod == MatchData.MatchPeriods.NotStarted)
                    {
                        _data.matchPeriod = MatchData.MatchPeriods.Autonomous;
                        _data.matchStatus = MatchData.MatchStatus.Running;
                        _data.noCrossActive = true;
                        _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "charge");
                    }
                    else if (_data.matchPeriod == MatchData.MatchPeriods.DriverControlled)
                    {
                        _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "firebell");
                    }
                    _data.matchStatus = MatchData.MatchStatus.Running;
                    log("Field successfully started. Period: {0}", _data.matchPeriod);
                }
                else
                {
                    log("Tried to start match but field status '{0}' can't do that.", _data.matchStatus);
                }
            }
            else if(_data.matchStatus == MatchData.MatchStatus.Running)
            {
                _data.matchStatus = MatchData.MatchStatus.Paused;
            }
            else if (_data.matchStatus == MatchData.MatchStatus.Paused)
            {
                _data.matchStatus = MatchData.MatchStatus.Stopped;
            }
            else
            {
                log("Field stop requested but it {0} is not a running status.", _data.matchStatus);
            }
        }

        private void ProcessTiming()
        {
            MatchData.MatchStatus newStatus = _data.matchStatus;
            MatchData.MatchPeriods newPeriod = _data.matchPeriod;
            if (_data.matchStatus == MatchData.MatchStatus.Running)
            {
                TimeSpan ts = _data.timerValue.Subtract(new TimeSpan(0, 0, 1));
                _data.timerValue = ts;
                if (ts.TotalSeconds == MatchTimingData.whenNoCrossEnd.TotalSeconds)
                {
                    // Special case for No Cross Alert
                    _data.noCrossActive = false;
                    _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "factwhistle");
                    log("No Cross Reached");
                }
                else if (ts.TotalSeconds == MatchTimingData.whenAutoEnd.TotalSeconds)
                {
                    // Auto hads ended.
                    newStatus = MatchData.MatchStatus.Paused;
                    newPeriod = MatchData.MatchPeriods.DriverControlled;
                    _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "endauto");
                }
                else if (ts.TotalSeconds == MatchTimingData.whenEndgameStart.TotalSeconds)
                {
                    // Entering Endgame
                    newPeriod = MatchData.MatchPeriods.EndGame;
                    _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "factwhistle");
                }
                else if (ts.TotalSeconds <= 0)
                {
                    // Match is over
                    _data.timerValue = new TimeSpan();
                    newPeriod = MatchData.MatchPeriods.Complete;
                    newStatus = MatchData.MatchStatus.Stopped;
                    _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "endmatch");
                }
            }
            else if (_data.matchStatus == MatchData.MatchStatus.Timeout)
            {
                // If a match isn't running and we're on timeout, decrement that.
                TimeSpan ts = _data.timerValue.Subtract(new TimeSpan(0, 0, 1));
                _data.timerValue = ts;
                if (ts.TotalSeconds <= 0)
                {
                    newStatus = MatchData.MatchStatus.Stopped;
                    if (_timeoutSounds == TimeoutData.SoundTypes.Buzzer)
                    {
                        _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "endmatch");
                    }
                    else if (_timeoutSounds == TimeoutData.SoundTypes.Voice)
                    {
                        string msg = string.Format("Time out on field {0} has ended.", _data.fieldID);
                        _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.TextToSpeech, msg);
                    }
                    this.ResetMatch();
                }
            }
            // Process countdown (only if we're not already playing a sound, and the timer is running)
            if (Properties.Settings.Default.useCountdown && _data.soundPackage == null && _data.isTimerRunning)
            {
                if (_data.timerValue.Add(new TimeSpan(0, 0, -1)) < MatchTimingData.countdownStart)
                {
                    string countStr = SoundGenerator.TimeSpanToString(_data.timerValue);
                    SoundGenerator.SoundPackage p = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, countStr);
                    if (p.soundCanPlay) _data.soundPackage = p;
                    else _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.TextToSpeech, countStr);
                }
            }
            // Write to log if needed
            string logStatus = (newStatus != _data.matchStatus) ? string.Format("status from '{0}' to '{1}'", _data.matchStatus, newStatus) : "";
            string logPeriod = (newPeriod != _data.matchPeriod) ? string.Format("period from '{0}' to '{1}'", _data.matchPeriod, newPeriod) : "";
            if (logStatus != string.Empty || logPeriod != string.Empty)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Match progression updated ");
                sb.AppendFormat(logStatus);
                if (logStatus != string.Empty && logPeriod != string.Empty) sb.Append(" and ");
                sb.Append(logPeriod);
                log(sb.ToString());
            }
            // Save the new status & period to the _data object
            _data.matchStatus = newStatus;
            _data.matchPeriod = newPeriod;
            // Write the heartbeat for the client so we can verify it later
            _data.serverHeartbeat = generateVerify();
            // Update the display object with data
            this.fieldDisplayObj.UpdateDisplay(_data, this.isSelected, _allowDisplayToStart);
            // Update the display object with our online status
            this.fieldDisplayObj.isOnline = this.isOnline;
        }

        public enum SingleClientRequest
        {
            None,
            SelectMe,
            TimeoutStart
        }
        /// <summary>
        /// Shutdowns this instance and prepares it for collection.
        /// </summary>
        public void Shutdown()
        {
            _timer.Stop();
            
        }

        public class TimeoutData
        {
            public static TimeoutData defaultEventTimeout
            {
                get
                {
                    TimeoutData t = new TimeoutData(MatchTimingData.timeoutEventLength, "Match Cooldown", SingleClient.TimeoutData.SoundTypes.None);
                    return t;
                }
            }

            public TimeSpan value = new TimeSpan();
            public string message = "";
            public SoundTypes soundType = SoundTypes.Voice;

            public TimeoutData(TimeSpan val, string msg, SoundTypes snd)
            {
                this.value = val;
                this.message = msg;
                this.soundType = snd;
            }

            public enum SoundTypes
            {
                None,
                Buzzer,
                Voice
            }
        }
    }
}
