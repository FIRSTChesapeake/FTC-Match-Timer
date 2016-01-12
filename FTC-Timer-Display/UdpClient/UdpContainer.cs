using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FTC_Timer_Display.myUdpClient
{
    [Serializable]
    class UdpContainer
    {
        public IPEndPoint fromEndpoint = null;

        public UdpPackageTypes packageType = UdpPackageTypes.None;
        public object package = null;

        public UdpContainer() { }
        public UdpContainer(UdpPackageTypes type, object pack)
        {
            this.packageType = type;
            this.package = pack;
        }

        public enum UdpPackageTypes
        {
            None,
            MatchData,
            FieldConfig,
            PitData,
            ClientReply
        }
    }
}
