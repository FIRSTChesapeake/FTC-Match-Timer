using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public partial class frmSetScoringServer : DevComponents.DotNetBar.OfficeForm
    {
        public frmSetScoringServer()
        {
            InitializeComponent();
            txtIP.Text = Properties.Settings.Default.ScoringServerLocation;
        }

        private void HandleButtons(object sender, EventArgs e)
        {
            if (sender.Equals(btnSave))
            {
                if (!txtIP.MaskCompleted)
                {
                    string msg = "IP Address Invalid.";
                    MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Properties.Settings.Default.ScoringServerLocation = txtIP.Text;
                Properties.Settings.Default.ScoringScroll = (int)numScrollSpeed.Value;
                Properties.Settings.Default.Save();
            }
            else if(Properties.Settings.Default.ScoringServerLocation != "")
            {
                string msg = "Would you like to forget the current entry?";
                DialogResult dr = MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    Properties.Settings.Default.ScoringServerLocation = "";
                    Properties.Settings.Default.Save();
                }
            }
            this.Close();
        }
    }
}