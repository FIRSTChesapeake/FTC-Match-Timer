using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display.AndroidComponents
{
    public class AndroidCommandPackage
    {
        public AndroidCommandPackage(string value, string user, object args = null)
        {
            switch (value.ToLower())
            {
                case "start":
                    this.cmd = AndroidCommand.Start;
                    break;
                case "pause":
                    this.cmd = AndroidCommand.Pause;
                    break;
                case "stop":
                case "abort":
                    this.cmd = AndroidCommand.Stop;
                    break;
                case "advance":
                    this.cmd = AndroidCommand.Advance;
                    break;
                case "reset":
                    this.cmd = AndroidCommand.Reset;
                    break;
                case "fieldprev":
                    this.cmd = AndroidCommand.ChangeField;
                    this.isAdvancedCommand = true;
                    this.internalArgs = false;
                    break;
                case "fieldnext":
                    this.cmd = AndroidCommand.ChangeField;
                    this.isAdvancedCommand = true;
                    this.internalArgs = true;
                    break;
                case "matchprev":
                    this.cmd = AndroidCommand.ChangeMatch;
                    this.isAdvancedCommand = true;
                    this.internalArgs = false;
                    break;
                case "matchnext":
                    this.cmd = AndroidCommand.ChangeMatch;
                    this.isAdvancedCommand = true;
                    this.internalArgs = true;
                    break;
                case "timeout":
                    this.cmd = AndroidCommand.Timeout;
                    this.isAdvancedCommand = true;
                    break;
            }
            this.CompleteConstruction(user, args);
        }



        private void CompleteConstruction(string user, object args)
        {
            this.username = user;
            this.cmdArgs = args;
        }

        public enum AndroidCommand
        {
            None,
            Start,
            Pause,
            Stop,
            Advance,
            Reset,
            ChangeField,
            ChangeMatch,
            Timeout
        }
        public AndroidCommand cmd = AndroidCommand.None;
        public object cmdArgs = null;
        public object internalArgs = null;
        public string username = "";
        public bool isAdvancedCommand = false;
    }
}
