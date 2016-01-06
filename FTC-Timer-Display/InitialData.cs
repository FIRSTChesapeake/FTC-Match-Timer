using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display
{
    [Serializable]
    public class InitialData
    {
        private int _divID = 1;
        public bool isMultiDivision = true;
        public string divName = "";
        public int fieldID = 0;
        //public int fieldCount = 0;  - Might use this later
        public RunType runType = RunType.None;
        public MatchData.EventTypes eventType = MatchData.EventTypes.Qualifier;
        public int scoringPort = Properties.Settings.Default.DefaultScoringPort;
        public bool loadPreviousFields = true;

        public int divID
        {
            set { _divID = value; }
            get
            {
                if (isMultiDivision) return _divID;
                else return 0;
            }
        }

        public enum RunType
        {
            None = 0,
            ServerClient = 1,
            Server = 2,
            Client = 3,
            Local = 4,
            PitDisplay = 5
        }

        public string runTypeString
        {
            get
            {
                return GetRunTypeString(runType);
            }
        }

        public void SaveSettings()
        {
            // Save Mode
            Properties.Settings.Default.LastMode = (int)this.runType;
            // Save Division
            Properties.Settings.Default.LastDivision = this.divID;
            // Save whether we're multi-divisional
            Properties.Settings.Default.isMultiDivision = this.isMultiDivision;
            // Save Division Name
            Properties.Settings.Default.LastDivisionName = this.divName;
            // Save field number
            Properties.Settings.Default.LastFieldID = this.fieldID;
            // Save Event Type
            Properties.Settings.Default.eventType = (int)this.eventType;
            // Save
            Properties.Settings.Default.Save();
        }

        public static string GetRunTypeString(RunType type)
        {
            string s = "";
            switch (type)
            {
                case RunType.ServerClient: s = "Server && Client Timer"; break;
                case RunType.Server: s = "Server Only"; break;
                case RunType.Client: s = "Client Timer"; break;
                default: s = type.ToString(); break;
            }
            // Show the number? Nah.
            //return string.Format("{0}) {1}", (int)runType, s);
            return s;
        }

        public static InitialData LoadAppSettings(out int errorID)
        {
            InitialData i = new InitialData();
            // If the runTime saved isn't None than try to load all the settings.
            RunType runType = (RunType)Properties.Settings.Default.LastMode;
            if (runType != RunType.None)
            {
                i.runType = (RunType)Properties.Settings.Default.LastMode;
                i.divID = Properties.Settings.Default.LastDivision;
                i.divName = Properties.Settings.Default.LastDivisionName;
                i.fieldID = Properties.Settings.Default.LastFieldID;
                i.isMultiDivision = Properties.Settings.Default.isMultiDivision;
                i.eventType = (MatchData.EventTypes)Properties.Settings.Default.eventType;
            }

            i = startWizard(i, out errorID);

            if (i == null || i.runType == RunType.None) return null;
            errorID = 0;
            return i;
        }

        public static InitialData startWizard(InitialData template, out int errorID)
        {
            frmInitialSetup wnd = new frmInitialSetup(template);
            wnd.ShowDialog();
            if (wnd.Tag == null)
            {
                errorID = 1;
                return null;
            }
            InitialData data = (InitialData)wnd.Tag;
            if (data.runType == InitialData.RunType.None)
            {
                errorID = -1;
                return null;
            }
            errorID = 0;
            return data;
        }

        // Slated for Demolition
        [Obsolete("Method is Obsolete. use startWizard Method Instead.")]
        public static InitialData GetInitialData(InitialData template, out int errorID)
        {
            frmModeSelection wnd = new frmModeSelection(template);
            wnd.ShowDialog();
            if (wnd.Tag == null)
            {
                errorID = 1;
                return null;
            }
            InitialData data = (InitialData)wnd.Tag;
            if (data.runType == InitialData.RunType.None)
            {
                errorID = -1;
                return template;
            }
            errorID = 0;
            return data;
        }

        public bool isForMe(MatchData data)
        {
            if (this.divID != data.divID) return false;
            if (this.fieldID != data.fieldID) return false;
            return true;
        }
        public bool isServer
        {
            get
            {
                if (runType == RunType.Server) return true;
                if (runType == RunType.ServerClient) return true;
                return false;
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is a client.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is client; otherwise, <c>false</c>.
        /// </value>
        public bool isClient
        {
            get
            {
                if (runType == RunType.ServerClient) return true;
                if (runType == RunType.Client) return true;
                return false;
            }
        }
        public bool hasLocalClock
        {
            get
            {
                if (isClient) return true;
                if (runType == RunType.Local) return true;
                return false;
            }
        }
        public void lockMutex()
        {
            FtcMutex.lockRunType(this.runType);
        }
    }
}
