using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FTC_Timer_Display.AndroidComponents
{
    public class AndroidStatusReply
    {
        public string field = "";
        public string status = "";
        public string match = "";
        public string isMatchRunning = "";
        public string isTimerRunning = "";
        public string isReadyForStart = "";
        public string cmdReply = "";
        public string period = "";
        public string timer = "";

        public AndroidStatusReply(MatchData data)
        {
            this.field = data.fieldID.ToString();
            this.status = data.matchStatus.ToString();
            this.match = string.Format("{0}{1}", data.matchTypeShort, data.matchNumberString);
            this.period = data.matchPeriod.ToString();
            this.isMatchRunning = data.isMatchActive.ToString().ToLower();
            this.isTimerRunning = data.isTimerRunning.ToString().ToLower();
            this.isReadyForStart = data.isWaitingForStart.ToString().ToLower();
            this.timer = data.timerValue.ToString();
        }

        public static string makeJson(AndroidStatusReply statusObj, string replyStr)
        {
            statusObj.cmdReply = replyStr;
            return JsonConvert.SerializeObject(statusObj);
        }
    }
}
