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
        private List<AppModeOption> _modes = new List<AppModeOption>();

        public CtrlAppModeSelection()
        {
            InitializeComponent();
            _modes.Add(appModeServerClient);
            _modes.Add(appModeServerOnly);
            _modes.Add(appModeClient);
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
                foreach (AppModeOption o in _modes) if (o.value) return o.runTypeValue;
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
            // set
            foreach(AppModeOption o in _modes)
            {
                if (o.runTypeValue == type) o.value = true;
                else o.value = false;
            }
        }

        private void ModeClickHandler(object sender, InitialData.RunType e)
        {
            setSelection(e);
        }
    }
}
