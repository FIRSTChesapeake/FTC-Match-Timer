using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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

        public static TimeSpan driverLength
        {
            get
            {
                return matchLength - autoLength;
            }
        }

        public static TimeSpan whenAutoEnd
        {
            get
            {
                return matchLength - autoLength;
            }
        }
        public static TimeSpan whenNoCross
        {
            get
            {
                return matchLength - nocrossLength;
            }
        }
        public static TimeSpan whenEndgame
        {
            get
            {
                return endgameLength;
            }
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
