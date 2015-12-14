using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nsdSystems;

namespace FTC_Timer_Display
{
    public static class FtcMutex
    {
        private const string MutexPrefix = @"Global\FTC-TIMER-";

        private static string makeMuteStr(InitialData.RunType runType)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(MutexPrefix);
            switch (runType)
            {
                case InitialData.RunType.ServerClient:
                case InitialData.RunType.Server:
                    sb.Append("SERVER");
                    break;
                case InitialData.RunType.Client:
                case InitialData.RunType.Local:
                    sb.Append("CLIENT");
                    break;
                case InitialData.RunType.PitDisplay:
                    sb.Append("PIT");
                    break;
                default:
                    return "";
            }
            return sb.ToString();

        }

        public static bool checkRunTypeAvailable(InitialData.RunType runType)
        {
            string str = makeMuteStr(runType);
            if(str == "") return true;
            return !MutexGenerator.checkForMute(str);
        }

        public static bool lockRunType(InitialData.RunType runType)
        {
            string str = makeMuteStr(runType);
            if (str == "") return true;
            return MutexGenerator.CreateMute(str);
        }
    }
}
