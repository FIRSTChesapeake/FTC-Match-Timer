using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC_Timer_Display
{
    public partial class SingleClientDisplay : UserControl
    {
        public SingleClient myClient { get; private set; }

        private System.Timers.Timer timer = new System.Timers.Timer();

        public SingleClientDisplay(SingleClient client)
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Elapsed += timer_Elapsed;
            lblFieldName.Text = string.Format("FIELD {0}", client.matchData.fieldID.ToString());
            myClient = client;
            timer.Start();
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            lblState.Text = myClient.matchData.matchStatus.ToString();
            if (myClient.matchData.isIdle)
            {
                picInd.Image = Properties.Resources.indicator_red;
            }
            else
            {
                picInd.Image = Properties.Resources.indicator_green;
            }
        }
    }
}
