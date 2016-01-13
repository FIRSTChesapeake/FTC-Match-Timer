using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FTC_Timer_Display
{
    [Serializable]
    public class ClientReply
    {
        public int divID = 0;
        public int fieldID = 0;

        public long verification = -1;

        public Version clientVersion;
        public InitialData.RunType runType = InitialData.RunType.None;
        public frmDisplay.DisplayStatus displayStatus = frmDisplay.DisplayStatus.Hide;

        public IPEndPoint fromEndpoint = null;


        public ClientReply(SingleClient client)
        {
            this.divID = client.matchData.divID;
            this.fieldID = client.matchData.fieldID;
            this.fromEndpoint = client.matchData.fromEndpoint;
            this.verification = client.matchData.serverHeartbeat;
            this.clientVersion = GeneralFunctions.AppFunctions.appVersion;
        }

        public int receivePort
        {
            get
            {
                return myUdpClient.UdpComms.CreateRecvPort(this.divID, this.fieldID);
            }
        }
    }
}
