using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public partial class CtrlSoundTest : UserControl
    {
        public CtrlSoundTest()
        {
            InitializeComponent();
        }

        public void LoadSounds()
        {
            flowSounds.Controls.Clear();
            List<ButtonX> btns = new List<ButtonX>();
            int pixPerLetter = (int)ButtonX.DefaultFont.Size + 1;
            int btnWidth = 50;
            foreach (string s in SoundGenerator.availableSounds)
            {
                ButtonX b = new ButtonX();
                b.Text = s.ToUpper();
                b.Tag = s;
                int width = s.ToCharArray().Length * pixPerLetter;
                if (width > btnWidth) btnWidth = width;
                b.Click += HandlePreRecordedSoundsButtons;
                btns.Add(b);
            }
            Size btnSize = new Size(btnWidth, 35);
            foreach (ButtonX b in btns)
            {
                b.Size = btnSize;
                flowSounds.Controls.Add(b);
            }
            // Load the current Voice Synth Vol/Rate
            slideVoiceRate.Value = SoundGenerator.voiceOutputRate;
            slideVoiceVolume.Value = SoundGenerator.voiceOutputVolume;
        }

        private void HandlePreRecordedSoundsButtons(object sender, EventArgs e)
        {
            if (sender.Equals(btnStopPregen) || sender.Equals(btnStopVoice))
            {
                SoundGenerator.StopAll();
            }
            else if (sender.Equals(btnSpeak))
            {
                if (txtSpeak.Text == "") return;
                SoundGenerator.SoundPackage package = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.TextToSpeech, txtSpeak.Text);
                SoundGenerator.PlaySound(package);
            }
            else
            {
                ButtonX b = (ButtonX)sender;
                string snd = (string)b.Tag;
                if (snd == null || snd == "") return;
                SoundGenerator.SoundPackage package = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.SoundFile, snd);
                package.loop = swLoop.Value;
                SoundGenerator.PlaySound(package);
            }
        }

        private void frmSoundTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundGenerator.StopAll();
        }

        private void frmSoundTest_Load(object sender, EventArgs e)
        {
            if (SoundGenerator.availableSounds.Count == 0) tableSounds.Enabled = false;
            if (!SoundGenerator.voiceReady) tableVoice.Enabled = false;
        }

        private void sliderChangeHandler(object sender, EventArgs e)
        {

            SoundGenerator.voiceOutputRate = slideVoiceRate.Value;
            SoundGenerator.voiceOutputVolume = slideVoiceVolume.Value;
        }
    }
}