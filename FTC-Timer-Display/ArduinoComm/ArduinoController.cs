using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Diagnostics;

namespace FTC_Timer_Display.ArduinoComm
{
    public partial class ArduinoController : UserControl
    {
        private SerialPort port;
        private bool isPressed = false;
        private DateTime lastTime = DateTime.Now.AddDays(-1);

        public ArduinoController()
        {
            InitializeComponent();
        }

        public event EventHandler<ArduinoMessage> DataReceived;

        public void Init()
        {
            string sPort = FindArduinoPort();
            if (sPort == "") return;
            LogMgr.logger.Info(LogMgr.make("Initializing Arduino COM Port {0}..", "ArduinoCtrl", 0, sPort.ToString()));
            port = new SerialPort(sPort, 9600, Parity.None, 8, StopBits.One);
            port.Handshake = Handshake.RequestToSend;
            port.DtrEnable = true;
            port.DataReceived += port_DataReceived;
            port.ErrorReceived += port_ErrorReceived;
            port.PinChanged += port_PinChanged;
            LogMgr.logger.Info(LogMgr.make("COM Port {0} Initialized.", "ArduinoCtrl", 0, sPort.ToString()));
        }

        void port_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            SerialError err = e.EventType;
            LogMgr.logger.Error(LogMgr.make("Port Error Received\n{0}", "AndroidControl", 0, err.ToString()));
        }

        public ModuleStatus moduleStatus
        {
            set
            {
                try
                {
                    if (port == null)
                    {
                        LogMgr.logger.Error(LogMgr.make("Tried to set status but port is null", "AndroidCtrl"));
                        return;
                    }
                    int v = (int)value;
                    port.Write(v.ToString());
                }
                catch (Exception ex)
                {
                    LogMgr.logger.Error(LogMgr.make("Cant write to port", "AndroidCtrl"), ex);
                }
            }
        }

        public string currentPortName
        {
            get
            {
                if (port == null) return "";
                return port.PortName;
            }
        }

        public enum ModuleStatus
        {
            Off = 0,
            Div1 = 1,
            Div2 = 2,
            Reset = 9
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort p = (SerialPort)sender;
            while (p.BytesToRead > 0)
            {
                string s = p.ReadLine();
                s = s.Remove(s.Length - 1);
                processSerialData(s);
            }
        }

        private void processSerialData(string data)
        {
            if (data.Length != 4) return;
            lastTime = DateTime.Now;
            int ap = int.Parse(data.Substring(0, 1));
            int b1 = int.Parse(data.Substring(1, 1));
            int b2 = int.Parse(data.Substring(2, 1));
            int pr = int.Parse(data.Substring(3, 1));
            // Actual processing
            if (pr == 1)
            {
                if (!isPressed)
                {
                    int b = 0;
                    if (b1 == 1) b = 1;
                    if (b2 == 1) b = 2;
                    if (b != 0)
                    {
                        isPressed = true;
                        // Raise event
                        ModuleStatus status = (ModuleStatus)ap;
                        ArduinoMessage msg = new ArduinoMessage(status, b);
                        if (DataReceived != null)
                        {
                            EventHandler<ArduinoMessage> handler = DataReceived;
                            handler(this, msg);
                        }
                    }
                }
            }
            else
            {
                isPressed = false;
            }
        }

        public bool portStatus
        {
            get
            {
                if (port == null) return false;
                try
                {
                    return port.IsOpen;
                }
                catch (Exception ex)
                {
                    LogMgr.logger.Error(LogMgr.make("Cant get port status.", "ArduinoComm", 0), ex);
                    return false;
                }
            }
            set
            {
                if (port == null) return;
                try
                {
                    if (value && !port.IsOpen) port.Open();
                    if (!value && port.IsOpen) port.Close();
                    string s = port.IsOpen ? "Open" : "Closed";
                    LogMgr.logger.Info(LogMgr.make("Port Status Set To {0}.", "ArduinoCtrl", 0, s));
                }
                catch (Exception ex)
                {
                    LogMgr.logger.Error(LogMgr.make("Cant set port status to {0}.", "ArduinoComm", 0, value), ex);
                }
            }
        }


        private static string FindArduinoPort()
        {
            ManagementScope scope = new ManagementScope();
            SelectQuery q = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, q);
            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string devID = item["DeviceID"].ToString();
                    if (desc.Contains("Arduino"))
                    {
                        Dump(item);
                        return devID;
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                string s = LogMgr.make("Exception loading COM port", "ArduinoControl");
                LogMgr.logger.Info(s, ex);
                return "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (port == null)
            {
                lblPort.Text = "None";
                lblStatus.Text = "N/a";
                lblPort.BackColor = Color.Red;
                lblStatus.BackColor = Color.Red;
            }
            else
            {
                lblPort.BackColor = Color.Green;
                lblPort.Text = this.currentPortName;
                if (this.portStatus)
                {
                    if (DateTime.Now < lastTime.AddSeconds(2))
                    {
                        lblStatus.Text = "Listening";
                        lblStatus.BackColor = this.isPressed ? Color.Orange : Color.Green;
                    }
                    else
                    {
                        lblStatus.Text = "Not Receiving!";
                        lblStatus.BackColor = Color.Red;
                    }
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.portStatus = !this.portStatus;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.moduleStatus = ModuleStatus.Div1;
        }

        public static void Dump(object obj)
        {
            Debug.WriteLine("Dumping..");
            foreach (PropertyDescriptor d in TypeDescriptor.GetProperties(obj))
            {
                string n = d.Name;
                object v = d.GetValue(obj);
                string s = string.Format("{0} = {1}", n, v);
                Debug.WriteLine(s);
            }
        }
    }
}
