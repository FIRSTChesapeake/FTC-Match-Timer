using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FTC_Timer_Display
{
    public class UdpComms
    {
        public static readonly int udpPortSend = 5400;
        public int udpPortRecv{ get; private set; }
        private IPEndPoint Broadcast = new IPEndPoint(IPAddress.Broadcast, udpPortSend);

        private bool _listening = false;
        private UdpClient _udp = null;
        private IAsyncResult _ar = null;

        public event EventHandler<MatchData> NewMatchData;

        public bool isListening { get { return _listening; } }

        public UdpComms(int divID, int fieldID, EventHandler<MatchData> NewDataHandler)
        {
            NewMatchData += NewDataHandler;
            udpPortRecv = CreateRecvPort(divID, fieldID);
            ConfigurePort();
        }

        public static int CreateRecvPort(int div, int field)
        {
            int portMod = (10 * div) + field;
            return udpPortSend + portMod;
        }

        private void ConfigurePort()
        {
            _udp = new UdpClient(udpPortRecv);
            _udp.EnableBroadcast = true;
        }

        public void ListenControl(bool status)
        {
            if (status)
            {
                if (!_listening)
                {
                    if (_udp.Client == null) ConfigurePort();
                    StartListening();
                }
            }
            else
            {
                if (_udp != null)
                {
                    _listening = false;
                    _udp.Close();
                }
            }
        }

        private void StartListening()
        {
            _listening = true;
            _ar = _udp.BeginReceive(ReceiveCallback, null);
        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                MatchData data = null;
                IPEndPoint ip = new IPEndPoint(IPAddress.Any, udpPortRecv);
                byte[] bytes = _udp.EndReceive(ar, ref ip);
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(bytes, 0, bytes.Length);
                    ms.Seek(0, SeekOrigin.Begin);
                    data = (MatchData)bf.Deserialize(ms);
                }
                if (NewMatchData != null && data != null)
                {
                    EventHandler<MatchData> handler = NewMatchData;
                    handler(this, data);
                }
                StartListening();
            }
            catch (ObjectDisposedException)
            {

            }
        }

        public void BroadcastMatchData(MatchData data, int fieldPort)
        {
            IPEndPoint sendTo = new IPEndPoint(IPAddress.Broadcast, fieldPort);
            SendObject(data, sendTo);
        }

        private void SendObject(Object data, IPEndPoint sendTo)
        {
            if (_udp != null && _udp.Client != null)
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream())
                {
                    bf.Serialize(ms, data);
                    byte[] bytes = ms.ToArray();
                    _udp.Send(bytes, bytes.Length, sendTo);
                }
            }
        }
    }
}
