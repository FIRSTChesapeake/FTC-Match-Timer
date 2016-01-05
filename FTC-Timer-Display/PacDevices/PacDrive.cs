using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PacDriver
{
    class PacDrive
    {
        private bool m_mode64 = false;

        public enum DeviceType
        {
            Unknown,
            PacDrive,
            UHID,
            PacLED64,
            ServoStik,
            USBButton,
			NanoLED,
			IPACIO
        };

        public enum FlashSpeed : byte
        {
            AlwaysOn = 0,
            Seconds_2 = 1,
            Seconds_1 = 2,
            Seconds_0_5 = 3
        };

        // ================== 32-bit ====================

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacSetCallbacks", CallingConvention = CallingConvention.StdCall)]
        private static extern void PacSetCallbacks32(PAC_ATTACHED_CALLBACK pacAttachedCallback, PAC_REMOVED_CALLBACK pacRemovedCallback);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacInitialize", CallingConvention = CallingConvention.StdCall)]
        private static extern int PacInitialize32();

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacShutdown", CallingConvention = CallingConvention.StdCall)]
        private static extern void PacShutdown32();

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacSetLEDStates", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacSetLEDStates32(int id, ushort data);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacSetLEDState", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacSetLEDState32(int id, int port, [MarshalAs(UnmanagedType.Bool)] bool state);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetLEDStates", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDStates32(int id, int group, byte data);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetLEDState", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDState32(int id, int group, int port, [MarshalAs(UnmanagedType.Bool)] bool state);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetLEDStatesRandom", CallingConvention = CallingConvention.StdCall)]
        private static extern bool Pac64SetLEDStatesRandom32(int id);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetLEDIntensities", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDIntensities32(int id, byte[] data);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetLEDIntensity", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDIntensity32(int id, int port, byte intensity);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetLEDFadeTime", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDFadeTime32(int id, byte fadeTime);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetLEDFlashSpeeds", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDFlashSpeeds32(int id, byte flashSpeed);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetLEDFlashSpeed", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDFlashSpeed32(int id, int port, byte flashSpeed);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64StartScriptRecording", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64StartScriptRecording32(int id);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64StopScriptRecording", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64StopScriptRecording32(int id);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetScriptStepDelay", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetScriptStepDelay32(int id, byte stepDelay);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64RunScript", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64RunScript32(int id);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64ClearFlash", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64ClearFlash32(int id);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "Pac64SetDeviceId", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetDeviceId32(int id, int newId);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacGetDeviceType", CallingConvention = CallingConvention.StdCall)]
        private static extern int PacGetDeviceType32(int id);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacGetVendorId", CallingConvention = CallingConvention.StdCall)]
		private static extern int PacGetVendorId32(int id);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacGetProductId", CallingConvention = CallingConvention.StdCall)]
		private static extern int PacGetProductId32(int id);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacGetVersionNumber", CallingConvention = CallingConvention.StdCall)]
		private static extern int PacGetVersionNumber32(int id);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacGetVendorName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		private static extern void PacGetVendorName32(int id, StringBuilder vendorName);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacGetProductName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		private static extern void PacGetProductName32(int id, StringBuilder productName);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacGetSerialNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		private static extern void PacGetSerialNumber32(int id, StringBuilder serialNumber);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacGetDevicePath", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		private static extern void PacGetDevicePath32(int id, StringBuilder devicePath);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacProgramUHid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacProgramUHid32(int id, StringBuilder fileName);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacSetServoStik4Way", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacSetServoStik4Way32();

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "PacSetServoStik8Way", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacSetServoStik8Way32();

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "USBButtonConfigurePermanent", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool USBButtonConfigurePermanent32(int id, byte[] data);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "USBButtonConfigureTemporary", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool USBButtonConfigureTemporary32(int id, byte[] data);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "USBButtonConfigureColor", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool USBButtonConfigureColor32(int id, byte red, byte green, byte blue);

        [DllImport(@"lib\PacDrive32.dll", EntryPoint = "USBButtonGetState", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool USBButtonGetState32(int id, [MarshalAs(UnmanagedType.Bool)] ref bool state);

        // ================== 64-bit ====================

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacSetCallbacks", CallingConvention = CallingConvention.StdCall)]
        private static extern void PacSetCallbacks64(PAC_ATTACHED_CALLBACK pacAttachedCallback, PAC_REMOVED_CALLBACK pacRemovedCallback);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacInitialize", CallingConvention = CallingConvention.StdCall)]
        private static extern int PacInitialize64();

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacShutdown", CallingConvention = CallingConvention.StdCall)]
        private static extern void PacShutdown64();

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacSetLEDStates", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacSetLEDStates64(int id, ushort data);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacSetLEDState", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacSetLEDState64(int id, int port, [MarshalAs(UnmanagedType.Bool)] bool state);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetLEDStates", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDStates64(int id, int group, byte data);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetLEDState", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDState64(int id, int group, int port, [MarshalAs(UnmanagedType.Bool)] bool state);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetLEDStatesRandom", CallingConvention = CallingConvention.StdCall)]
        private static extern bool Pac64SetLEDStatesRandom64(int id);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetLEDIntensities", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDIntensities64(int id, byte[] data);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetLEDIntensity", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDIntensity64(int id, int port, byte intensity);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetLEDFadeTime", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDFadeTime64(int id, byte fadeTime);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetLEDFlashSpeeds", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDFlashSpeeds64(int id, byte flashSpeed);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetLEDFlashSpeed", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetLEDFlashSpeed64(int id, int port, byte flashSpeed);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64StartScriptRecording", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64StartScriptRecording64(int id);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64StopScriptRecording", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64StopScriptRecording64(int id);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetScriptStepDelay", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetScriptStepDelay64(int id, byte stepDelay);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64RunScript", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64RunScript64(int id);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64ClearFlash", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64ClearFlash64(int id);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "Pac64SetDeviceId", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Pac64SetDeviceId64(int id, int newId);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacGetDeviceType", CallingConvention = CallingConvention.StdCall)]
        private static extern int PacGetDeviceType64(int id);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacGetVendorId", CallingConvention = CallingConvention.StdCall)]
        private static extern int PacGetVendorId64(int id);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacGetProductId", CallingConvention = CallingConvention.StdCall)]
        private static extern int PacGetProductId64(int id);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacGetVersionNumber", CallingConvention = CallingConvention.StdCall)]
        private static extern int PacGetVersionNumber64(int id);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacGetVendorName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		private static extern void PacGetVendorName64(int id, StringBuilder vendorName);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacGetProductName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		private static extern void PacGetProductName64(int id, StringBuilder productName);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacGetSerialNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		private static extern void PacGetSerialNumber64(int id, StringBuilder serialNumber);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacGetDevicePath", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		private static extern void PacGetDevicePath64(int id, StringBuilder devicePath);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacProgramUHid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacProgramUHid64(int id, StringBuilder fileName);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacSetServoStik4Way", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacSetServoStik4Way64();

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "PacSetServoStik8Way", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PacSetServoStik8Way64();

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "USBButtonConfigurePermanent", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool USBButtonConfigurePermanent64(int id, byte[] data);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "USBButtonConfigureTemporary", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool USBButtonConfigureTemporary64(int id, byte[] data);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "USBButtonConfigureColor", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool USBButtonConfigureColor64(int id, byte red, byte green, byte blue);

        [DllImport(@"lib\PacDrive64.dll", EntryPoint = "USBButtonGetState", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool USBButtonGetState64(int id, [MarshalAs(UnmanagedType.Bool)] ref bool state);
		
        private delegate void PAC_ATTACHED_CALLBACK(int id);
        private delegate void PAC_REMOVED_CALLBACK(int id);

        public delegate void PacAttachedDelegate(int id);
        public delegate void PacRemovedDelegate(int id);

        public event PacAttachedDelegate OnPacAttached = null;
        public event PacRemovedDelegate OnPacRemoved = null;

        [MarshalAs(UnmanagedType.FunctionPtr)]
        PAC_ATTACHED_CALLBACK PacAttachedCallbackPtr = null;

        [MarshalAs(UnmanagedType.FunctionPtr)]
        PAC_REMOVED_CALLBACK PacRemovedCallbackPtr = null;

        private Control m_ctrl;
        private int m_numDevices = 0;

        public PacDrive(Control ctrl)
        {
            m_ctrl = ctrl;
            m_mode64 = Is64BitMode();

            PacAttachedCallbackPtr = new PAC_ATTACHED_CALLBACK(PacAttachedCallback);
            PacRemovedCallbackPtr = new PAC_REMOVED_CALLBACK(PacRemovedCallback);

            if(m_mode64)
                PacSetCallbacks64(PacAttachedCallbackPtr, PacRemovedCallbackPtr);
            else
                PacSetCallbacks32(PacAttachedCallbackPtr, PacRemovedCallbackPtr);
        }

        void PacAttachedCallback(int id)
        {
            m_numDevices++;

            if (OnPacAttached != null)
                m_ctrl.BeginInvoke(OnPacAttached, id);
        }

        void PacRemovedCallback(int id)
        {
            m_numDevices--;

            if (OnPacRemoved != null)
                m_ctrl.BeginInvoke(OnPacRemoved, id);
        }

        public int Initialize()
        {
            m_numDevices = (m_mode64 ? PacInitialize64() : PacInitialize32());

            return m_numDevices;
        }

        public void Shutdown()
        {
            if (m_mode64)
                PacShutdown64();
            else
                PacShutdown32();
        }

        public bool SetLEDStates(int id, ushort data)
        {
            return (m_mode64 ? PacSetLEDStates64(id, data) : PacSetLEDStates32(id, data));
        }

        public bool SetLEDState(int id, int port, bool state)
        {
            return (m_mode64 ? PacSetLEDState64(id, port, state) : PacSetLEDState32(id, port, state));
        }

        public bool SetLEDStates(int id, bool[] data)
        {
            ushort dataSend = 0;

            for (int i = 0; i < data.Length; i++)
                if (data[i])
					dataSend |= (ushort)(1 << i);

            return (m_mode64 ? PacSetLEDStates64(id, dataSend) : PacSetLEDStates32(id, dataSend));
        }

        public bool SetLED64States(int id, int group, byte data)
        {
            return (m_mode64 ? Pac64SetLEDStates64(id, group, data) : Pac64SetLEDStates32(id, group, data));
        }

        public bool SetLED64States(int id, int group, bool[] data)
        {
            byte dataSend = 0;

            for (int i = 0; i < data.Length; i++)
                if (data[i]) dataSend |= (byte)(1 << i);

            return (m_mode64 ? Pac64SetLEDStates64(id, group, dataSend) : Pac64SetLEDStates32(id, group, dataSend));
        }

        public bool SetLED64StatesRandom(int id)
        {
            return (m_mode64 ? Pac64SetLEDStatesRandom64(id) : Pac64SetLEDStatesRandom32(id));
        }

        public bool SetLED64Intensities(int id, byte[] data)
        {
            return (m_mode64 ? Pac64SetLEDIntensities64(id, data) : Pac64SetLEDIntensities32(id, data));
        }

        public bool SetLED64Intensity(int id, int port, byte intensity)
        {
            return (m_mode64 ? Pac64SetLEDIntensity64(id, port, intensity) : Pac64SetLEDIntensity32(id, port, intensity));
        }

        public bool SetLED64FadeTime(int id, byte fadeTime)
        {
            return (m_mode64 ? Pac64SetLEDFadeTime64(id, fadeTime) : Pac64SetLEDFadeTime32(id, fadeTime));
        }

        public bool SetLED64FlashSpeeds(int id, FlashSpeed flashSpeed)
        {
            return (m_mode64 ? Pac64SetLEDFlashSpeeds64(id, (byte)flashSpeed) : Pac64SetLEDFlashSpeeds32(id, (byte)flashSpeed));
        }

        public bool SetLED64FlashSpeed(int id, int port, FlashSpeed flashSpeed)
        {
			return (m_mode64 ? Pac64SetLEDFlashSpeed64(id, port, (byte)flashSpeed) : Pac64SetLEDFlashSpeed32(id, port, (byte)flashSpeed));
        }

		public bool StartScriptRecording(int id)
        {
			return (m_mode64 ? Pac64StartScriptRecording64(id) : Pac64StartScriptRecording32(id));
        }

		public bool StopScriptRecording(int id)
        {
			return (m_mode64 ? Pac64StopScriptRecording64(id) : Pac64StopScriptRecording32(id));
        }

		public bool SetScriptStepDelay(int id, byte stepDelay)
        {
			return (m_mode64 ? Pac64SetScriptStepDelay64(id, stepDelay) : Pac64SetScriptStepDelay32(id, stepDelay));
        }

		public bool RunScript(int id)
        {
			return (m_mode64 ? Pac64RunScript64(id) : Pac64RunScript32(id));
        }

		public bool ClearFlash(int id)
        {
			return (m_mode64 ? Pac64ClearFlash64(id) : Pac64ClearFlash32(id));
        }

		public bool SetDeviceId(int id, int newId)
        {
			return (m_mode64 ? Pac64SetDeviceId64(id, newId) : Pac64SetDeviceId32(id, newId));
        }

		public DeviceType GetDeviceType(int id)
        {
			return (DeviceType)(m_mode64 ? PacGetDeviceType64(id) : PacGetDeviceType32(id));
        }

		public int GetVendorId(int id)
        {
			return (m_mode64 ? PacGetVendorId64(id) : PacGetVendorId32(id));
        }

        public int GetProductId(int id)
        {
            return (m_mode64 ? PacGetProductId64(id) : PacGetProductId32(id));
        }

        public int GetVersionNumber(int id)
        {
            return (m_mode64 ? PacGetVersionNumber64(id) : PacGetVersionNumber32(id));
        }

        public string GetVendorName(int id)
        {
            StringBuilder sb = new StringBuilder(256);

            if(m_mode64)
                PacGetVendorName64(id, sb);
            else
                PacGetVendorName32(id, sb);

            return sb.ToString();
        }

        public string GetProductName(int id)
        {
            StringBuilder sb = new StringBuilder(256);

            if (m_mode64)
                PacGetProductName64(id, sb);
            else
                PacGetProductName32(id, sb);

            return sb.ToString();
        }

        public string GetSerialNumber(int id)
        {
            StringBuilder sb = new StringBuilder(256);

            if (m_mode64)
                PacGetSerialNumber64(id, sb);
            else
                PacGetSerialNumber32(id, sb);

            return sb.ToString();
        }

        public string GetDevicePath(int id)
        {
            StringBuilder sb = new StringBuilder(256);

            if (m_mode64)
                PacGetDevicePath64(id, sb);
            else
                PacGetDevicePath32(id, sb);

            return sb.ToString();
        }

        public bool ProgramUHid(int id, string fileName)
        {
            StringBuilder sb = new StringBuilder(fileName);

            return (m_mode64 ? PacProgramUHid64(id, sb) : PacProgramUHid32(id, sb));
        }
		
		public bool SetServoStik4Way()
		{
			return (m_mode64 ? PacSetServoStik4Way64() : PacSetServoStik4Way32());
		}

		public bool SetServoStik8Way()
		{
			return (m_mode64 ? PacSetServoStik8Way64() : PacSetServoStik8Way32());
		}

        public bool SetUSBButtonConfigurePermanent(int id, byte[] data)
        {
			return (m_mode64 ? USBButtonConfigurePermanent64(id, data) : USBButtonConfigurePermanent32(id, data));
        }

        public bool SetUSBButtonConfigureTemporary(int id, byte[] data)
        {
			return (m_mode64 ? USBButtonConfigureTemporary64(id, data) : USBButtonConfigureTemporary32(id, data));
        }

        public bool SetUSBButtonConfigureColor(int id, byte red, byte green, byte blue)
        {
			return (m_mode64 ? USBButtonConfigureColor64(id, red, green, blue) : USBButtonConfigureColor32(id, red, green, blue));
        }

		public bool GetUSBButtonState(int id, ref bool state)
        {
			return (m_mode64 ? USBButtonGetState64(id, ref state) : USBButtonGetState32(id, ref state));
        }

        public int NumDevices
        {
            get { return m_numDevices; }
        }

        private bool Is64BitMode()
        {
            return Marshal.SizeOf(typeof(IntPtr)) == 8;
        }
    }
}
