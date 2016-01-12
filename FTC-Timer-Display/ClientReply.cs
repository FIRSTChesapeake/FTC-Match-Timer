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

        public IPEndPoint replyEndpoint = null;

        public ClientReply(int divID, int fieldID, IPEndPoint endpoint, long verify)
        {
            this.divID = divID;
            this.fieldID = fieldID;
            this.replyEndpoint = endpoint;
            this.verification = verify;
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
