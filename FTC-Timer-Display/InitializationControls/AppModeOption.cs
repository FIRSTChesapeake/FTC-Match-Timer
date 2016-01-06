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
    public partial class AppModeOption : UserControl
    {
        public event EventHandler<InitialData.RunType> Selected;

        private InitialData.RunType _runTypeValue = InitialData.RunType.None;
        public InitialData.RunType runTypeValue
        {
            get { return _runTypeValue; }
            set
            {
                _runTypeValue = value;
                chkHeader.Text = string.Format("{0}) {1}", (int)value, InitialData.GetRunTypeString(value));
            }
        }

        public AppModeOption()
        {
            InitializeComponent();
        }

        public Image picture
        {
            get { return picImage.Image; }
            set { picImage.Image = value; }
        }

        public string descrption
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public bool value
        {
            get { return chkHeader.Checked; }
            set
            {
                chkHeader.Checked = value;
                this.BackColor = value ? Color.Yellow : Color.Empty;
            }
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            //this.value = true;
            if (Selected != null)
            {
                EventHandler<InitialData.RunType> handler = Selected;
                handler(this, _runTypeValue);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
