using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public partial class MatchPeriodCtrl : UserControl
    {
        public System.Timers.Timer blinkTimer = new System.Timers.Timer();

        private bool blinkNocross = false;
        private bool blinkEndgame = false;
        
        // Background Colors of the Main Indicators

        private Color mColor2 = Color.DarkOrange;
        private Color mColor1 = Color.Green;
        private Color mColor0 = Color.DarkRed;
        private Color mColorS = Color.OrangeRed;
        // Foreground Colors of all Indicators
        private Color fColor1 = Color.LightBlue;
        private Color fColor0 = Color.Maroon;
        // Backbround Colors of the interperiod indicators
        private Color bColor1 = Color.Red;
        private Color bColor0 = Color.DarkRed;

        public MatchPeriodCtrl()
        {
            InitializeComponent();
            blinkTimer.Interval = 500;
            blinkTimer.Elapsed += blinkTimerHandler;
            blinkTimer.Start();
        }

        private void blinkTimerHandler(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (blinkNocross)
            {
                lblNocross.BackColor = lblNocross.BackColor == bColor1 ? bColor0 : bColor1;
                lblNocross.ForeColor = fColor1;
            }
            else
            {
                lblNocross.BackColor = bColor0;
                lblNocross.ForeColor = fColor0;
            }

            if (blinkEndgame)
            {
                lblEndgame.BackColor = lblEndgame.BackColor == bColor1 ? bColor0 : bColor1;
                lblEndgame.ForeColor = fColor1;
            }
            else
            {
                lblEndgame.BackColor = bColor0;
                lblEndgame.ForeColor = fColor0;
            }
        }

        public void SetDisplay(MatchData data)
        {
            switch (data.matchPeriod)
            {
                case MatchData.MatchPeriods.Autonomous:
                    ColorMain(ref lblAuto, true, data.matchStatus);
                    ColorMain(ref lblDriver, false);
                    blinkNocross = data.noCrossActive && data.matchStatus == MatchData.MatchStatus.Running;
                    blinkEndgame = false;
                    break;
                case MatchData.MatchPeriods.DriverControlled:
                    ColorMain(ref lblAuto, false);
                    ColorMain(ref lblDriver, true, data.matchStatus);
                    blinkNocross = false;
                    blinkEndgame = false;
                    break;
                case MatchData.MatchPeriods.EndGame:
                    ColorMain(ref lblAuto, false);
                    ColorMain(ref lblDriver, true, data.matchStatus);
                    blinkNocross = false;
                    blinkEndgame = data.matchStatus == MatchData.MatchStatus.Running;
                    break;
                default:
                    ColorMain(ref lblAuto, false);
                    ColorMain(ref lblDriver, false);
                    blinkNocross = false;
                    blinkEndgame = false;
                    break;
            }

        }

        private void ColorMain(ref LabelX lbl, bool on, MatchData.MatchStatus status = new MatchData.MatchStatus())
        {
            Color b = Color.Empty;
            Color f = Color.Empty;
            if (on)
            {
                switch (status)
                {
                    case MatchData.MatchStatus.Running:
                        b = mColor1;
                        break;
                    case MatchData.MatchStatus.Paused:
                        b = mColor2;
                        break;
                    case MatchData.MatchStatus.Stopped:
                        b = mColorS;
                        break;
                }
                f = fColor1;
            }
            else
            {
                b = mColor0;
                f = fColor0;
            }
            lbl.BackColor = b;
            lbl.ForeColor = f;
        }
    }
}
