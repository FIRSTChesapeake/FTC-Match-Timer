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
                    cmd = AndroidCommand.Start;
                    break;
                case "pause":
                    cmd = AndroidCommand.Pause;
                    break;
                case "advance":
                    cmd = AndroidCommand.Advance;
                    break;
                case "reset":
                    cmd = AndroidCommand.Reset;
                    break;
            }
            CompleteConstruction(user, args);
        }

        public AndroidCommandPackage(AndroidCommand value, string user, object args = null)
        {
            this.cmd = value;
            CompleteConstruction(user, args);
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
            Advance,
            Reset
        }
        public AndroidCommand cmd = AndroidCommand.None;
        public object cmdArgs = null;
        public string username = "";
    }
}
