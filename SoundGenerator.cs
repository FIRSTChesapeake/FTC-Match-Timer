using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Diagnostics;

namespace FTC_Timer_Display
{
    public static class SoundGenerator
    {
        public static readonly string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string SoundsFolder = String.Format(@"{0}\{1}", AppPath, "Sounds");

        private static Dictionary<string, SoundPlayer> sounds = new Dictionary<string, SoundPlayer>();

        public static bool isMuted { get; set; }

        public static bool isInit { get; private set; }

        public static void init()
        {
            try
            {
                string[] files = Directory.GetFiles(SoundsFolder);
                foreach (string s in files)
                {
                    string key = (Path.GetFileName(s).Split('.'))[0].ToLower();
                    SoundPlayer player = new SoundPlayer(s);
                    player.Tag = key;
                    player.LoadCompleted += SoundLoadCompleteCallback;
                    player.LoadAsync();
                    sounds.Add(key, player);
                }
            }
            catch { }
            isInit = true;
        }

        public static void StopAll()
        {
            try
            {
                foreach (SoundPlayer player in sounds.Values) player.Stop();
            }
            catch { }
        }

        private static void SoundLoadCompleteCallback(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            SoundPlayer player = (SoundPlayer)sender;
            string file = player.Tag == null ? "UNKNOWN" : player.Tag.ToString();
            string msg = string.Format("Load of sound {0} complete.", file);
            Debug.WriteLine(msg);
        }

        public static void PlaySound(string name)
        {
            try
            {
                if (isMuted) return;
                if (!isInit) throw new Exception("Sound Generation not initialized before call. This should never happen. I hope.");
                name = name.ToLower();
                if (sounds.ContainsKey(name))
                {
                    sounds[name].Play();
                }
            }
            catch { }
        }
    }
}
