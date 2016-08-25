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
using DevComponents.Instrumentation;
using DevComponents.Instrumentation.Primitives;

namespace FTC_Timer_Display
{
    public partial class ClockFace : UserControl
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        System.Timers.Timer blinkTimer = new System.Timers.Timer();

        public bool blink { get; set; }
        public bool play { get; set; }

        private bool _blinkFlag = true;
        private int _playInt = 0;

        private TimeSpan val = new TimeSpan();


        public void faceColor(bool isTimeout)
        {
            if (isTimeout)
            {
                
            }
            else
            {
                
            }
        }

        public ClockFace()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Elapsed += peroidicTick;
            timer.Start();

            blinkTimer.Interval = 500;
            blinkTimer.Elapsed += blinkTick;
            blinkTimer.Start();
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

        public void TextOver(string text)
        {
            (gaugeDisplay.GaugeItems[0] as GaugeIndicator).Text = text;
        }

        private void setDisplay()
        {
            // Fill the label
            StringBuilder sb = new StringBuilder();
            if (!play)
            {
                if (val.Minutes < 10) sb.Append("0");
                sb.Append(val.Minutes.ToString());

                if (!blink) sb.Append(":");
                if (blink && _blinkFlag) sb.Append(":");

                if (val.Seconds < 10) sb.Append("0");
                sb.Append(val.Seconds.ToString());
                (gaugeDisplay.GaugeItems[0] as GaugeIndicator).Text = sb.ToString();
            }
        }

        private void clearDisplay()
        {
            (gaugeDisplay.GaugeItems[0] as GaugeIndicator).Text = "";
        }

        private void peroidicTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => peroidicTick(sender, e)));
            }
            else
            {
                if (play)
                {
                    string s = "";
                    switch (_playInt)
                    {
                        case 0: s = "Z   "; break;
                        case 1: s = "zZ  "; break;
                        case 2: s = "zzZ "; break;
                        case 3: s = "zzzZ"; break;
                        case 4: s = " zzz"; break;
                        case 5: s = "  zz"; break;
                        case 6: s = "   z"; break;
                    }
                    if (_playInt == 6) _playInt = 0;
                    else _playInt++;
                    (gaugeDisplay.GaugeItems[0] as GaugeIndicator).Text = s;
                }
            }
        }
        private void blinkTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            _blinkFlag = !_blinkFlag;
        }
    }
}
