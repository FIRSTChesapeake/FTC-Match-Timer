using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Reflection;

namespace FTC_Timer_Display.myUdpClient
{
    public class myUdpException : SocketException
    {
        public string appMessage = "";
        public bool isFatal = true;

        public string fullErrorString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("There was a fatal error configuring the UDP port used to send and receive data.");
                sb.AppendFormat("Message: {0}\n", this.appMessage);
                sb.AppendLine("Please see the log for more details.");
                sb.AppendLine();
                if (isFatal) sb.AppendLine("The application must now quit.");
                return sb.ToString();
            }
        }


        public myUdpException()
            : base() { }

        public static t Make<t>(SocketException ex) where t : SocketException
        {
            var type = typeof(t);
            var inst = Activator.CreateInstance(type);

            PropertyInfo[] props = type.GetProperties();
            foreach (var prop in props)
            {
                try
                {
                    prop.SetValue(inst, prop.GetValue(ex, null), null);
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return (t)inst;
        }
    }


}
