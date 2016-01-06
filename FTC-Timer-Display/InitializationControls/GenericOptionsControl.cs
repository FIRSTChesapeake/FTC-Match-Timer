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
    public partial class GenericOptionsControl : UserControl
    {
        public event EventHandler Selected;

        public object selectedValue { get; set; }

        private bool _isSelected = false;
        public bool isSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                this.BackColor = value ? Color.Yellow : Color.Empty;
            }
        }

        public string header
        {
            get { return headCtrl.Text; }
            set { headCtrl.Text = value; }
        }

        public string explain
        {
            get { return lblExplain.Text; }
            set { lblExplain.Text = value; }
        }

        public GenericOptionsControl()
        {
            InitializeComponent();
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            if (Selected != null)
            {
                EventHandler handler = Selected;
                handler(this, new EventArgs());
            }
        }
    }
}
