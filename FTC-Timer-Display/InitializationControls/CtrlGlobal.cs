using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC_Timer_Display.InitializationControls
{
    public partial class CtrlGlobal : UserControl
    {
        public CtrlGlobal()
        {
            InitializeComponent();
        }

        public void SetData(InitialData data)
        {
            if (data.divID != 0) this.numDivNumber.Value = data.divID;
            else numDivNumber.Value = 1;
            swMultiDivision.Value = data.isMultiDivision;
            numDivNumber.Enabled = data.isMultiDivision;
        }
        public void GetData(ref InitialData data)
        {
            data.isMultiDivision = swMultiDivision.Value;
            if (swMultiDivision.Value) data.divID = numDivNumber.Value;
            else data.divID = 0;
        }

        private void swMultiDivision_ValueChanged(object sender, EventArgs e)
        {
            numDivNumber.Enabled = swMultiDivision.Value;
        }
    }
}
