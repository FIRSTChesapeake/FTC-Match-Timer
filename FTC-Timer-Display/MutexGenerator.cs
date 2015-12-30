using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace nsdSystems
{
    public static class MutexGenerator
    {

        private static Mutex _mute;
        public static Mutex mute { get { return _mute; } }
        private static MutexSecurity muteSec = new MutexSecurity();
        private static bool _isUnique = false;

        public static string lastMuteError { get; private set; }

        static MutexGenerator()
        {
            Application.ApplicationExit += ApplicationExit;
        }

        private static void ApplicationExit(object sender, EventArgs e)
        {
            releaseMute();
        }

        public static bool isUnique
        {
            get
            {
                if (_mute == null) return false;
                return _isUnique;
            }
        }
        /// <summary>
        /// Creates the mute.
        /// </summary>
        /// <param name="muteName">Name of the mute.</param>
        /// <returns>Whether it is unique</returns>
        public static bool CreateMute(string muteName)
        {
            try
            {
                if (_mute != null) return false;
                bool unique = true;
                _mute = produceMute(muteName, out unique);
                _isUnique = unique;
                return unique;
            }
            catch (Exception ex)
            {
                lastMuteError = ex.Message;
                return false;
            }
        }
        /// <summary>
        /// Releases the mute.
        /// </summary>
        public static bool releaseMute()
        {
            try
            {
                if (_mute == null) return true;
                _mute.ReleaseMutex();
                _mute.Close();
                _mute = null;
                return true;
            }
            catch (Exception ex)
            {
                lastMuteError = ex.Message;
                return false;
            }
        }




        /// <summary>
        /// Checks for mute without remembering or holding it open.
        /// </summary>
        /// <param name="muteName">Name of the mute.</param>
        /// <returns>Whether the mute exists</returns>
        public static bool checkForMute(string muteName)
        {
            Mutex tempMute;
            bool exists = Mutex.TryOpenExisting(muteName, MutexRights.ReadPermissions, out tempMute);
            tempMute = null;
            return exists;
        }

        private static Mutex produceMute(string muteName, out bool isUnique)
        {
            muteSec.AddAccessRule(new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow));
            return new Mutex(true, @"Global\" + muteName, out isUnique);
        }
    }
}