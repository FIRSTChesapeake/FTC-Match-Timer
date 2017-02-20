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
            this.flowSoundLocation = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoSoundOff = new System.Windows.Forms.RadioButton();
            this.rdoSoundLocal = new System.Windows.Forms.RadioButton();
            this.rdoSoundRemote = new System.Windows.Forms.RadioButton();
            this.rdoSoundBoth = new System.Windows.Forms.RadioButton();
            this.flowPit = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoPitOff = new System.Windows.Forms.RadioButton();
            this.rdoPitActive = new System.Windows.Forms.RadioButton();
            this.rdoPitAll = new System.Windows.Forms.RadioButton();
            this.linkSetScoring = new System.Windows.Forms.LinkLabel();
            this.tableBranding = new System.Windows.Forms.TableLayoutPanel();
            this.picCurrentLogo1 = new System.Windows.Forms.PictureBox();
            this.chkDateTime = new System.Windows.Forms.CheckBox();
            this.lblBrandingWarnings = new DevComponents.DotNetBar.LabelX();
            this.ctrlHeader4 = new FTC_Timer_Display.CtrlHeader();
            this.btnChangeLogo1 = new DevComponents.DotNetBar.ButtonX();
            this.btnResetLogo = new DevComponents.DotNetBar.ButtonX();
            this.picCurrentLogo2 = new System.Windows.Forms.PictureBox();
            this.btnChangeLogo2 = new DevComponents.DotNetBar.ButtonX();
            this.tableAppSettings = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.ctrlHeader2 = new FTC_Timer_Display.CtrlHeader();
            this.ctrlHeader3 = new FTC_Timer_Display.CtrlHeader();
            this.flowOtherOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.chkShowHelp = new System.Windows.Forms.CheckBox();
            this.headerServerOptions = new FTC_Timer_Display.CtrlHeader();
            this.flowServerOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.chkPreventMovement = new System.Windows.Forms.CheckBox();
            this.chkUseLargeActive = new System.Windows.Forms.CheckBox();
            this.chkShowFieldNumber = new System.Windows.Forms.CheckBox();
            this.toolTipMgr = new DevComponents.DotNetBar.SuperTooltip();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.soundControl = new FTC_Timer_Display.SettingsControls.CtrlSoundTest();
            this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel6 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.loggingControl = new FTC_Timer_Display.SettingsControls.CtrlLoggingSettings();
            this.superTabItem6 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.timingsControl = new FTC_Timer_Display.SettingsControls.CtrlTimings();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem5 = new DevComponents.DotNetBar.SuperTabItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.chkExtraSecond = new System.Windows.Forms.CheckBox();
            this.flowSoundLocation.SuspendLayout();
            this.flowPit.SuspendLayout();
            this.tableBranding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentLogo2)).BeginInit();
            this.tableAppSettings.SuspendLayout();
            this.flowOtherOptions.SuspendLayout();
            this.flowServerOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.superTabControlPanel6.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowSoundLocation
            // 
            this.flowSoundLocation.Controls.Add(this.rdoSoundOff);
            this.flowSoundLocation.Controls.Add(this.rdoSoundLocal);
            this.flowSoundLocation.Controls.Add(this.rdoSoundRemote);
            this.flowSoundLocation.Controls.Add(this.rdoSoundBoth);
            this.flowSoundLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSoundLocation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSoundLocation.Location = new System.Drawing.Point(3, 28);
            this.flowSoundLocation.Name = "flowSoundLocation";
            this.flowSoundLocation.Size = new System.Drawing.Size(269, 108);
            this.flowSoundLocation.TabIndex = 0;
            this.flowSoundLocation.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
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
            // rdoSoundBoth
            // 
            this.rdoSoundBoth.AutoSize = true;
            this.rdoSoundBoth.Location = new System.Drawing.Point(3, 72);
            this.rdoSoundBoth.Name = "rdoSoundBoth";
            this.rdoSoundBoth.Size = new System.Drawing.Size(114, 17);
            this.rdoSoundBoth.TabIndex = 3;
            this.rdoSoundBoth.TabStop = true;
            this.rdoSoundBoth.Text = "Locally && Remotely";
            this.rdoSoundBoth.UseVisualStyleBackColor = true;
            // 
            // flowPit
            // 
            this.flowPit.Controls.Add(this.label3);
            this.flowPit.Controls.Add(this.rdoPitOff);
            this.flowPit.Controls.Add(this.rdoPitActive);
            this.flowPit.Controls.Add(this.rdoPitAll);
            this.flowPit.Controls.Add(this.linkSetScoring);
            this.flowPit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPit.Enabled = false;
            this.flowPit.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPit.Location = new System.Drawing.Point(278, 28);
            this.flowPit.Name = "flowPit";
            this.flowPit.Size = new System.Drawing.Size(269, 108);
            this.flowPit.TabIndex = 0;
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
            // tableBranding
            // 
            this.tableBranding.ColumnCount = 2;
            this.tableBranding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBranding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBranding.Controls.Add(this.picCurrentLogo1, 0, 2);
            this.tableBranding.Controls.Add(this.chkDateTime, 0, 6);
            this.tableBranding.Controls.Add(this.lblBrandingWarnings, 0, 1);
            this.tableBranding.Controls.Add(this.ctrlHeader4, 0, 0);
            this.tableBranding.Controls.Add(this.btnChangeLogo1, 0, 3);
            this.tableBranding.Controls.Add(this.btnResetLogo, 1, 6);
            this.tableBranding.Controls.Add(this.picCurrentLogo2, 1, 2);
            this.tableBranding.Controls.Add(this.btnChangeLogo2, 1, 3);
            this.tableBranding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBranding.Location = new System.Drawing.Point(0, 0);
            this.tableBranding.Name = "tableBranding";
            this.tableBranding.RowCount = 7;
            this.tableBranding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableBranding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableBranding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableBranding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBranding.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableBranding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBranding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBranding.Size = new System.Drawing.Size(550, 418);
            this.tableBranding.TabIndex = 0;
            // 
            // picCurrentLogo1
            // 
            this.picCurrentLogo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCurrentLogo1.Image = global::FTC_Timer_Display.Properties.Resources.FCLogoBlack;
            this.picCurrentLogo1.Location = new System.Drawing.Point(3, 78);
            this.picCurrentLogo1.Name = "picCurrentLogo1";
            this.picCurrentLogo1.Size = new System.Drawing.Size(269, 139);
            this.picCurrentLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurrentLogo1.TabIndex = 1;
            this.picCurrentLogo1.TabStop = false;
            // 
            // chkDateTime
            // 
            this.chkDateTime.AutoSize = true;
            this.chkDateTime.Checked = true;
            this.chkDateTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDateTime.Location = new System.Drawing.Point(3, 381);
            this.chkDateTime.Name = "chkDateTime";
            this.chkDateTime.Size = new System.Drawing.Size(269, 34);
            this.chkDateTime.TabIndex = 5;
            this.chkDateTime.Text = "Show Date && Time on Clock Display";
            this.chkDateTime.UseVisualStyleBackColor = true;
            this.chkDateTime.CheckedChanged += new System.EventHandler(this.chkDateTime_CheckedChanged);
            // 
            // lblBrandingWarnings
            // 
            // 
            // 
            // 
            this.lblBrandingWarnings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableBranding.SetColumnSpan(this.lblBrandingWarnings, 2);
            this.lblBrandingWarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrandingWarnings.Location = new System.Drawing.Point(3, 28);
            this.lblBrandingWarnings.Name = "lblBrandingWarnings";
            this.lblBrandingWarnings.Size = new System.Drawing.Size(544, 44);
            this.lblBrandingWarnings.TabIndex = 6;
            this.lblBrandingWarnings.Text = "PNG files only. 144x144 px recommended.\r\nLarge images can cause long load times. " +
    "Use wisely.\r\nBranding is only available when a local clock is in use and must be" +
    " set on every clock locally.";
            this.lblBrandingWarnings.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblBrandingWarnings.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ctrlHeader4
            // 
            // 
            // 
            // 
            this.ctrlHeader4.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHeader4.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHeader4.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.ctrlHeader4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableBranding.SetColumnSpan(this.ctrlHeader4, 2);
            this.ctrlHeader4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader4.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader4.Name = "ctrlHeader4";
            this.ctrlHeader4.Size = new System.Drawing.Size(544, 19);
            this.ctrlHeader4.TabIndex = 7;
            this.ctrlHeader4.Text = "Branding Options";
            this.ctrlHeader4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnChangeLogo1
            // 
            this.btnChangeLogo1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeLogo1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChangeLogo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeLogo1.Location = new System.Drawing.Point(3, 223);
            this.btnChangeLogo1.Name = "btnChangeLogo1";
            this.btnChangeLogo1.Size = new System.Drawing.Size(269, 34);
            this.btnChangeLogo1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChangeLogo1.TabIndex = 2;
            this.btnChangeLogo1.Text = "Change";
            this.btnChangeLogo1.Click += new System.EventHandler(this.LogoChangeHandler);
            // 
            // btnResetLogo
            // 
            this.btnResetLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnResetLogo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnResetLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetLogo.Location = new System.Drawing.Point(278, 381);
            this.btnResetLogo.Name = "btnResetLogo";
            this.btnResetLogo.Size = new System.Drawing.Size(269, 34);
            this.btnResetLogo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnResetLogo.TabIndex = 3;
            this.btnResetLogo.Text = "Reset";
            this.btnResetLogo.Click += new System.EventHandler(this.LogoChangeHandler);
            // 
            // picCurrentLogo2
            // 
            this.picCurrentLogo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCurrentLogo2.Image = global::FTC_Timer_Display.Properties.Resources.FCLogoBlack;
            this.picCurrentLogo2.Location = new System.Drawing.Point(278, 78);
            this.picCurrentLogo2.Name = "picCurrentLogo2";
            this.picCurrentLogo2.Size = new System.Drawing.Size(269, 139);
            this.picCurrentLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurrentLogo2.TabIndex = 8;
            this.picCurrentLogo2.TabStop = false;
            // 
            // btnChangeLogo2
            // 
            this.btnChangeLogo2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeLogo2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChangeLogo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeLogo2.Location = new System.Drawing.Point(278, 223);
            this.btnChangeLogo2.Name = "btnChangeLogo2";
            this.btnChangeLogo2.Size = new System.Drawing.Size(269, 34);
            this.btnChangeLogo2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChangeLogo2.TabIndex = 9;
            this.btnChangeLogo2.Text = "Change";
            this.btnChangeLogo2.Click += new System.EventHandler(this.LogoChangeHandler);
            // 
            // tableAppSettings
            // 
            this.tableAppSettings.ColumnCount = 2;
            this.tableAppSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAppSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAppSettings.Controls.Add(this.ctrlHeader1, 0, 2);
            this.tableAppSettings.Controls.Add(this.ctrlHeader2, 0, 0);
            this.tableAppSettings.Controls.Add(this.ctrlHeader3, 1, 0);
            this.tableAppSettings.Controls.Add(this.flowOtherOptions, 0, 3);
            this.tableAppSettings.Controls.Add(this.flowPit, 1, 1);
            this.tableAppSettings.Controls.Add(this.flowSoundLocation, 0, 1);
            this.tableAppSettings.Controls.Add(this.headerServerOptions, 1, 2);
            this.tableAppSettings.Controls.Add(this.flowServerOptions, 1, 3);
            this.tableAppSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAppSettings.Location = new System.Drawing.Point(0, 0);
            this.tableAppSettings.Name = "tableAppSettings";
            this.tableAppSettings.RowCount = 4;
            this.tableAppSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableAppSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAppSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableAppSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAppSettings.Size = new System.Drawing.Size(550, 418);
            this.tableAppSettings.TabIndex = 3;
            // 
            // ctrlHeader1
            // 
            // 
            // 
            // 
            this.ctrlHeader1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHeader1.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHeader1.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.ctrlHeader1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader1.Location = new System.Drawing.Point(3, 142);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(269, 19);
            this.ctrlHeader1.TabIndex = 10;
            this.ctrlHeader1.Text = "Application Options";
            this.ctrlHeader1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ctrlHeader2
            // 
            // 
            // 
            // 
            this.ctrlHeader2.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHeader2.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHeader2.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.ctrlHeader2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ctrlHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader2.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader2.Name = "ctrlHeader2";
            this.ctrlHeader2.Size = new System.Drawing.Size(269, 19);
            this.ctrlHeader2.TabIndex = 11;
            this.ctrlHeader2.Text = "Sound Location";
            this.ctrlHeader2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ctrlHeader3
            // 
            // 
            // 
            // 
            this.ctrlHeader3.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHeader3.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHeader3.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.ctrlHeader3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ctrlHeader3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader3.Enabled = false;
            this.ctrlHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader3.Location = new System.Drawing.Point(278, 3);
            this.ctrlHeader3.Name = "ctrlHeader3";
            this.ctrlHeader3.Size = new System.Drawing.Size(269, 19);
            this.ctrlHeader3.TabIndex = 12;
            this.ctrlHeader3.Text = "Pit Display";
            this.ctrlHeader3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // flowOtherOptions
            // 
            this.flowOtherOptions.Controls.Add(this.chkShowHelp);
            this.flowOtherOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowOtherOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowOtherOptions.Location = new System.Drawing.Point(3, 167);
            this.flowOtherOptions.Name = "flowOtherOptions";
            this.flowOtherOptions.Size = new System.Drawing.Size(269, 248);
            this.flowOtherOptions.TabIndex = 0;
            // 
            // chkShowHelp
            // 
            this.chkShowHelp.AutoSize = true;
            this.chkShowHelp.Location = new System.Drawing.Point(3, 3);
            this.chkShowHelp.Name = "chkShowHelp";
            this.chkShowHelp.Size = new System.Drawing.Size(218, 17);
            this.chkShowHelp.TabIndex = 1;
            this.chkShowHelp.Text = "Show Hover Help throughout application";
            this.chkShowHelp.UseVisualStyleBackColor = true;
            this.chkShowHelp.CheckedChanged += new System.EventHandler(this.chkShowHelp_CheckedChanged);
            // 
            // headerServerOptions
            // 
            // 
            // 
            // 
            this.headerServerOptions.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerServerOptions.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.headerServerOptions.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.headerServerOptions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.headerServerOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerServerOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.headerServerOptions.Location = new System.Drawing.Point(278, 142);
            this.headerServerOptions.Name = "headerServerOptions";
            this.headerServerOptions.Size = new System.Drawing.Size(269, 19);
            this.headerServerOptions.TabIndex = 13;
            this.headerServerOptions.Text = "Server / Local Control Options";
            this.headerServerOptions.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // flowServerOptions
            // 
            this.flowServerOptions.Controls.Add(this.chkPreventMovement);
            this.flowServerOptions.Controls.Add(this.chkUseLargeActive);
            this.flowServerOptions.Controls.Add(this.chkShowFieldNumber);
            this.flowServerOptions.Controls.Add(this.chkExtraSecond);
            this.flowServerOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowServerOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowServerOptions.Location = new System.Drawing.Point(278, 167);
            this.flowServerOptions.Name = "flowServerOptions";
            this.flowServerOptions.Size = new System.Drawing.Size(269, 248);
            this.flowServerOptions.TabIndex = 14;
            // 
            // chkPreventMovement
            // 
            this.chkPreventMovement.AutoSize = true;
            this.chkPreventMovement.Checked = true;
            this.chkPreventMovement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreventMovement.Location = new System.Drawing.Point(3, 3);
            this.chkPreventMovement.Name = "chkPreventMovement";
            this.chkPreventMovement.Size = new System.Drawing.Size(231, 30);
            this.toolTipMgr.SetSuperTooltip(this.chkPreventMovement, new DevComponents.DotNetBar.SuperTooltipInfo("Prevent Field Changes During Active Match", "", resources.GetString("chkPreventMovement.SuperTooltip"), null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.chkPreventMovement.TabIndex = 2;
            this.chkPreventMovement.Text = "Prevent Field Selection during active match\r\n(this is highly recommended)";
            this.chkPreventMovement.UseVisualStyleBackColor = true;
            this.chkPreventMovement.CheckedChanged += new System.EventHandler(this.chkPreventMovement_CheckedChanged);
            // 
            // chkUseLargeActive
            // 
            this.chkUseLargeActive.AutoSize = true;
            this.chkUseLargeActive.Checked = true;
            this.chkUseLargeActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseLargeActive.Location = new System.Drawing.Point(3, 39);
            this.chkUseLargeActive.Name = "chkUseLargeActive";
            this.chkUseLargeActive.Size = new System.Drawing.Size(224, 17);
            this.toolTipMgr.SetSuperTooltip(this.chkUseLargeActive, new DevComponents.DotNetBar.SuperTooltipInfo("Use Large Field Status Border on Displays", "", "When enabled, the field displays will display its selection status at the bottom." +
            " If disable, a small indicator will be shown in the top right.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.chkUseLargeActive.TabIndex = 3;
            this.chkUseLargeActive.Text = "Use Large Field Status Border on Displays";
            this.chkUseLargeActive.UseVisualStyleBackColor = true;
            this.chkUseLargeActive.CheckedChanged += new System.EventHandler(this.chkUseLargeActive_CheckedChanged);
            // 
            // chkShowFieldNumber
            // 
            this.chkShowFieldNumber.AutoSize = true;
            this.chkShowFieldNumber.Checked = true;
            this.chkShowFieldNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowFieldNumber.Location = new System.Drawing.Point(3, 62);
            this.chkShowFieldNumber.Name = "chkShowFieldNumber";
            this.chkShowFieldNumber.Size = new System.Drawing.Size(202, 17);
            this.toolTipMgr.SetSuperTooltip(this.chkShowFieldNumber, new DevComponents.DotNetBar.SuperTooltipInfo("Display Field Number on field displays", "", resources.GetString("chkShowFieldNumber.SuperTooltip"), null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.chkShowFieldNumber.TabIndex = 4;
            this.chkShowFieldNumber.Text = "Display Field Number on field displays";
            this.chkShowFieldNumber.UseVisualStyleBackColor = true;
            this.chkShowFieldNumber.CheckedChanged += new System.EventHandler(this.chkDontShowFieldNumber_CheckedChanged);
            // 
            // toolTipMgr
            // 
            this.toolTipMgr.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Green);
            this.toolTipMgr.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Controls.Add(this.superTabControlPanel6);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel5);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(650, 418);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 12;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2,
            this.superTabItem5,
            this.superTabItem3,
            this.superTabItem6,
            this.superTabItem4,
            this.btnClose});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.tableBranding);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(550, 418);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "Branding";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.tableAppSettings);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(550, 418);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "General";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.soundControl);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(550, 418);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.superTabItem4;
            // 
            // soundControl
            // 
            this.soundControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundControl.Location = new System.Drawing.Point(0, 0);
            this.soundControl.Name = "soundControl";
            this.soundControl.Size = new System.Drawing.Size(550, 418);
            this.soundControl.TabIndex = 0;
            // 
            // superTabItem4
            // 
            this.superTabItem4.AttachedControl = this.superTabControlPanel4;
            this.superTabItem4.GlobalItem = false;
            this.superTabItem4.Name = "superTabItem4";
            this.superTabItem4.Text = "Sound Testing";
            // 
            // superTabControlPanel6
            // 
            this.superTabControlPanel6.Controls.Add(this.loggingControl);
            this.superTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel6.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel6.Name = "superTabControlPanel6";
            this.superTabControlPanel6.Size = new System.Drawing.Size(550, 418);
            this.superTabControlPanel6.TabIndex = 0;
            this.superTabControlPanel6.TabItem = this.superTabItem6;
            // 
            // loggingControl
            // 
            this.loggingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loggingControl.Location = new System.Drawing.Point(0, 0);
            this.loggingControl.Name = "loggingControl";
            this.loggingControl.Size = new System.Drawing.Size(550, 418);
            this.loggingControl.TabIndex = 0;
            // 
            // superTabItem6
            // 
            this.superTabItem6.AttachedControl = this.superTabControlPanel6;
            this.superTabItem6.GlobalItem = false;
            this.superTabItem6.Name = "superTabItem6";
            this.superTabItem6.Text = "Logging";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.timingsControl);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(550, 418);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // timingsControl
            // 
            this.timingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingsControl.Location = new System.Drawing.Point(0, 0);
            this.timingsControl.Name = "timingsControl";
            this.timingsControl.Size = new System.Drawing.Size(550, 418);
            this.timingsControl.TabIndex = 10;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Match Timing";
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(550, 418);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.superTabItem5;
            // 
            // superTabItem5
            // 
            this.superTabItem5.AttachedControl = this.superTabControlPanel5;
            this.superTabItem5.GlobalItem = false;
            this.superTabItem5.Name = "superTabItem5";
            this.superTabItem5.Text = "Remote Control";
            // 
            // btnClose
            // 
            this.btnClose.BeginGroup = true;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "Close Window";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkExtraSecond
            // 
            this.chkExtraSecond.AutoSize = true;
            this.chkExtraSecond.Location = new System.Drawing.Point(3, 85);
            this.chkExtraSecond.Name = "chkExtraSecond";
            this.chkExtraSecond.Size = new System.Drawing.Size(148, 17);
            this.toolTipMgr.SetSuperTooltip(this.chkExtraSecond, new DevComponents.DotNetBar.SuperTooltipInfo("Adjust Clock by 1 Second", "", "If your clock seems to be 1 second slow, check this box.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.chkExtraSecond.TabIndex = 5;
            this.chkExtraSecond.Text = "Adjust Clock by 1 Second";
            this.chkExtraSecond.UseVisualStyleBackColor = true;
            this.chkExtraSecond.CheckedChanged += new System.EventHandler(this.chkExtraSecond_CheckedChanged);
            // 
            // frmSettings
            // 
            this.ClientSize = new System.Drawing.Size(650, 418);
            this.Controls.Add(this.superTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.VisibleChanged += new System.EventHandler(this.frmSettings_VisibleChanged);
            this.flowSoundLocation.ResumeLayout(false);
            this.flowSoundLocation.PerformLayout();
            this.flowPit.ResumeLayout(false);
            this.flowPit.PerformLayout();
            this.tableBranding.ResumeLayout(false);
            this.tableBranding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentLogo2)).EndInit();
            this.tableAppSettings.ResumeLayout(false);
            this.flowOtherOptions.ResumeLayout(false);
            this.flowOtherOptions.PerformLayout();
            this.flowServerOptions.ResumeLayout(false);
            this.flowServerOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.superTabControlPanel6.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowSoundLocation;
        private System.Windows.Forms.RadioButton rdoSoundOff;
        private System.Windows.Forms.RadioButton rdoSoundLocal;
        private System.Windows.Forms.RadioButton rdoSoundRemote;
        private System.Windows.Forms.FlowLayoutPanel flowPit;
        private System.Windows.Forms.RadioButton rdoPitOff;
        private System.Windows.Forms.RadioButton rdoPitActive;
        private System.Windows.Forms.RadioButton rdoPitAll;
        private System.Windows.Forms.LinkLabel linkSetScoring;
        private System.Windows.Forms.TableLayoutPanel tableBranding;
        private System.Windows.Forms.PictureBox picCurrentLogo1;
        private DevComponents.DotNetBar.ButtonX btnChangeLogo1;
        private DevComponents.DotNetBar.ButtonX btnResetLogo;
        private System.Windows.Forms.TableLayoutPanel tableAppSettings;
        private System.Windows.Forms.FlowLayoutPanel flowOtherOptions;
        private System.Windows.Forms.CheckBox chkDateTime;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.SuperTooltip toolTipMgr;
        private System.Windows.Forms.CheckBox chkShowHelp;
        private System.Windows.Forms.CheckBox chkPreventMovement;
        private SettingsControls.CtrlTimings timingsControl;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem superTabItem4;
        private SettingsControls.CtrlSoundTest soundControl;
        private CtrlHeader ctrlHeader1;
        private CtrlHeader ctrlHeader2;
        private CtrlHeader ctrlHeader3;
        private CtrlHeader ctrlHeader4;
        private DevComponents.DotNetBar.LabelX lblBrandingWarnings;
        private CtrlHeader headerServerOptions;
        private System.Windows.Forms.FlowLayoutPanel flowServerOptions;
        private System.Windows.Forms.CheckBox chkUseLargeActive;
        private System.Windows.Forms.CheckBox chkShowFieldNumber;
        private System.Windows.Forms.RadioButton rdoSoundBoth;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel6;
        private DevComponents.DotNetBar.SuperTabItem superTabItem6;
        private SettingsControls.CtrlLoggingSettings loggingControl;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private DevComponents.DotNetBar.SuperTabItem superTabItem5;
        private System.Windows.Forms.PictureBox picCurrentLogo2;
        private DevComponents.DotNetBar.ButtonX btnChangeLogo2;
        private System.Windows.Forms.CheckBox chkExtraSecond;
    }
}