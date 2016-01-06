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
        private List<GenericOptionsControl> _opts = new List<GenericOptionsControl>();

        public CtrlGlobal()
        {
            InitializeComponent();
            optSingle.selectedValue = false;
            optMulti.selectedValue = true;
            _opts.Add(optSingle);
            _opts.Add(optMulti);
        }

        public void SetData(InitialData data)
        {
            if (data.divID != 0) this.numDivNumber.Value = data.divID;
            else numDivNumber.Value = 1;
            this.isMultiDivision = data.isMultiDivision;
        }
        public void GetData(ref InitialData data)
        {
            data.isMultiDivision = this.isMultiDivision;
            if (this.isMultiDivision) data.divID = numDivNumber.Value;
            else data.divID = 0;
        }

        private bool isMultiDivision
        {
            get
            {
                foreach (GenericOptionsControl o in _opts) if (o.isSelected) return (bool)o.selectedValue;
                return false;
            }
            set
            {
                numDivNumber.Enabled = value;
                foreach (GenericOptionsControl o in _opts)
                {
                    if ((bool)o.selectedValue == value) o.isSelected = true;
                    else o.isSelected = false;
                }
            }
        }

        private void SelectHandler(object sender, EventArgs e)
        {
            GenericOptionsControl ctrl = (GenericOptionsControl)sender;
            this.isMultiDivision = (bool)ctrl.selectedValue;
        }

        private void optSingle_Selected(object sender, EventArgs e)
        {

        }
    }
}
