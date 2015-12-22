namespace FTC_Timer_Display
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.grpSoundOptions = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoSoundOff = new System.Windows.Forms.RadioButton();
            this.rdoSoundLocal = new System.Windows.Forms.RadioButton();
            this.rdoSoundRemote = new System.Windows.Forms.RadioButton();
            this.grpPit = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoPitOff = new System.Windows.Forms.RadioButton();
            this.rdoPitActive = new System.Windows.Forms.RadioButton();
            this.rdoPitAll = new System.Windows.Forms.RadioButton();
            this.linkSetScoring = new System.Windows.Forms.LinkLabel();
            this.grpBranding = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.picCurrentLogo = new System.Windows.Forms.PictureBox();
            this.btnChangeLogo = new DevComponents.DotNetBar.ButtonX();
            this.btnResetLogo = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDateTime = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkAutoElimTimeout = new System.Windows.Forms.CheckBox();
            this.chkShowHelp = new System.Windows.Forms.CheckBox();
            this.toolTipMgr = new DevComponents.DotNetBar.SuperTooltip();
            this.chkPreventMovement = new System.Windows.Forms.CheckBox();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.grpSoundOptions.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.grpPit.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.grpBranding.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentLogo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSoundOptions
            // 
            this.grpSoundOptions.Controls.Add(this.flowLayoutPanel2);
            this.grpSoundOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSoundOptions.Location = new System.Drawing.Point(3, 3);
            this.grpSoundOptions.Name = "grpSoundOptions";
            this.grpSoundOptions.Size = new System.Drawing.Size(324, 127);
            this.grpSoundOptions.TabIndex = 1;
            this.grpSoundOptions.TabStop = false;
            this.grpSoundOptions.Text = "Sound Location";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rdoSoundOff);
            this.flowLayoutPanel2.Controls.Add(this.rdoSoundLocal);
            this.flowLayoutPanel2.Controls.Add(this.rdoSoundRemote);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(318, 108);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // rdoSoundOff
            // 
            this.rdoSoundOff.AutoSize = true;
            this.rdoSoundOff.Checked = true;
            this.rdoSoundOff.Location = new System.Drawing.Point(3, 3);
            this.rdoSoundOff.Name = "rdoSoundOff";
            this.rdoSoundOff.Size = new System.Drawing.Size(39, 17);
            this.toolTipMgr.SetSuperTooltip(this.rdoSoundOff, new DevComponents.DotNetBar.SuperTooltipInfo("Sound Location - Off", "", "No sound will be played anywhere.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.rdoSoundOff.TabIndex = 0;
            this.rdoSoundOff.TabStop = true;
            this.rdoSoundOff.Text = "Off";
            this.rdoSoundOff.UseVisualStyleBackColor = true;
            // 
            // rdoSoundLocal
            // 
            this.rdoSoundLocal.AutoSize = true;
            this.rdoSoundLocal.Location = new System.Drawing.Point(3, 26);
            this.rdoSoundLocal.Name = "rdoSoundLocal";
            this.rdoSoundLocal.Size = new System.Drawing.Size(58, 17);
            this.toolTipMgr.SetSuperTooltip(this.rdoSoundLocal, new DevComponents.DotNetBar.SuperTooltipInfo("Sound Location - Locally", "", "Sound will be played on this computer.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.rdoSoundLocal.TabIndex = 1;
            this.rdoSoundLocal.Text = "Locally";
            this.rdoSoundLocal.UseVisualStyleBackColor = true;
            // 
            // rdoSoundRemote
            // 
            this.rdoSoundRemote.AutoSize = true;
            this.rdoSoundRemote.Location = new System.Drawing.Point(3, 49);
            this.rdoSoundRemote.Name = "rdoSoundRemote";
            this.rdoSoundRemote.Size = new System.Drawing.Size(69, 17);
            this.toolTipMgr.SetSuperTooltip(this.rdoSoundRemote, new DevComponents.DotNetBar.SuperTooltipInfo("Sound Location - Remotely", "", resources.GetString("rdoSoundRemote.SuperTooltip"), null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.rdoSoundRemote.TabIndex = 2;
            this.rdoSoundRemote.Text = "Remotely";
            this.rdoSoundRemote.UseVisualStyleBackColor = true;
            // 
            // grpPit
            // 
            this.grpPit.Controls.Add(this.flowLayoutPanel5);
            this.grpPit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPit.Enabled = false;
            this.grpPit.Location = new System.Drawing.Point(333, 3);
            this.grpPit.Name = "grpPit";
            this.grpPit.Size = new System.Drawing.Size(325, 127);
            this.grpPit.TabIndex = 7;
            this.grpPit.TabStop = false;
            this.grpPit.Text = "Pit Display";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label3);
            this.flowLayoutPanel5.Controls.Add(this.rdoPitOff);
            this.flowLayoutPanel5.Controls.Add(this.rdoPitActive);
            this.flowLayoutPanel5.Controls.Add(this.rdoPitAll);
            this.flowLayoutPanel5.Controls.Add(this.linkSetScoring);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(319, 108);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "This feature is disabled. Coming soon!";
            // 
            // rdoPitOff
            // 
            this.rdoPitOff.AutoSize = true;
            this.rdoPitOff.Checked = true;
            this.rdoPitOff.Location = new System.Drawing.Point(3, 16);
            this.rdoPitOff.Name = "rdoPitOff";
            this.rdoPitOff.Size = new System.Drawing.Size(39, 17);
            this.rdoPitOff.TabIndex = 0;
            this.rdoPitOff.TabStop = true;
            this.rdoPitOff.Text = "Off";
            this.rdoPitOff.UseVisualStyleBackColor = true;
            // 
            // rdoPitActive
            // 
            this.rdoPitActive.AutoSize = true;
            this.rdoPitActive.Location = new System.Drawing.Point(3, 39);
            this.rdoPitActive.Name = "rdoPitActive";
            this.rdoPitActive.Size = new System.Drawing.Size(79, 17);
            this.rdoPitActive.TabIndex = 1;
            this.rdoPitActive.Text = "Active Only";
            this.rdoPitActive.UseVisualStyleBackColor = true;
            // 
            // rdoPitAll
            // 
            this.rdoPitAll.AutoSize = true;
            this.rdoPitAll.Location = new System.Drawing.Point(3, 62);
            this.rdoPitAll.Name = "rdoPitAll";
            this.rdoPitAll.Size = new System.Drawing.Size(66, 17);
            this.rdoPitAll.TabIndex = 2;
            this.rdoPitAll.Text = "All Fields";
            this.rdoPitAll.UseVisualStyleBackColor = true;
            // 
            // linkSetScoring
            // 
            this.linkSetScoring.AutoSize = true;
            this.linkSetScoring.Location = new System.Drawing.Point(3, 82);
            this.linkSetScoring.Name = "linkSetScoring";
            this.linkSetScoring.Size = new System.Drawing.Size(96, 13);
            this.linkSetScoring.TabIndex = 3;
            this.linkSetScoring.TabStop = true;
            this.linkSetScoring.Text = "Set Scoring Server";
            // 
            // grpBranding
            // 
            this.grpBranding.Controls.Add(this.tableLayoutPanel1);
            this.grpBranding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBranding.Location = new System.Drawing.Point(3, 136);
            this.grpBranding.Name = "grpBranding";
            this.grpBranding.Size = new System.Drawing.Size(324, 279);
            this.grpBranding.TabIndex = 8;
            this.grpBranding.TabStop = false;
            this.grpBranding.Text = "Branding";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picCurrentLogo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeLogo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnResetLogo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkDateTime, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PNG files only. 144x144 px recommended.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picCurrentLogo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.picCurrentLogo, 2);
            this.picCurrentLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCurrentLogo.Image = global::FTC_Timer_Display.Properties.Resources.vaflogo;
            this.picCurrentLogo.Location = new System.Drawing.Point(3, 29);
            this.picCurrentLogo.Name = "picCurrentLogo";
            this.picCurrentLogo.Size = new System.Drawing.Size(312, 139);
            this.picCurrentLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurrentLogo.TabIndex = 1;
            this.picCurrentLogo.TabStop = false;
            // 
            // btnChangeLogo
            // 
            this.btnChangeLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeLogo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChangeLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeLogo.Location = new System.Drawing.Point(3, 197);
            this.btnChangeLogo.Name = "btnChangeLogo";
            this.btnChangeLogo.Size = new System.Drawing.Size(153, 60);
            this.btnChangeLogo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChangeLogo.TabIndex = 2;
            this.btnChangeLogo.Text = "Change";
            this.btnChangeLogo.Click += new System.EventHandler(this.LogoChangeHandler);
            // 
            // btnResetLogo
            // 
            this.btnResetLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnResetLogo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnResetLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetLogo.Location = new System.Drawing.Point(162, 197);
            this.btnResetLogo.Name = "btnResetLogo";
            this.btnResetLogo.Size = new System.Drawing.Size(153, 60);
            this.btnResetLogo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnResetLogo.TabIndex = 3;
            this.btnResetLogo.Text = "Reset";
            this.btnResetLogo.Click += new System.EventHandler(this.LogoChangeHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Large images can cause long load times. Use wisely.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkDateTime
            // 
            this.chkDateTime.AutoSize = true;
            this.chkDateTime.Checked = true;
            this.chkDateTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDateTime.Location = new System.Drawing.Point(3, 174);
            this.chkDateTime.Name = "chkDateTime";
            this.chkDateTime.Size = new System.Drawing.Size(153, 17);
            this.chkDateTime.TabIndex = 5;
            this.chkDateTime.Text = "Show Date && Time";
            this.chkDateTime.UseVisualStyleBackColor = true;
            this.chkDateTime.CheckedChanged += new System.EventHandler(this.chkDateTime_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.grpBranding, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.grpPit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpSoundOptions, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(661, 418);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(333, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 279);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Options";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkAutoElimTimeout);
            this.flowLayoutPanel1.Controls.Add(this.chkShowHelp);
            this.flowLayoutPanel1.Controls.Add(this.line1);
            this.flowLayoutPanel1.Controls.Add(this.chkPreventMovement);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(319, 260);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkAutoElimTimeout
            // 
            this.chkAutoElimTimeout.AutoSize = true;
            this.chkAutoElimTimeout.Checked = true;
            this.chkAutoElimTimeout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoElimTimeout.Location = new System.Drawing.Point(3, 3);
            this.chkAutoElimTimeout.Name = "chkAutoElimTimeout";
            this.chkAutoElimTimeout.Size = new System.Drawing.Size(246, 17);
            this.toolTipMgr.SetSuperTooltip(this.chkAutoElimTimeout, new DevComponents.DotNetBar.SuperTooltipInfo("Automatically start Field Timeout in Eliminations", "", resources.GetString("chkAutoElimTimeout.SuperTooltip"), null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.chkAutoElimTimeout.TabIndex = 0;
            this.chkAutoElimTimeout.Text = "Automatically start Field Timeout in Eliminations";
            this.chkAutoElimTimeout.UseVisualStyleBackColor = true;
            this.chkAutoElimTimeout.CheckedChanged += new System.EventHandler(this.chkAutoElimTimeout_CheckedChanged);
            // 
            // chkShowHelp
            // 
            this.chkShowHelp.AutoSize = true;
            this.chkShowHelp.Location = new System.Drawing.Point(3, 26);
            this.chkShowHelp.Name = "chkShowHelp";
            this.chkShowHelp.Size = new System.Drawing.Size(218, 17);
            this.chkShowHelp.TabIndex = 1;
            this.chkShowHelp.Text = "Show Hover Help throughout application";
            this.chkShowHelp.UseVisualStyleBackColor = true;
            this.chkShowHelp.CheckedChanged += new System.EventHandler(this.chkShowHelp_CheckedChanged);
            // 
            // toolTipMgr
            // 
            this.toolTipMgr.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Green);
            this.toolTipMgr.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // chkPreventMovement
            // 
            this.chkPreventMovement.AutoSize = true;
            this.chkPreventMovement.Checked = true;
            this.chkPreventMovement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreventMovement.Location = new System.Drawing.Point(3, 78);
            this.chkPreventMovement.Name = "chkPreventMovement";
            this.chkPreventMovement.Size = new System.Drawing.Size(276, 30);
            this.toolTipMgr.SetSuperTooltip(this.chkPreventMovement, new DevComponents.DotNetBar.SuperTooltipInfo("Prevent Field Changes During Active Match", "", resources.GetString("chkPreventMovement.SuperTooltip"), null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.chkPreventMovement.TabIndex = 2;
            this.chkPreventMovement.Text = "Prevent Field Selection Changes during active match\r\n(this is highly recommended)" +
    "";
            this.chkPreventMovement.UseVisualStyleBackColor = true;
            this.chkPreventMovement.CheckedChanged += new System.EventHandler(this.chkPreventMovement_CheckedChanged);
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(3, 49);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(310, 23);
            this.line1.TabIndex = 4;
            this.line1.Text = "line1";
            // 
            // frmSettings
            // 
            this.ClientSize = new System.Drawing.Size(661, 418);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.VisibleChanged += new System.EventHandler(this.frmSettings_VisibleChanged);
            this.grpSoundOptions.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.grpPit.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.grpBranding.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentLogo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSoundOptions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rdoSoundOff;
        private System.Windows.Forms.RadioButton rdoSoundLocal;
        private System.Windows.Forms.RadioButton rdoSoundRemote;
        private System.Windows.Forms.GroupBox grpPit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.RadioButton rdoPitOff;
        private System.Windows.Forms.RadioButton rdoPitActive;
        private System.Windows.Forms.RadioButton rdoPitAll;
        private System.Windows.Forms.LinkLabel linkSetScoring;
        private System.Windows.Forms.GroupBox grpBranding;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCurrentLogo;
        private DevComponents.DotNetBar.ButtonX btnChangeLogo;
        private DevComponents.DotNetBar.ButtonX btnResetLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkAutoElimTimeout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDateTime;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.SuperTooltip toolTipMgr;
        private System.Windows.Forms.CheckBox chkShowHelp;
        private System.Windows.Forms.CheckBox chkPreventMovement;
        private DevComponents.DotNetBar.Controls.Line line1;
    }
}