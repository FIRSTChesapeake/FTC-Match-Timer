using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display
{
    public class InitialData
    {
        public int divID = 0;
        public string divName = "";
        public int fieldID = 0;
        public RunType runType = RunType.None;

        public enum RunType
        {
            None,
            Server,
            ServerClient,
            Client,
            Local
        }

        public bool isForMe(MatchData data)
        {
            if (this.divID != data.divID) return false;
            if (this.fieldID != data.fieldID) return false;
            return true;
        }
    }
}
