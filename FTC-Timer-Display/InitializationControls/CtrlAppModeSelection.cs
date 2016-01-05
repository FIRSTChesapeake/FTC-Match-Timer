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
    public partial class CtrlAppModeSelection : UserControl
    {
        public CtrlAppModeSelection()
        {
            InitializeComponent();
        }

        public void SetData(InitialData data)
        {
            this.runType = data.runType;
        }

        public void GetData(ref InitialData data)
        {
            data.runType = this.runType;
        }

        private InitialData.RunType runType
        {
            get
            {
                if (chkServerOnly.Checked) return InitialData.RunType.Server;
                if (chkServerClient.Checked) return InitialData.RunType.ServerClient;
                if (chkClient.Checked) return InitialData.RunType.Client;
                return InitialData.RunType.None;
            }
            set
            {
                setSelection(value);
            }
        }

        private void setSelection(InitialData.RunType type)
        {
            // Set the default
            if (type == InitialData.RunType.None) type = InitialData.RunType.ServerClient;
            // set radio buttons
            chkServerOnly.Checked = type == InitialData.RunType.Server;
            chkServerClient.Checked = type == InitialData.RunType.ServerClient;
            chkClient.Checked = type == InitialData.RunType.Client;
            // set images
            picBG(ref picServerOnly, chkServerOnly.Checked);
            picBG(ref picServerClient, chkServerClient.Checked);
            picBG(ref picClient, chkClient.Checked);
        }

        private void picBG(ref PictureBox pic, bool selected)
        {
            if (selected) pic.BackColor = Color.Yellow;
            else pic.BackColor = Color.Empty;
        }

        private void CheckClickHandler(object sender, EventArgs e)
        {
            setSelection(runType);
        }

        private void PicClickHandler(object sender, EventArgs e)
        {
            if (sender.Equals(picServerClient)) setSelection(InitialData.RunType.ServerClient);
            else if (sender.Equals(picServerOnly)) setSelection(InitialData.RunType.Server);
            else if (sender.Equals(picClient)) setSelection(InitialData.RunType.Client);
        }
    }
}
