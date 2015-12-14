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
    public partial class frmSoundTest : DevComponents.DotNetBar.OfficeForm
    {
        public frmSoundTest()
        {
            InitializeComponent();
            // Make sure all sound buttons fit in the window.
            int otherHeight = this.Size.Height - flowSounds.Size.Height + 10;
            int btnHeight = 35;
            Size z = new Size((flowSounds.Width / 2) - 10, btnHeight);
            foreach (string s in SoundGenerator.availableSounds)
            {
                ButtonX b = new ButtonX();
                b.Text = s.ToUpper();
                b.Tag = s;
                b.Size = z;
                b.Click += HandlePreRecordedSoundsButtons;
                flowSounds.Controls.Add(b);
            }
            int cnt = flowSounds.Controls.Count;
            int rows = (cnt % 2 == 0) ? cnt / 2 : (cnt + 1) / 2;
            int newHeight = otherHeight + (rows * btnHeight) + (rows * 3);      // control margin defaults @ 3.
            if(newHeight > this.Size.Height) this.Size = new Size(this.Size.Width, newHeight);

            // Load the current Voice Synth Vol/Rate
            knobRate.Value = SoundGenerator.voiceOutputRate;
            knobVolume.Value = SoundGenerator.voiceOutputVolume;
        }

        private void HandlePreRecordedSoundsButtons(object sender, EventArgs e)
        {
            if (sender.Equals(btnStopAll))
            {
                SoundGenerator.StopAll();
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

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (txtSpeak.Text == "") return;
            SoundGenerator.SoundPackage package = new SoundGenerator.SoundPackage(SoundGenerator.SoundPackage.SoundMethods.TextToSpeech, txtSpeak.Text);
            SoundGenerator.PlaySound(package);
        }

        private void KnobChgHandler(object sender, DevComponents.Instrumentation.ValueChangedEventArgs e)
        {
            SoundGenerator.voiceOutputRate = (int)knobRate.Value;
            SoundGenerator.voiceOutputVolume = (int)knobVolume.Value;
        }
    }
}