using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display
{
    [Serializable]
    public class MatchData
    {
        public int divID = 0;
        public int fieldID = 0;
        public string divisionName = "";
        public MatchTypes matchType = MatchTypes.Unknown;
        public MatchPeriods matchPeriod = MatchPeriods.NotStarted;
        public MatchStatus matchStatus = MatchStatus.Stopped;
        public int matchNumberMajor = 1;
        public int matchNumberMinor = 0;

        public string playSound = "";

        public TimeSpan timerValue = new TimeSpan();

        public bool isDivisions
        {
            get
            {
                if (divID == 0) return false;
                return true;
            }
        }



        public MatchData() { }

        public MatchData(int div, string divName, int field)
        {
            divID = div;
            fieldID = field;
            divisionName = divName;
        }

        public void SetMatchTimer(MatchTypes type, int major, int minor, TimeSpan timer, MatchPeriods period, MatchStatus status)
        {
            this.matchType = type;
            this.matchNumberMajor = major;
            this.matchNumberMinor = minor;
            this.timerValue = timer;
            this.matchPeriod = period;
            this.matchStatus = status;
        }

        public enum MatchTypes
        {
            Unknown,
            Practice,
            Qualification,
            Quarterfinals,
            Semifinals,
            Finals
        }
        public enum MatchPeriods
        {
            NotStarted,
            Autonomous,
            DriverControlled,
            EndGame,
            Complete
        }
        public enum MatchStatus
        {
            Stopped,
            Running,
            Paused
        }

        public bool usesMinor
        {
            get
            {
                return TypeUsesMinor(this.matchType);
            }
        }

        public static bool TypeUsesMinor(MatchTypes type)
        {
            if (type == MatchTypes.Quarterfinals) return true;
            if (type == MatchTypes.Semifinals) return true;
            return false;
        }

        public string matchHeaderString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (this.isDivisions)
                {
                    if (this.divisionName != "")
                    {
                        sb.Append(this.divisionName);
                        sb.Append(" Division ");
                    }
                    else
                    {
                        sb.Append("Division ");
                        sb.Append(this.divID);
                        sb.Append(" ");
                    }
                }
                sb.Append("Field ");
                sb.Append(this.fieldID);
                sb.Append(Environment.NewLine);
                sb.Append(this.matchType);
                sb.Append(" Match ");
                sb.Append(this.matchNumberMajor);
                if (this.matchNumberMinor != 0)
                {
                    sb.Append("-");
                    sb.Append(this.matchNumberMinor);
                }
                return sb.ToString();
            }
        }

        public string matchFooterString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                switch (this.matchPeriod)
                {
                    case MatchPeriods.NotStarted: sb.Append("Not Started"); break;
                    case MatchPeriods.DriverControlled: sb.Append("Driver Controlled"); break;
                    case MatchPeriods.EndGame: sb.Append("End Game"); break;
                    default: sb.Append(this.matchPeriod.ToString()); break;
                }
                if (activePeriod) sb.Append(" Period");
                sb.Append(Environment.NewLine);
                sb.Append(this.matchStatus);
                return sb.ToString();
            }
        }

        public bool waitingForStart
        {
            get
            {
                if (this.matchStatus == MatchStatus.Paused) return true;
                if (this.matchStatus == MatchStatus.Stopped && this.matchPeriod == MatchPeriods.NotStarted) return true;
                return false;
            }
        }

        public bool activeMatch
        {
            get
            {
                if (this.matchStatus == MatchStatus.Stopped) return false;
                return true;
            }
        }

        public bool activePeriod
        {
            get
            {
                switch (this.matchPeriod)
                {
                    case MatchPeriods.Complete: return false;
                    case MatchPeriods.NotStarted: return false;
                    default: return true;
                }
            }
        }
    }
}
