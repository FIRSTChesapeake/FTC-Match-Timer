using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Diagnostics;

namespace FTC_Timer_Display
{
    public static class MatchScheduleManager
    {
        private static myUdpClient.UdpComms comms;
        private static bool _isInit = false;

        static MatchScheduleManager()
        {

        }

        public static void init(int scoringPort)
        {
            if (_isInit) return;
            comms = new myUdpClient.UdpComms(scoringPort, NewScoreDataHandler);

            _isInit = true;
        }

        private static void NewScoreDataHandler(object sender, ScoringData data)
        {

        }
    }
}
