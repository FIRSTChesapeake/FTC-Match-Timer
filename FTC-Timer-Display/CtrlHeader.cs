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
    public partial class CtrlHeader : LabelX
    {
        public CtrlHeader()
            : base()
        {
            InitializeComponent();
            this.BackgroundStyle.BackColor = Color.FromArgb(0, 255, 255);
            this.BackgroundStyle.BackColor2 = Color.FromArgb(0, 130, 132);
            this.BackgroundStyle.BackColorGradientType = eGradientType.Radial;
            this.Font = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            this.TextAlignment = StringAlignment.Center;
        }
    }
}
