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
    public partial class CtrlServer : UserControl
    {
        public CtrlServer()
        {
            InitializeComponent();
            // Init the event type dropdown
            cboEventType.DataSource = Enum.GetValues(typeof(MatchData.EventTypes));
        }

        public void SetData(InitialData data)
        {
            this.isMultiDivision = data.isMultiDivision;
            this.txtDivName.Text = data.divName;
            this.cboEventType.SelectedItem = data.eventType;
            this.numScorePort.Value = data.scoringPort;
        }
        public void GetData(ref InitialData data)
        {
            data.divName = this.txtDivName.Text;
            data.eventType = (MatchData.EventTypes)cboEventType.SelectedItem;
            data.scoringPort = this.numScorePort.Value;
        }

        private bool isMultiDivision
        {
            set
            {
                if (value) lblDivNameLabel.Text = "Division Name:";
                else lblDivNameLabel.Text = "Event Name:";
            }
        }

        public MatchData.EventTypes eventType
        {
            set
            {
                cboEventType.SelectedItem = value;
            }
            get
            {
                return (MatchData.EventTypes)cboEventType.SelectedItem;
            }
        }
    }
}
