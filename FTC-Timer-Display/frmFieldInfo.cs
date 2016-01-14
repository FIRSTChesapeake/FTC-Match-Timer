using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Net;

namespace FTC_Timer_Display
{
    public partial class frmFieldInfo : DevComponents.DotNetBar.OfficeForm
    {

        public frmFieldInfo(int div, int field, int port)
        {
            InitializeComponent();
            this.setDivField(div, field);
            lblExpectedPort.Text = port.ToString();
        }

        public void Update(DateTime lastSent)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => Update(lastSent)));
            }
            else
            {
                lblVerifiySent.Text = lastSent.ToLongTimeString();
            }
        }

        public void Update(ClientReply reply)
        {
            if (this.InvokeRequired)
            {
                object o = this.Invoke(new Action(() => Update(reply)));
            }
            else
            {
                this.setDivField(reply.divID, reply.fieldID);
                lblVersion.Text = reply.clientVersion.ToString();
                lblVerifyRcvd.Text = DateTime.Now.ToLongTimeString();
                lblAppMode.Text = InitialData.GetRunTypeString(reply.runType);
                lblAddress.Text = string.Format("{0}:{1}", reply.fromEndpoint.Address, reply.fromEndpoint.Port);
            }
        }

        private void setDivField(int div, int field)
        {
            string s = string.Format("Division {0} - Field {1}", div, field);
            lblDivField.Text = s;
            this.Text = string.Format("{0} Diagnistic Info", s);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void frmFieldInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }
    }
}