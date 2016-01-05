using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Timer_Display.myUdpClient
{
    [Serializable]
    class UdpContainer
    {
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
            PitData
        }
    }
}
