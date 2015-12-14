﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display
{
    public class InitialData
    {
        public int divID = 1;
        public string divName = "";
        public int fieldID = 0;
        public RunType runType = RunType.None;
        public int scoringPort = Properties.Settings.Default.DefaultScoringPort;
        public bool loadPreviousFields = true;

        public enum RunType
        {
            None = 0,
            Server = 1,
            ServerClient = 2,
            Client = 3,
            Local = 4,
            PitDisplay =5
        }

        public void SaveSettings()
        {
            // Save Mode
            Properties.Settings.Default.LastMode = (int)this.runType;
            // Save Division
            Properties.Settings.Default.LastDivision = this.divID;
            // Save Division Name
            Properties.Settings.Default.LastDivisionName = this.divName;
            // Save field number
            Properties.Settings.Default.LastFieldID = this.fieldID;
            // Save
            Properties.Settings.Default.Save();
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
            }

            i = GetInitialData(i, out errorID);

            if (i == null || i.runType == RunType.None) return null;
            errorID = 0;
            return i;
        }

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

        public void lockMutex()
        {
            FtcMutex.lockRunType(this.runType);
        }
    }
}
