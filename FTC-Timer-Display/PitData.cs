using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display
{
    [Serializable]
    public class PitData
    {
        public List<MatchData> fieldData = new List<MatchData>();

        public static bool sendClearData = false;
        public bool clearData = false;

        public PitDataSelections pitDataSelection = PitDataSelections.Off;
        public int activeField = 1;
        public string scoringAddress = "";
        public int scrollSpeed = 10;

        public int divID { get; private set; }

        public PitData() { }
        public PitData(MatchData data)
        {
            divID = data.divID;
            fieldData.Add(data);
        }
        public PitData(List<MatchData> dataList)
        {
            divID = dataList[0].divID;
            this.fieldData = dataList;
        }

        public enum PitDataSelections
        {
            Off,
            ActiveOnly,
            AllFields
        }
    }
}
