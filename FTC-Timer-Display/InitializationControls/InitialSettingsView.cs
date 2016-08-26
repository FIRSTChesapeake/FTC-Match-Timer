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
    public partial class InitialSettingsView : UserControl
    {
        public event EventHandler<string> ChangeRequestEvent;



        public InitialSettingsView()
        {
            InitializeComponent();
        }

        public void fill(InitialData data)
        {
            lineAppMode.setData(data.runTypeString);
            lineDivMode.setData(data.isMultiDivision ? "Multi-Division Event" : "Single Division Event");
            lineDivID.setData(data.divID, data.isMultiDivision);
            lineEventName.setData(data.divName, !data.isMultiDivision);
            lineDivName.setData(data.divName, data.isMultiDivision && data.isServer);
            lineEventType.setData(data.eventType, data.isServer);
            lineFieldCount.setData(data.fieldCount, data.isServer);
            lineFieldID.setData(data.fieldID, data.hasLocalClock);
        }

        private void ChangeLinkEventHandler(object sender, string varName)
        {
            if (ChangeRequestEvent != null)
            {
                EventHandler<string> handler = ChangeRequestEvent;
                handler(sender, varName);
            }
        }
    }
}
