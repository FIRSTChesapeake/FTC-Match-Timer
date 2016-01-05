using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC_Timer_Display.PacDevices
{
    public partial class PacDeviceSettings : UserControl
    {
        private List<UsbButtonDevices.PacButton> _devices;

        public PacDeviceSettings()
        {
            InitializeComponent();
        }

        private void loadPacDevices()
        {
            // TODO: Allow user to find more than 1. For now, I'm not sure this is even an issue.
            //cboPacDevices.Enabled = UsbButtonDevices.isInit && UsbButtonDevices.Devices.Count != 0;
            if (UsbButtonDevices.isInit)
            {
                cboPacDevices.DataSource = null;
                _devices = UsbButtonDevices.Devices;
                cboPacDevices.DisplayMember = "display";
                cboPacDevices.DataSource = _devices;
            }
            loadButtonStatus();
        }

        private void loadButtonStatus()
        {
            if (!UsbButtonDevices.isInit)
            {
                lblButtonStatus.Text = "Not Initialized";
            }
            else if (UsbButtonDevices.Devices.Count == 0)
            {
                lblButtonStatus.Text = "No Button Found";
            }
            else
            {
                lblButtonStatus.Text = UsbButtonDevices.currentState.ToString();
            }
        }

        private void PacDeviceSettings_Load(object sender, EventArgs e)
        {
            loadPacDevices();
        }

        private void btnReInit_Click(object sender, EventArgs e)
        {
            UsbButtonDevices.init(null, null);
            loadPacDevices();
        }

        private void linkBuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GeneralFunctions.AppFunctions.OpenLink("http://www.usbbutton.com", "USB Button Manufacturer");
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            UsbButtonDevices.shutdown();
            loadButtonStatus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (swRefresh.Value)
            {
                try
                {
                    loadButtonStatus();
                }
                catch { }
            }
        }
    }
}
