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
        public string division = "";
        public string fieldList = "";
        public string allianceTimeouts = "false";

        public AndroidStatusReply(MatchData data)
        {
            if (data.divID == 0)
            {
                this.division = data.divisionName;
            }
            else if (data.divisionName == "")
            {
                this.division = data.divID.ToString();
            }
            else
            {
                this.division = string.Format("{0} ({1})", data.divisionName, data.divID);
            }
            this.field = data.fieldID.ToString();
            this.status = data.matchStatus.ToString();
            this.match = string.Format("{0}{1}", data.matchTypeShort, data.matchNumberString);
            this.period = data.matchPeriod.ToString();
            this.isMatchRunning = data.isMatchActive.ToString().ToLower();
            this.isTimerRunning = data.isTimerRunning.ToString().ToLower();
            this.isReadyForStart = data.isWaitingForStart.ToString().ToLower();
            this.allianceTimeouts = MatchTimingData.matchTypeAllowsTimeout(data.matchType).ToString().ToLower();
            this.timer = data.timerValue.ToString();
        }

        public static string makeJson(AndroidStatusReply statusObj, List<int> allFields, string replyStr)
        {
            statusObj.cmdReply = replyStr;
            statusObj.fieldList = MakeFieldList(allFields);
            return JsonConvert.SerializeObject(statusObj);
        }

        private static string MakeFieldList(List<int> list)
        {
            if (list.Count == 0) return "";
            if (list.Count == 1) return list[0].ToString();
            bool first = true;
            StringBuilder sb = new StringBuilder();
            foreach (int i in list)
            {
                if (!first) sb.Append(",");
                first = false;
                sb.Append(i.ToString());
            }
            return sb.ToString();
        }
    }
}
