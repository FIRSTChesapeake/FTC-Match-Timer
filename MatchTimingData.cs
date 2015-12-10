using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace FTC_Timer_Display
{
    public static class MatchTimingData
    {
        /*
        private static readonly TimeSpan _defaultMatch = new TimeSpan(0, 0, 30);
        private static readonly TimeSpan _defaultAuto = new TimeSpan(0, 0, 10);
        private static readonly TimeSpan _defaultNoCross = new TimeSpan(0, 0, 5);
        private static readonly TimeSpan _defaultEndgame = new TimeSpan(0, 0, 10);
        */
        
        private static readonly TimeSpan _defaultMatch = new TimeSpan(0, 2, 30);
        private static readonly TimeSpan _defaultAuto = new TimeSpan(0, 0, 30);
        private static readonly TimeSpan _defaultNoCross = new TimeSpan(0, 0, 10);
        private static readonly TimeSpan _defaultEndgame = new TimeSpan(0, 0, 30);
        
        private static Dictionary<MatchData.MatchPeriods, Color> periodColors = new Dictionary<MatchData.MatchPeriods, Color>();

        public static TimeSpan matchLength { get; set; }
        public static TimeSpan autoLength { get; set; }
        public static TimeSpan nocrossLength { get; set; }
        public static TimeSpan endgameLength { get; set; }

        public static TimeSpan driverLength     { get { return matchLength - autoLength; } }

        public static TimeSpan whenAutoEnd      { get { return matchLength - autoLength; } }
        public static TimeSpan whenNoCrossEnd   { get { return matchLength - nocrossLength; } }
        public static TimeSpan whenEndgameStart { get { return endgameLength; } }

        public static TimeSpan periodTimeRemaining(TimeSpan matchTimeLeft, MatchData.MatchPeriods currentPeriod)
        {
            switch (currentPeriod)
            {
                case MatchData.MatchPeriods.Autonomous:
                    return matchTimeLeft - driverLength;
                case MatchData.MatchPeriods.DriverControlled:
                    return matchTimeLeft - endgameLength;
                case MatchData.MatchPeriods.EndGame:
                    return matchTimeLeft;
                default:
                    return new TimeSpan(0, 0, 0);
            }
        }

        public static int percentPeriodComplete(TimeSpan matchTimeLeft, MatchData.MatchPeriods currentPeriod)
        {
            TimeSpan periodRemain = periodTimeRemaining(matchTimeLeft, currentPeriod);
            TimeSpan periodTotal;
            switch (currentPeriod)
            {
                case MatchData.MatchPeriods.Autonomous:
                    periodTotal = autoLength;
                    break;
                case MatchData.MatchPeriods.DriverControlled:
                    periodTotal = driverLength - endgameLength;
                    break;
                case MatchData.MatchPeriods.EndGame:
                    periodTotal = endgameLength;
                    break;
                default:
                    return 100;
            }
            TimeSpan periodComplete = periodTotal - periodRemain;
            decimal p = (decimal)(periodComplete.TotalSeconds / periodTotal.TotalSeconds);
            decimal q = p * 100;
            return (int)q;
        }

        public static int percentAutoPartComplete(TimeSpan matchTimeLeft, bool noCrossActive)
        {
            TimeSpan periodRemain = periodTimeRemaining(matchTimeLeft, MatchData.MatchPeriods.Autonomous);
            decimal p = 0;
            if (noCrossActive)
            {
                // if we're in the no cross part, find the completed no cross time.
                TimeSpan t = nocrossLength - (periodRemain - (autoLength - nocrossLength));
                p = (decimal)(t.TotalSeconds / nocrossLength.TotalSeconds);
            }
            else
            {
                // if we're not in the no cross part, find the completed non-nocross part.
                TimeSpan t = (autoLength - nocrossLength) - periodRemain;
                p = (decimal)(t.TotalSeconds / (autoLength - nocrossLength).TotalSeconds);
            }
            decimal q = p * 100;
            return (int)q;
        }

        static MatchTimingData()
        {
            SetDefaults();
        }

        public static void SetDefaults()
        {
            matchLength = _defaultMatch;
            autoLength = _defaultAuto;
            nocrossLength = _defaultNoCross;
            endgameLength = _defaultEndgame;

            // Insert Default Colors
            periodColors.Add(MatchData.MatchPeriods.NotStarted, Color.Yellow);
            periodColors.Add(MatchData.MatchPeriods.Autonomous, Color.Orange);
            periodColors.Add(MatchData.MatchPeriods.DriverControlled, Color.Green);
            periodColors.Add(MatchData.MatchPeriods.EndGame, Color.OrangeRed);
            periodColors.Add(MatchData.MatchPeriods.Complete, Color.Red);
        }

        public static Color getPeriodColor(MatchData.MatchPeriods period)
        {
            if (periodColors.ContainsKey(period))
            {
                return periodColors[period];
            }
            else
            {
                return Color.Empty;
            }
        }

        public static bool editTiming()
        {
            frmTimings wind = new frmTimings();
            wind.ShowDialog();
            if (wind.Tag == null) return false;
            return true;
        }
    }
}
