using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public partial class ClockFace : UserControl
    {
        System.Timers.Timer timer = new System.Timers.Timer();

        public bool blink { get; set; }

        private bool _blinkFlag = true;

        private TimeSpan val = new TimeSpan();

        public FaceColor faceColor = FaceColor.Red;

        public enum FaceColor
        {
            Red,
            Green
        }

        public ClockFace()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Elapsed += peroidicTick;
            timer.Start();
        }

        public TimeSpan Value
        {
            get { return val; }
            set
            {
                val = new TimeSpan(0, Math.Min(value.Minutes, 9), value.Seconds);
                setDisplay();
            }
        }

        private void setDisplay()
        {
            // Fill the labels
            setDigit(ref digitMin, val.Minutes);
            if (val.Seconds < 10)
            {
                setDigit(ref digitSec1, 0);
                setDigit(ref digitSec2, val.Seconds);
            }
            else
            {
                int ones = val.Seconds % 10;
                int tens = (val.Seconds - ones) / 10;
                setDigit(ref digitSec1, tens);
                setDigit(ref digitSec2, ones);
            }
        }

        private void clearDisplay()
        {
            setDigit(ref digitMin, -1);
            setDigit(ref digitSec1, -1);
            setDigit(ref digitSec2, -1);
            imgColon.Image = getColon(false);
        }

        private void peroidicTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => peroidicTick(sender, e)));
            }
            else
            {
                _blinkFlag = !_blinkFlag;
                if (blink) imgColon.Image = getColon(_blinkFlag);
                else imgColon.Image = getColon(true);
            }
        }

        private void ClockFace_Resize(object sender, EventArgs e)
        {
            
        }

        private Image getColon(bool on)
        {
            switch (faceColor)
            {
                case FaceColor.Green:
                    if(on) return Properties.Resources.Gcolon;
                    return Properties.Resources.Gcolonoff;
                default:
                    if (on) return Properties.Resources.Rcolon;
                    return Properties.Resources.Rcolonoff;
            }
        }

        private void setDigit(ref PictureBox pic, int value)
        {
            Image i = null;
            switch (faceColor)
            {
                case FaceColor.Green:
                    switch (value)
                    {
                        case 0: i = Properties.Resources.G0; break;
                        case 1: i = Properties.Resources.G1; break;
                        case 2: i = Properties.Resources.G2; break;
                        case 3: i = Properties.Resources.G3; break;
                        case 4: i = Properties.Resources.G4; break;
                        case 5: i = Properties.Resources.G5; break;
                        case 6: i = Properties.Resources.G6; break;
                        case 7: i = Properties.Resources.G7; break;
                        case 8: i = Properties.Resources.G8; break;
                        case 9: i = Properties.Resources.G9; break;
                        default: i = Properties.Resources.Rdigitoff; break;
                    }
                    break;
                default:
                    switch (value)
                    {
                        case 0: i = Properties.Resources.R0; break;
                        case 1: i = Properties.Resources.R1; break;
                        case 2: i = Properties.Resources.R2; break;
                        case 3: i = Properties.Resources.R3; break;
                        case 4: i = Properties.Resources.R4; break;
                        case 5: i = Properties.Resources.R5; break;
                        case 6: i = Properties.Resources.R6; break;
                        case 7: i = Properties.Resources.R7; break;
                        case 8: i = Properties.Resources.R8; break;
                        case 9: i = Properties.Resources.R9; break;
                        default: i = Properties.Resources.Rdigitoff; break;
                    }
                    break;
            }
            pic.Image = i;
        }
    }
}
