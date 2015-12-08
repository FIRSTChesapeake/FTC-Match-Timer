using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC_Timer_Display
{
    public partial class ctrlTimeLengthEntry : UserControl
    {
        public event EventHandler<TimeSpan> ValueChanged;

        public ctrlTimeLengthEntry()
        {
            InitializeComponent();
            if (!notDefault) MaximumValue = TimeSpan.MaxValue;
            notDefault = true;
        }
        private bool notDefault { get; set; }

        public bool Readonly
        {
            get
            {
                return numMin.ReadOnly;
            }
            set
            {
                numMin.ReadOnly = value;
                numSec.ReadOnly = value;
            }
        }

        public bool useColorPicker
        {
            get
            {
                return clrPicker.Visible;
            }
            set
            {
                clrPicker.Visible = value;
            }
        }

        public string Caption
        {
            get
            {
                return lblCaption.Text;
            }
            set
            {
                lblCaption.Text = value;
            }
        }
        public TimeSpan Value
        {
            get
            {
                return new TimeSpan(0, (int)numMin.Value, (int)numSec.Value);
            }
            set
            {
                if (value >= MaximumValue)
                {
                    numMin.Value = _MaximumValue.Minutes;
                    numSec.Value = _MaximumValue.Seconds;
                }
                else if (MinimumValue >= value)
                {
                    numMin.Value = _MinimumValue.Minutes;
                    numSec.Value = _MinimumValue.Seconds;
                }
                else
                {
                    numMin.Value = value.Minutes;
                    numSec.Value = value.Seconds;
                }
                //SetMinMax();
            }
        }
        private TimeSpan _MinimumValue = new TimeSpan(0, 0, 0);
        public TimeSpan MinimumValue
        {
            get { return _MinimumValue; }
            set
            {
                TimeSpan zero = new TimeSpan(0, 0, 0);
                if (value < zero) _MinimumValue = zero;
                else _MinimumValue = value;
                //SetMinMax();
            }
        }
        private TimeSpan _MaximumValue = new TimeSpan(0, 59, 59);
        public TimeSpan MaximumValue
        {
            get { return _MaximumValue; }
            set
            {
                _MaximumValue = new TimeSpan(0, value.Minutes, value.Seconds);
                //SetMinMax();
            }
        }

        private void SetMinMax(bool userDriven = false)
        {
            TimeSpan ts = new TimeSpan(0, (int)numMin.Value, (int)numSec.Value);
            TimeSpan diff = _MaximumValue - ts;
            // Find the Max Mins
            int MaxMins = Math.Min(diff.Minutes, 59);
            if (numMin.Value > MaxMins) numMin.Value = MaxMins;
            numMin.Maximum = MaxMins;
            // Find the max secs
            int MaxSecs = Math.Min(diff.Seconds, 59);
            if (numSec.Value > MaxSecs) numSec.Value = MaxSecs;
            numSec.Maximum = MaxSecs;
        }

        public Color IndicatorColor
        {
            get { return clrPicker.SelectedColor; }
            set { clrPicker.SelectedColor = value; }
        }

        private void NumsChangedHandler(object sender, EventArgs e)
        {
            if (ValueChanged != null)
            {
                EventHandler<TimeSpan> handler = ValueChanged;
                handler(this, this.Value);
            }
        }

        private void numMin_Click(object sender, EventArgs e)
        {

        }
    }
}
