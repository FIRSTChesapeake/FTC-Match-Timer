using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace FTC_Timer_Display.SettingsControls
{
    public partial class CtrlLoggingSettings : UserControl
    {
        public CtrlLoggingSettings()
        {
            InitializeComponent();
            if (GeneralFunctions.AppFunctions.isRunningMode)
            {
                LoadFileLocations();
                LoadSettings();
            }
        }

        private void LoadFileLocations()
        {
            List<string> files = LogMgr.LogLocation;
            foreach (string s in files)
            {
                LinkLabel l = new LinkLabel();
                l.Text = s;
                l.Tag = s;
                l.AutoSize = true;
                l.LinkClicked += LinkClick;
                flowFiles.Controls.Add(l);
            }
        }

        private void LoadSettings()
        {
            flowChecks.Controls.Clear();
            foreach (SettingsProperty p in Properties.logging.Default.Properties)
            {
                if (p.PropertyType != typeof(bool)) continue;
                CheckBox c = new CheckBox();
                c.Text = LogMgr.displayString(p.Name);
                c.Tag = p;
                c.AutoSize = true;
                c.Checked = (bool)Properties.logging.Default[p.Name];
                c.CheckedChanged += CheckChange;
                flowChecks.Controls.Add(c);
            }

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void SaveSettings()
        {
            foreach (CheckBox c in flowChecks.Controls)
            {
                SettingsProperty sp = (SettingsProperty)c.Tag;
                Properties.logging.Default[sp.Name] = c.Checked;
            }
            Properties.logging.Default.Save();
            LoadSettings();
        }

        public bool hasChanges
        {
            get
            {
                return btnSave.Enabled;
            }
        }

        private void ButtonHandler(object sender, EventArgs e)
        {
            if (sender.Equals(btnSave))
            {
                SaveSettings();
            }
            else if (sender.Equals(btnCancel))
            {
                LoadSettings();
            }
            else if (sender.Equals(btnDefaults))
            {
                Properties.logging.Default.Reset();
                Properties.logging.Default.Save();
                LoadSettings();
            }
        }

        private void CheckChange(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void LinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel l = (LinkLabel)sender;
            string filePath = (string)l.Tag;
            string dirPath = Path.GetDirectoryName(filePath);
            Process.Start(dirPath);
        }

    }
}
