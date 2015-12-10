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

        public DigitSets digitSet = DigitSets.DigitSetJ;

        public bool blink { get; set; }

        private TimeSpan val = new TimeSpan();

        public enum DigitSets
        {
            DigitSetD,
            DigitSetE,
            DigitSetJ,
            DigitSetR
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
        }

        private void peroidicTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => peroidicTick(sender, e)));
            }
            else
            {
                if (blink)
                {
                    lblColon.Visible = !lblColon.Visible;
                }
                else
                {
                    lblColon.Visible = true;
                }
            }
        }

        private void ClockFace_Resize(object sender, EventArgs e)
        {
            FontLoader.sizeLabelFont(ref lblColon);
        }

        private void setDigit(ref PictureBox pic, int value)
        {
            Image i = null;
            switch(digitSet)
            {
                case DigitSets.DigitSetD:
                    switch (value)
                    {
                        case 0: i = Properties.Resources.d0; break;
                        case 1: i = Properties.Resources.d1; break;
                        case 2: i = Properties.Resources.d2; break;
                        case 3: i = Properties.Resources.d3; break;
                        case 4: i = Properties.Resources.d4; break;
                        case 5: i = Properties.Resources.d5; break;
                        case 6: i = Properties.Resources.d6; break;
                        case 7: i = Properties.Resources.d7; break;
                        case 8: i = Properties.Resources.d8; break;
                        case 9: i = Properties.Resources.d9; break;
                    }
                    break;
                case DigitSets.DigitSetE:
                    switch (value)
                    {
                        case 0: i = Properties.Resources.e0; break;
                        case 1: i = Properties.Resources.e1; break;
                        case 2: i = Properties.Resources.e2; break;
                        case 3: i = Properties.Resources.e3; break;
                        case 4: i = Properties.Resources.e4; break;
                        case 5: i = Properties.Resources.e5; break;
                        case 6: i = Properties.Resources.e6; break;
                        case 7: i = Properties.Resources.e7; break;
                        case 8: i = Properties.Resources.e8; break;
                        case 9: i = Properties.Resources.e9; break;
                    }
                    break;
                case DigitSets.DigitSetJ:
                    switch (value)
                    {
                        case 0: i = Properties.Resources.j0; break;
                        case 1: i = Properties.Resources.j1; break;
                        case 2: i = Properties.Resources.j2; break;
                        case 3: i = Properties.Resources.j3; break;
                        case 4: i = Properties.Resources.j4; break;
                        case 5: i = Properties.Resources.j5; break;
                        case 6: i = Properties.Resources.j6; break;
                        case 7: i = Properties.Resources.j7; break;
                        case 8: i = Properties.Resources.j8; break;
                        case 9: i = Properties.Resources.j9; break;
                    }
                    break;
                case DigitSets.DigitSetR:
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
                    }
                    break;
            }
            if (i == null) pic.Image = Properties.Resources.dX;
            else pic.Image = i;
        }
    }
}
