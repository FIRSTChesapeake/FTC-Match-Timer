using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC_Timer_Display
{
    public partial class frmRemoteFieldCreate : Form
    {
        public frmRemoteFieldCreate(int nextID = 1)
        {
            InitializeComponent();
            numNewID.Value = nextID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sender.Equals(btnSave)) this.Tag = (int)numNewID.Value;
            this.Visible = false;
        }
    }
}
