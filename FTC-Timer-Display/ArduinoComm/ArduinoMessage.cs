using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display.ArduinoComm
{
    public class ArduinoMessage
    {
        public ArduinoController.ModuleStatus ModuleStatus = ArduinoController.ModuleStatus.Off;
        public int buttonID = 0;

        public ArduinoMessage()
        {

        }
        public ArduinoMessage(ArduinoController.ModuleStatus status, int button)
        {
            this.ModuleStatus = status;
            this.buttonID = button;
        }
    }
}
