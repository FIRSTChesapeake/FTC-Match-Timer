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
        private TimeoutData.SoundTypes _timeoutSounds = TimeoutData.SoundTypes.None;

        public SingleClientDisplay fieldDisplayObj { get; private set; }


        private bool _isSelected = false;
        public bool isSelected 
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                fieldDisplayObj.UpdateDisplay(_data, value);
            }
        }

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

        public MatchData matchData
        {
            get { return _data; }
            set { _data = value; }
        }
        public int RecvPort
        {
            get
            {
                return UdpComms.CreateRecvPort(_data.divID, _data.fieldID);
            }
        }

        public string DisplayString
        {
            get
            {
                if (_isMultiDivision) return String.Format("Division {0} Field {1}", _data.divID, _data.fieldID);
                else return String.Format("Field {0}", _data.fieldID);
            }
        }

        public bool localControl { set { _isEnabled = value; } get { return _isEnabled; } }

        public bool isThisField(int div, int field)
        {
            if (div != _data.divID) return false;
            if (field != _data.fieldID) return false;
            return true;
        }

        public bool canBeChanged
        {
            get
            {
                if (_data.matchStatus == MatchData.MatchStatus.Stopped) return true;
                return false;
            }
        }

        public event EventHandler<MatchData> SendData;
        public event EventHandler<int> ControlClicked;

        private void CtrlClickHandler(object sender, EventArgs e)
        {
            if (ControlClicked != null)
            {
                EventHandler<int> handler = ControlClicked;
                handler(this, this.matchData.fieldID);
            }
        }

        public SingleClient(InitialData initData, int fieldID, EventHandler<MatchData> SendDataHandler, EventHandler<int> DisplayClickHandler)
        {
            this.fieldDisplayObj = new SingleClientDisplay(fieldID, (initData.fieldID == fieldID), CtrlClickHandler);
            SendData += SendDataHandler;
            ControlClicked += DisplayClickHandler;
            _data = new MatchData(initData, fieldID);
            _isMultiDivision = initData.isMultiDivision;
            ResetMatch();
            _timer.Interval = 1000;
            _timer.Elapsed += timer_Elapsed;
            _isEnabled = (initData.isServer || initData.runType == InitialData.RunType.Local);
            _timer.Start();
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!_isEnabled) return;

            ProcessTiming();

            if (SendData != null)
            {
                EventHandler<MatchData> handler = SendData;
                handler(this, _data);
            }
            // Forget the sound we just played (if any)
            _data.soundPackage = null;
        }

        public void ResetMatch()
        {
            _data.matchStatus = MatchData.MatchStatus.Stopped;
            _data.matchPeriod = MatchData.MatchPeriods.NotStarted;
            _data.timerValue = MatchTimingData.matchLength;
            _data.noCrossActive = false;
        }

        public void StartTimeout(TimeoutData data)
        {
            _data.timeoutMessage = data.message;
            if (_data.matchStatus == MatchData.MatchStatus.Timeout)
            {
                _data.timerValue = _data.timerValue.Add(data.value);
            }
            else
            {
                _data.timerValue = data.value;
            }
            this._timeoutSounds = data.soundType;
            _data.matchStatus = MatchData.MatchStatus.Timeout;
        }

        public void MatchPower(bool running)
        {
            if (running)
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
            }
            else if(_data.matchStatus == MatchData.MatchStatus.Running)
            {
                _data.matchStatus = MatchData.MatchStatus.Paused;
            }
            else if (_data.matchStatus == MatchData.MatchStatus.Paused)
            {
                _data.matchStatus = MatchData.MatchStatus.Stopped;
            }
        }

        private void ProcessTiming()
        {
            if (_data.matchStatus == MatchData.MatchStatus.Running)
            {
                TimeSpan ts = _data.timerValue.Subtract(new TimeSpan(0, 0, 1));
                _data.timerValue = ts;
                if (ts.TotalSeconds == MatchTimingData.whenNoCrossEnd.TotalSeconds)
                {
                    // Special case for No Cross Alert
                    _data.noCrossActive = false;
                    _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "factwhistle");
                }
                else if (ts.TotalSeconds == MatchTimingData.whenAutoEnd.TotalSeconds)
                {
                    // Auto hads ended.
                    _data.matchStatus = MatchData.MatchStatus.Paused;
                    _data.matchPeriod = MatchData.MatchPeriods.DriverControlled;
                    _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "endauto");
                }
                else if (ts.TotalSeconds == MatchTimingData.whenEndgameStart.TotalSeconds)
                {
                    // Entering Endgame
                    _data.matchPeriod = MatchData.MatchPeriods.EndGame;
                    _data.soundPackage = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, "factwhistle");
                }
                else if (ts.TotalSeconds <= 0)
                {
                    // Match is over
                    _data.timerValue = new TimeSpan();
                    _data.matchPeriod = MatchData.MatchPeriods.Complete;
                    _data.matchStatus = MatchData.MatchStatus.Stopped;
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
                    _data.matchStatus = MatchData.MatchStatus.Stopped;
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
            // Update the display object
            this.fieldDisplayObj.UpdateDisplay(_data, this.isSelected);
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
