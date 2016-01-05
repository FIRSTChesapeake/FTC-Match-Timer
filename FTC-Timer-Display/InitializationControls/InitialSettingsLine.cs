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
    public partial class InitialSettingsLine : UserControl
    {
        public event EventHandler<string> ChangeLinkEvent;

        public InitialSettingsLine()
        {
            InitializeComponent();
            linkChange.Visible = _varName != "";
        }

        private string _varName = "";
        public string varName
        {
            get { return _varName; }
            set
            {
                _varName = value;
                linkChange.Visible = _varName != "";
            }
        }

        public string title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }
        public string value
        {
            get { return lblData.Text; }
            set { lblData.Text = value; }
        }

        public void setData(string newTitle, string newDescription, object data, bool visible = true)
        {
            lblTitle.Text = newTitle;
            lblDescription.Text = newDescription;
            this.setData(data, visible);
        }

        public void setData(object data, bool visible = true)
        {
            lblData.Text = data.ToString();
            this.Visible = visible;
        }

        private void linkChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ChangeLinkEvent != null && _varName != "")
            {
                EventHandler<string> handler = ChangeLinkEvent;
                handler(this, _varName);
            }
        }
    }
}
