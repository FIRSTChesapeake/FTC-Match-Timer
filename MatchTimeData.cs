using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display
{
    public static class MatchTimeData
    {
        private static readonly TimeSpan _defaultMatch = new TimeSpan(0, 0, 30);
        private static readonly TimeSpan _defaultAuto = new TimeSpan(0, 0, 10);
        private static readonly TimeSpan _defaultNoCross = new TimeSpan(0, 0, 5);
        private static readonly TimeSpan _defaultEndgame = new TimeSpan(0, 0, 10);
        /*
        private static readonly TimeSpan _defaultMatch = new TimeSpan(0, 2, 30);
        private static readonly TimeSpan _defaultAuto = new TimeSpan(0, 0, 30);
        private static readonly TimeSpan _defaultNoCross = new TimeSpan(0, 0, 10);
        private static readonly TimeSpan _defaultEndgame = new TimeSpan(0, 0, 30);
        */
        public static TimeSpan matchLength { get; set; }
        public static TimeSpan autoLength { get; set; }
        public static TimeSpan nocrossLength { get; set; }
        public static TimeSpan endgameLength { get; set; }

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

        static MatchTimeData()
        {
            SetDefaults();
        }

        public static void SetDefaults()
        {
            matchLength = _defaultMatch;
            autoLength = _defaultAuto;
            nocrossLength = _defaultNoCross;
            endgameLength = _defaultEndgame;
        }
    }
}
