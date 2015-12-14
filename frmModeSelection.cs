using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public partial class frmModeSelection : Office2007Form
    {
        private InitialData.RunType runType = InitialData.RunType.None;

        public frmModeSelection(InitialData template)
        {
            InitializeComponent();
            CheckMutes();
            numDivID.Value = Math.Max(template.divID, 1);
            txtDivName.Text = template.divName;
            numField.Value = Math.Max(template.fieldID, 1);
            txtPitPort.Text = template.scoringPort.ToString();
            runType = template.runType == InitialData.RunType.None ? InitialData.RunType.ServerClient : template.runType;
            if (!FtcMutex.checkRunTypeAvailable(runType)) runType = InitialData.RunType.Local;
            switch (runType)
            {
                case InitialData.RunType.Client:
                    rdoClient.Checked = true;
                    break;
                case InitialData.RunType.Local:
                    rdoLocal.Checked = true;
                    break;
                case InitialData.RunType.ServerClient:
                    rdoServerClient.Checked = true;
                    break;
                case InitialData.RunType.Server:
                    rdoServerOnly.Checked = true;
                    break;
                case InitialData.RunType.PitDisplay:
                    rdoPit.Checked = true;
                    break;
            }

        }

        private void CheckMutes()
        {
            bool server = FtcMutex.checkRunTypeAvailable(InitialData.RunType.ServerClient);
            bool client = FtcMutex.checkRunTypeAvailable(InitialData.RunType.Client);
            bool pitdsp = FtcMutex.checkRunTypeAvailable(InitialData.RunType.PitDisplay);
            rdoServerClient.Enabled = server;
            rdoServerOnly.Enabled = server;
            rdoClient.Enabled = client;
            rdoPit.Enabled = pitdsp;
        }

        private void handleButtons(object sender, EventArgs e)
        {
            InitialData d = new InitialData();
            if (sender.Equals(btnContinue))
            {
                d.divID = int.Parse(numDivID.Value.ToString());
                d.divName = txtDivName.Text;
                d.runType = runType;
                d.loadPreviousFields = chkLoadFields.Checked;
                if (runType == InitialData.RunType.Server)
                {
                    d.fieldID = 0;
                }
                else if (runType == InitialData.RunType.PitDisplay)
                {
                    int port = 0;
                    bool isInt = int.TryParse(txtPitPort.Text, out port);
                    if (!isInt || port < 1 || port > 65535)
                    {
                        string msg = string.Format("Invalid Scoring Broadcast Port number '{0}'.\nTry Again.", txtPitPort.Text);
                        MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPitPort.Text = Properties.Settings.Default.DefaultScoringPort.ToString();
                        return;
                    }
                    d.scoringPort = port;
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
            bool useDivID = true;
            bool usePitPort = false;
            bool loadFields = true;

            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;
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
                loadFields = false;
            }
            else if (sender.Equals(rdoLocal))
            {
                runType = InitialData.RunType.Local;
                loadFields = false;
            }
            else if (sender.Equals(rdoPit))
            {
                runType = InitialData.RunType.PitDisplay;
                useDivName = false;
                useField = false;
                useDivID = false;
                usePitPort = true;
                loadFields = false;
            }
            numField.Enabled = useField;
            txtDivName.Enabled = useDivName;
            numDivID.Enabled = useDivID;
            txtPitPort.Enabled = usePitPort;
            chkLoadFields.Enabled = loadFields;
            chkLoadFields.Checked = loadFields;
            if (!useDivName) txtDivName.Text = "";
        }

        private void frmModeSelection_Load(object sender, EventArgs e)
        {

        }
    }
}
