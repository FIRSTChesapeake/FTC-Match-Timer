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
            // Init the event type dropdown
            cboEventType.DataSource = Enum.GetValues(typeof(MatchData.EventTypes));
            // Set values
            CheckMutes();
            cboEventType.SelectedItem = (MatchData.EventTypes)template.eventType;
            numDivID.Value = Math.Max(template.divID, 1);
            swMultiDivision.Value = template.isMultiDivision;
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
                    rdoServer.Checked = true;
                    break;
                case InitialData.RunType.Server:
                    rdoServerOnly.Checked = true;
                    break;
                case InitialData.RunType.PitDisplay:
                    rdoPit.Checked = true;
                    break;
            }
            ConfigureDisplayLabels();
        }

        private void CheckMutes()
        {
            bool server = FtcMutex.checkRunTypeAvailable(InitialData.RunType.ServerClient);
            bool client = FtcMutex.checkRunTypeAvailable(InitialData.RunType.Client);
            bool pitdsp = FtcMutex.checkRunTypeAvailable(InitialData.RunType.PitDisplay);
            rdoServer.Enabled = server;
            rdoServerOnly.Enabled = server;
            rdoClient.Enabled = client;
            // PIT DISPLAY isn't production-ready. Disallow it.
            //rdoPit.Enabled = pitdsp;
            rdoPit.Enabled = false;

        }

        private void handleButtons(object sender, EventArgs e)
        {
            InitialData d = new InitialData();
            if (sender.Equals(btnContinue))
            {
                d.isMultiDivision = swMultiDivision.Value;
                d.divID = int.Parse(numDivID.Value.ToString());
                d.divName = txtDivName.Text;
                d.runType = runType;
                d.loadPreviousFields = swLoadFields.Value;
                d.eventType = (MatchData.EventTypes)cboEventType.SelectedItem;
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
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;
            if (sender.Equals(rdoServer))
            {
                runType = InitialData.RunType.ServerClient;
                grpServer.Enabled = true;
                grpClient.Enabled = true;
            }
            else if (sender.Equals(rdoServerOnly))
            {
                runType = InitialData.RunType.Server;
                grpServer.Enabled = true;
                grpClient.Enabled = false;
            }
            else if(sender.Equals(rdoClient))
            {
                runType = InitialData.RunType.Client;
                grpServer.Enabled = false;
                grpClient.Enabled = true;
            }
            else if (sender.Equals(rdoLocal))
            {
                runType = InitialData.RunType.Local;
                grpServer.Enabled = true;
                grpClient.Enabled = true;
            }
            else if (sender.Equals(rdoPit))
            {
                runType = InitialData.RunType.PitDisplay;
                grpServer.Enabled = false;
                grpClient.Enabled = false;
            }
            ConfigureDisplayLabels();
        }

        private void frmModeSelection_Load(object sender, EventArgs e)
        {

        }

        private void chkDualDivision_CheckedChanged(object sender, EventArgs e)
        {
            ConfigureDisplayLabels();
        }

        private void ConfigureDisplayLabels()
        {
            lblDivName.Text = swMultiDivision.Value ? "Division Name:" : "Event Name:";
            numDivID.Enabled = swMultiDivision.Value;
            if (!swMultiDivision.Value) numDivID.Value = 1;
        }
    }
}
