using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display
{
    public class SingleClient
    {
        private System.Timers.Timer _timer = new System.Timers.Timer();
        private MatchData _data;
        private bool _isEnabled = true;

        public MatchData matchData { get { return _data; } set { _data = value; } }

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
                return String.Format("Division {0} Field {1}", _data.divID, _data.fieldID);
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

        public SingleClient(int div, string divName, int field, EventHandler<MatchData> SendDataHandler, bool timerStart)
        {
            SendData += SendDataHandler;

            _data = new MatchData(div, divName, field);
            ResetMatch();
            _timer.Interval = 1000;
            _timer.Elapsed += timer_Elapsed;
            _isEnabled = timerStart;
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
            _data.playSound = "";
        }

        public void ResetMatch()
        {
            _data.matchStatus = MatchData.MatchStatus.Stopped;
            _data.matchPeriod = MatchData.MatchPeriods.NotStarted;
            _data.timerValue = MatchTimingData.matchLength;
        }

        public void MatchPower(bool running)
        {
            if (running)
            {
                if (_data.matchPeriod == MatchData.MatchPeriods.NotStarted)
                {
                    _data.matchPeriod = MatchData.MatchPeriods.Autonomous;
                    _data.matchStatus = MatchData.MatchStatus.Running;
                    _data.playSound = "charge";
                }
                else if (_data.matchPeriod == MatchData.MatchPeriods.DriverControlled)
                {
                    _data.playSound = "firebell";
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
                if (ts.TotalSeconds == MatchTimingData.whenNoCross.TotalSeconds)
                {
                    // Special case for No Cross Alert
                    _data.playSound = "factwhistle";
                }
                else if (ts.TotalSeconds == MatchTimingData.whenAutoEnd.TotalSeconds)
                {
                    // Auto hads ended.
                    TimeSpan driverOnly = MatchTimingData.driverLength - MatchTimingData.endgameLength;
                    _data.matchStatus = MatchData.MatchStatus.Paused;
                    _data.matchPeriod = MatchData.MatchPeriods.DriverControlled;
                    _data.playSound = "endauto";
                }
                else if (ts.TotalSeconds == MatchTimingData.whenEndgame.TotalSeconds)
                {
                    // Entering Endgame
                    _data.matchPeriod = MatchData.MatchPeriods.EndGame;
                    _data.playSound = "factwhistle";
                }
                else if (ts.TotalSeconds == 0)
                {
                    // Match is over
                    _data.matchPeriod = MatchData.MatchPeriods.Complete;
                    _data.matchStatus = MatchData.MatchStatus.Stopped;
                    _data.playSound = "endmatch";
                }
            }
        }
    }
}
