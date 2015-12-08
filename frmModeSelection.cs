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
    public partial class frmModeSelection : Form
    {
        private InitialData.RunType runType = InitialData.RunType.ServerClient;

        public frmModeSelection()
        {
            InitializeComponent();
        }

        private void handleButtons(object sender, EventArgs e)
        {
            InitialData d = new InitialData();
            if (sender.Equals(btnContinue))
            {
                d.divID = int.Parse(numDivID.Value.ToString());
                d.divName = txtDivName.Text;
                d.runType = runType;
                if (runType == InitialData.RunType.Server)
                {
                    d.fieldID = 0;
                }
                else
                {
                    d.fieldID = int.Parse(numField.Value.ToString());
                }
            }
            else
            {
                d.runType = InitialData.RunType.None;
            }
            this.Tag = d;
            this.Visible = false;   
        }

        private void rdoSelect(object sender, EventArgs e)
        {
            bool useField = true;
            bool useDivName = true;

            if (sender.Equals(rdoServerClient))
            {
                runType = InitialData.RunType.ServerClient;
            }
            else if (sender.Equals(rdoServerOnly))
            {
                runType = InitialData.RunType.Server;
                useField = false;
            }
            else if(sender.Equals(rdoClient))
            {
                runType = InitialData.RunType.Client;
                useDivName = false;
            }
            else
            {
                runType = InitialData.RunType.Local;
            }
            numField.Enabled = useField;
            txtDivName.Enabled = useDivName;
            if (!useDivName) txtDivName.Text = "";
        }
    }
}
