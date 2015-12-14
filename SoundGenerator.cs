using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Diagnostics;
using System.Speech;
using System.Speech.Synthesis;

namespace FTC_Timer_Display
{
    public static class SoundGenerator
    {
        // Sound player settings & objects
        public static readonly string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string SoundsFolder = String.Format(@"{0}\{1}", AppPath, "Sounds");
        private static Dictionary<string, SoundPlayer> sounds = new Dictionary<string, SoundPlayer>();

        public static List<string> availableSounds
        {
            get
            {
                return sounds.Keys.ToList<string>();
            }
        }

        // Synth Settings & Objects
        private static SpeechSynthesizer voice;
        public static int voiceOutputVolume
        {
            get { return voice == null ? 0 : voice.Volume; }
            set { if (voice != null) voice.Volume = Math.Min(100, Math.Max(0, value)); }
        }
        public static int voiceOutputRate
        {
            get { return voice == null ? 0 : voice.Rate; }
            set { if(voice != null) voice.Rate = Math.Min(10, Math.Max(-10, value)); }
        }
        // Shared
        public static bool isMuted { get; set; }

        public static bool isInit { get; private set; }
        public static bool voiceReady { get { return voice != null; } }

        public static void init()
        {
            try
            {
                // Sound files
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
            try
            {
                // Synth
                voice = new SpeechSynthesizer();
                voice.Volume = 100;
            }
            catch { }
            isInit = true;
        }

        public static void StopAll()
        {
            try
            {
                foreach (SoundPlayer player in sounds.Values) player.Stop();
                voice.SpeakAsyncCancelAll();
            }
            catch { }
        }

        public static void PlaySound(SoundPackage package)
        {
            switch (package.soundMethod)
            {
                case SoundPackage.SoundMethods.SoundFile:
                    PlaySoundFile(package.dataString, package.loop);
                    break;
                case SoundPackage.SoundMethods.FileToSpeech:
                    ReadFile(package.dataString);
                    break;
                case SoundPackage.SoundMethods.TextToSpeech:
                    Speak(package.dataString);
                    break;
            }
        }
        // Sounce player functions
        private static void SoundLoadCompleteCallback(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            SoundPlayer player = (SoundPlayer)sender;
            string file = player.Tag == null ? "UNKNOWN" : player.Tag.ToString();
            string msg = string.Format("Load of sound {0} complete.", file);
            Debug.WriteLine(msg);
        }

        private static void PlaySoundFile(string name, bool loop)
        {
            try
            {
                if (isMuted) return;
                if (!isInit) throw new Exception("Sound Generation not initialized before call. This should never happen. I hope.");
                name = name.ToLower();
                if (sounds.ContainsKey(name))
                {
                    if (!loop) sounds[name].Play();
                    else sounds[name].PlayLooping();
                }
            }
            catch { }
        }
        // Voice Synth Functions
        private static void Speak(string s)
        {
            if (voice == null) return;
            if (!isMuted) voice.SpeakAsync(s);
        }

        private static bool ReadFile(string path)
        {
            if (voice == null) return false;
            try
            {
                if (isMuted) return true;
                string s = File.ReadAllText(path);
                Speak(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [Serializable]
        public class SoundPackage
        {
            public string dataString { get; private set; }
            public SoundMethods soundMethod { get; private set; }
            public bool loop = false;

            public SoundPackage(SoundMethods method, string str)
            {
                dataString = str;
                soundMethod = method;
            }

            public enum SoundMethods
            {
                SoundFile,
                FileToSpeech,
                TextToSpeech
            }
        }
    }
}
