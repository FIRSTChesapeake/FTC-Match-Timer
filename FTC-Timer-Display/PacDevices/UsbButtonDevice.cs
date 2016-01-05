using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PacDriver;
using System.Diagnostics;

namespace FTC_Timer_Display.PacDevices
{
    public static class UsbButtonDevices
    {
        public enum ButtonStates
        {
            NotFound,
            Released,
            InitialPress,
            PressedWaiting,
            InitialRelease
        }

        private static Control _owner;
        private static PacDrive _drive;
        private static ButtonStates _lastState = ButtonStates.NotFound;
        private static ButtonColorSettings _lastColors = new ButtonColorSettings(Color.Empty, Color.Empty);
        private static ButtonColorSettings _newColors = null;
        private static System.Timers.Timer _timer = new System.Timers.Timer();
        public static bool isInit { get; private set; }

        public static PacButton selectedButton { get; set; }

        public static ButtonStates currentState
        {
            get
            {
                return _lastState;
            }
        }

        public static event EventHandler<ButtonStates> buttonStateChange;

        public static bool init(Control control, EventHandler<ButtonStates> StateChangeHandler)
        {
            try
            {
                isInit = false;
                _timer.Stop();
                log("Starting Init.");
                // Handler (null for all re-inits)
                if(StateChangeHandler != null) buttonStateChange += StateChangeHandler;
                // State Vars
                _lastColors = new ButtonColorSettings(Color.Empty, Color.Empty);
                _lastState = ButtonStates.NotFound;
                // Driver
                if (_owner != null) _owner = control;
                _drive = new PacDrive(_owner);
                _drive.Initialize();
                log("Found {0} PacDrive devices.", _drive.NumDevices);
                if (_drive.NumDevices > 0)
                {
                    selectedButton = new PacButton(_drive.GetSerialNumber(0), 0);
                    // Timer
                    _timer.Interval = 10;
                    _timer.Elapsed += interval;
                    isInit = true;
                    _timer.Start();
                    return true;
                }
                else
                {
                    selectedButton = null;
                    return false;
                }
            }
            catch(Exception ex)
            {
                log("Failed to init PacDrive", ex);
                return false;
            }
        }

        private static void interval(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!isInit || _drive == null || _drive.NumDevices == 0) return;
            try
            {
                if(_newColors != null) setColorInternal(_newColors);
                _newColors = null;
                bool btn = buttonState;
                switch (_lastState)
                {
                    case ButtonStates.NotFound:
                        _lastState = btn ? ButtonStates.PressedWaiting : ButtonStates.Released;
                        break;
                    case ButtonStates.Released:
                        if (btn) _lastState = ButtonStates.InitialPress;
                        break;
                    case ButtonStates.InitialPress:
                        if (btn) _lastState = ButtonStates.PressedWaiting;
                        else _lastState = ButtonStates.Released;
                        break;
                    case ButtonStates.PressedWaiting:
                        if (!btn) _lastState = ButtonStates.InitialRelease;
                        break;
                    case ButtonStates.InitialRelease:
                        if (!btn) _lastState = ButtonStates.Released;
                        else _lastState = ButtonStates.PressedWaiting;
                        break;
                }

                if (buttonStateChange != null)
                {
                    EventHandler<ButtonStates> handler = buttonStateChange;
                    handler(null, _lastState);
                }

            }
            catch (ObjectDisposedException)
            {
                log("PacDevice class stopped - likely application is quitting.");
                die();
            }
            catch (Exception ex)
            {
                log("PacDevice class crashed with exception.", ex);
                die();
            }
        }

        public static void shutdown()
        {
            _timer.Stop();
            setColorInternal(new ButtonColorSettings(Color.Empty, Color.Empty));
            die();
        }

        public static void setColor(ButtonColorSettings settings)
        {
            if (_lastColors != null && !_lastColors.isMatch(settings))
            {
                _newColors = settings;
            }
        }

        private static void setColorInternal(ButtonColorSettings settings)
        {
            if (!isInit || _drive.NumDevices == 0 || selectedButton == null) return;
            if (_lastColors == null || !_lastColors.isMatch(settings))
            {
                _lastColors = settings;
                log("Writing new config to device.");
                if (!_drive.SetUSBButtonConfigurePermanent(selectedButton.id, settings.getByteArray))
                {
                    log("Failed to write config to button", new Exception());
                }
            }
        }

        private static bool buttonState
        {
            get
            {
                try
                {
                    if (!isInit || _drive.NumDevices == 0 || selectedButton == null) return false;
                    bool val = false;
                    if (_drive.GetUSBButtonState(selectedButton.id, ref val)) return val;
                    else
                    {
                        log("Failed to get button value. Assuming the buttion is gone.", new Exception());
                        die();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    log("Exception getting button value. Assuming the buttion is gone.", ex);
                    die();
                    return false;
                }
            }
        }

        private static void die()
        {
            isInit = false;
            _timer.Stop();
            try
            {
                if (_drive != null)
                {
                    _drive.Shutdown();
                    _drive = null;
                }
            }
            catch { }
        }

        public static List<PacButton> Devices
        {
            get
            {
                List<PacButton> l = new List<PacButton>();
                if (!isInit || _drive.NumDevices == 0) return l;
                for (int i = 0; i < _drive.NumDevices; i++) l.Add(new PacButton(_drive.GetSerialNumber(i), i));
                return l;
            }
        }

        private static void OnPacAttached(int id)
        {
            log("New Device ID {0} Attached. Serial Number: {1}", id, _drive.GetSerialNumber(id));
        }

        private static void OnPacRemoved(int id)
        {
            log("Device ID {0} Removed", id);
        }

        private static void log(string message, Exception ex)
        {
            string msg = LogMgr.make(message, "PacDrive");
            LogMgr.logger.Error(msg, ex);
        }
        private static void log(string message, params object[] args)
        {
            string msg = LogMgr.make(message, "PacDrive", 0, args);
            LogMgr.logger.Debug(msg);
        }

        public class PacButton
        {
            public string serial = "";
            public int id = -1;
            public PacButton() { }
            public PacButton(string serial, int id)
            {

                this.serial = serial;
                this.id = id;
            }
            public string display
            {
                get
                {
                    return string.Format("{0} - {1}", id, serial);
                }
            }
        }

        public class ButtonColorSettings
        {
            public Color buttonColorUp = Color.Empty;
            public Color buttonColorDn = Color.Empty;
            public int pulseRate = 0;

            public bool isMatch(ButtonColorSettings other)
            {
                if (this.buttonColorDn != other.buttonColorDn) return false;
                if (this.buttonColorUp != other.buttonColorUp) return false;
                if (this.pulseRate != other.pulseRate) return false;
                return true;
            }

            public ButtonColorSettings(Color up, Color dn)
            {
                this.buttonColorUp = up;
                this.buttonColorDn = dn;
            }

            public byte[] getByteArray
            {
                get
                {
                    byte[] data = new byte[62];
                    byte[] releasedColorData = ColorToByte(this.buttonColorUp);
                    byte[] pressedColorData = ColorToByte(this.buttonColorDn);
                    //byte[] strData = GetUSBButtonData(Url.Text);

                    data[0] = 0x00; // Mode (00 = Alternate, 01 = Extended, 02 = both)
                    data[1] = 0x00; // Spare

                    Buffer.BlockCopy(releasedColorData, 0, data, 2, pressedColorData.Length);
                    Buffer.BlockCopy(pressedColorData, 0, data, 5, pressedColorData.Length);
                    return data;
                }
            }

            private static byte[] ColorToByte(Color clr)
            {
                byte[] data = new byte[3];
                data[0] = clr.R;
                data[1] = clr.G;
                data[2] = clr.B;
                return data;
            }
        }
    }
}
