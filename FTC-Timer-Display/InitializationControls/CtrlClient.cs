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
    public partial class CtrlClient : UserControl
    {
        public void SetData(InitialData data)
        {
            this.numFieldID.Value = data.fieldID;
        }

        public void GetData(ref InitialData data)
        {
            data.fieldID = this.numFieldID.Value;
        }

        public CtrlClient()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
