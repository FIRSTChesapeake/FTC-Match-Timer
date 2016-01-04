using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC_Timer_Display
{
    public partial class PacDeviceSettings : UserControl
    {
        private List<PacDevice.PacButton> _devices;

        public PacDeviceSettings()
        {
            InitializeComponent();
        }

        private void loadPacDevices()
        {
            cboPacDevices.DataSource = null;
            _devices = PacDevice.Devices;
            cboPacDevices.DisplayMember = "display";
            cboPacDevices.DataSource = _devices;
        }

        private void PacDeviceSettings_Load(object sender, EventArgs e)
        {
            loadPacDevices();
        }

        private void btnReInit_Click(object sender, EventArgs e)
        {
            PacDevice.init(null, null);
            loadPacDevices();
        }
    }
}
