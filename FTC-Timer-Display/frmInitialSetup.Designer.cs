namespace FTC_Timer_Display
{
    partial class frmInitialSetup
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
            this.components = new System.ComponentModel.Container();
            this.tabsMain = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new DevComponents.DotNetBar.LabelX();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.chkSkipWelcome = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnClearAllSettings = new DevComponents.DotNetBar.ButtonX();
            this.tabWelcome = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.appModeSelection = new FTC_Timer_Display.InitializationControls.CtrlAppModeSelection();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel7 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.settingsViewPost = new FTC_Timer_Display.InitializationControls.InitialSettingsView();
            this.superTabItem5 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.settingsViewPre = new FTC_Timer_Display.InitializationControls.InitialSettingsView();
            this.tabPreReview = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel6 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.clientOpts = new FTC_Timer_Display.InitializationControls.CtrlClient();
            this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.serverOpts = new FTC_Timer_Display.InitializationControls.CtrlServer();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.globalOpts = new FTC_Timer_Display.InitializationControls.CtrlGlobal();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.stepsBar = new DevComponents.DotNetBar.ProgressSteps();
            this.stepIntro = new DevComponents.DotNetBar.StepItem();
            this.stepPrevSettings = new DevComponents.DotNetBar.StepItem();
            this.stepAppMode = new DevComponents.DotNetBar.StepItem();
            this.stepGlobal = new DevComponents.DotNetBar.StepItem();
            this.stepServer = new DevComponents.DotNetBar.StepItem();
            this.stepClient = new DevComponents.DotNetBar.StepItem();
            this.stepReview = new DevComponents.DotNetBar.StepItem();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrev = new DevComponents.DotNetBar.ButtonX();
            this.btnQuit = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnFinish = new DevComponents.DotNetBar.ButtonX();
            this.btnStartOver = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabsMain)).BeginInit();
            this.tabsMain.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.superTabControlPanel3.SuspendLayout();
            this.superTabControlPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.superTabControlPanel6.SuspendLayout();
            this.superTabControlPanel5.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsMain
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabsMain.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabsMain.ControlBox.MenuBox.Name = "";
            this.tabsMain.ControlBox.Name = "";
            this.tabsMain.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabsMain.ControlBox.MenuBox,
            this.tabsMain.ControlBox.CloseBox});
            this.tabsMain.Controls.Add(this.superTabControlPanel1);
            this.tabsMain.Controls.Add(this.superTabControlPanel3);
            this.tabsMain.Controls.Add(this.superTabControlPanel7);
            this.tabsMain.Controls.Add(this.superTabControlPanel2);
            this.tabsMain.Controls.Add(this.superTabControlPanel6);
            this.tabsMain.Controls.Add(this.superTabControlPanel5);
            this.tabsMain.Controls.Add(this.superTabControlPanel4);
            this.tabsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsMain.Location = new System.Drawing.Point(3, 33);
            this.tabsMain.Name = "tabsMain";
            this.tabsMain.ReorderTabsEnabled = true;
            this.tabsMain.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabsMain.SelectedTabIndex = 0;
            this.tabsMain.Size = new System.Drawing.Size(657, 481);
            this.tabsMain.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsMain.TabIndex = 0;
            this.tabsMain.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabWelcome,
            this.tabPreReview,
            this.superTabItem1,
            this.superTabItem2,
            this.superTabItem3,
            this.superTabItem4,
            this.superTabItem5});
            this.tabsMain.TabsVisible = false;
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Zoom;
            this.superTabControlPanel1.Controls.Add(this.tableLayoutPanel1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(657, 456);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tabWelcome;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.reflectionLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWelcome, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ctrlHeader1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkSkipWelcome, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnClearAllSettings, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 456);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectionLabel1.Location = new System.Drawing.Point(153, 3);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(351, 70);
            this.reflectionLabel1.TabIndex = 2;
            this.reflectionLabel1.Text = "<div align=\'center\'><b><font size=\"+12\"><i>FIRST in Virginia</i><br/><font color=" +
    "\"green\">FTC Match Timer</font></font></b></div>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FTC_Timer_Display.Properties.Resources.FCLogoBlack;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::FTC_Timer_Display.Properties.Resources.ftc_logo_new;
            this.pictureBox2.Location = new System.Drawing.Point(510, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblWelcome
            // 
            // 
            // 
            // 
            this.lblWelcome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel1.SetColumnSpan(this.lblWelcome, 3);
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Location = new System.Drawing.Point(3, 109);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(651, 304);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "This is a welcome message.";
            this.lblWelcome.TextLineAlignment = System.Drawing.StringAlignment.Near;
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
            this.tableLayoutPanel1.SetColumnSpan(this.ctrlHeader1, 3);
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader1.Location = new System.Drawing.Point(3, 79);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(651, 24);
            this.ctrlHeader1.TabIndex = 6;
            this.ctrlHeader1.Text = "Welcome";
            this.ctrlHeader1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // chkSkipWelcome
            // 
            // 
            // 
            // 
            this.chkSkipWelcome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkSkipWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSkipWelcome.Location = new System.Drawing.Point(153, 419);
            this.chkSkipWelcome.Name = "chkSkipWelcome";
            this.chkSkipWelcome.Size = new System.Drawing.Size(351, 34);
            this.chkSkipWelcome.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkSkipWelcome.TabIndex = 7;
            this.chkSkipWelcome.Text = "Skip This Welcome Screen Next Time";
            this.chkSkipWelcome.CheckedChanged += new System.EventHandler(this.chkSkipWelcome_CheckedChanged);
            // 
            // btnClearAllSettings
            // 
            this.btnClearAllSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearAllSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearAllSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearAllSettings.Location = new System.Drawing.Point(510, 419);
            this.btnClearAllSettings.Name = "btnClearAllSettings";
            this.btnClearAllSettings.Size = new System.Drawing.Size(144, 34);
            this.btnClearAllSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearAllSettings.TabIndex = 8;
            this.btnClearAllSettings.Text = "Clear All Settings";
            this.btnClearAllSettings.Click += new System.EventHandler(this.btnClearAllSettings_Click);
            // 
            // tabWelcome
            // 
            this.tabWelcome.AttachedControl = this.superTabControlPanel1;
            this.tabWelcome.GlobalItem = false;
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Text = "Welcome";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.appModeSelection);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(657, 456);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.superTabItem1;
            // 
            // appModeSelection
            // 
            this.appModeSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appModeSelection.Location = new System.Drawing.Point(0, 0);
            this.appModeSelection.Name = "appModeSelection";
            this.appModeSelection.Size = new System.Drawing.Size(657, 456);
            this.appModeSelection.TabIndex = 0;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel3;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "AppMode";
            // 
            // superTabControlPanel7
            // 
            this.superTabControlPanel7.Controls.Add(this.tableLayoutPanel4);
            this.superTabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel7.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel7.Name = "superTabControlPanel7";
            this.superTabControlPanel7.Size = new System.Drawing.Size(657, 456);
            this.superTabControlPanel7.TabIndex = 0;
            this.superTabControlPanel7.TabItem = this.superTabItem5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelX2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.settingsViewPost, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(657, 456);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(651, 34);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "<div align=\'center\'>Below you\'ll find the settings you just configured.<br/>If yo" +
    "u\'re happy with them, you can click Finish now. Otherwise, return to the previou" +
    "s steps and fix it.</div>";
            // 
            // settingsViewPost
            // 
            this.settingsViewPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsViewPost.Location = new System.Drawing.Point(3, 43);
            this.settingsViewPost.Name = "settingsViewPost";
            this.settingsViewPost.Size = new System.Drawing.Size(651, 410);
            this.settingsViewPost.TabIndex = 1;
            // 
            // superTabItem5
            // 
            this.superTabItem5.AttachedControl = this.superTabControlPanel7;
            this.superTabItem5.GlobalItem = false;
            this.superTabItem5.Name = "superTabItem5";
            this.superTabItem5.Text = "Review";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.tableLayoutPanel3);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(657, 456);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tabPreReview;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.settingsViewPre, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(657, 456);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(651, 34);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "<div align=\'center\'>Below you\'ll find the settings you used last time.<br/>If you" +
    "\'re happy with them, you can click Finish now.</div>";
            // 
            // settingsViewPre
            // 
            this.settingsViewPre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsViewPre.Location = new System.Drawing.Point(3, 43);
            this.settingsViewPre.Name = "settingsViewPre";
            this.settingsViewPre.Size = new System.Drawing.Size(651, 410);
            this.settingsViewPre.TabIndex = 1;
            // 
            // tabPreReview
            // 
            this.tabPreReview.AttachedControl = this.superTabControlPanel2;
            this.tabPreReview.GlobalItem = false;
            this.tabPreReview.Name = "tabPreReview";
            this.tabPreReview.Text = "PreReview";
            // 
            // superTabControlPanel6
            // 
            this.superTabControlPanel6.Controls.Add(this.clientOpts);
            this.superTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel6.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel6.Name = "superTabControlPanel6";
            this.superTabControlPanel6.Size = new System.Drawing.Size(657, 456);
            this.superTabControlPanel6.TabIndex = 0;
            this.superTabControlPanel6.TabItem = this.superTabItem4;
            // 
            // clientOpts
            // 
            this.clientOpts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientOpts.Location = new System.Drawing.Point(0, 0);
            this.clientOpts.Name = "clientOpts";
            this.clientOpts.Size = new System.Drawing.Size(657, 456);
            this.clientOpts.TabIndex = 0;
            // 
            // superTabItem4
            // 
            this.superTabItem4.AttachedControl = this.superTabControlPanel6;
            this.superTabItem4.GlobalItem = false;
            this.superTabItem4.Name = "superTabItem4";
            this.superTabItem4.Text = "Client";
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Controls.Add(this.serverOpts);
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(657, 456);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.superTabItem3;
            // 
            // serverOpts
            // 
            this.serverOpts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverOpts.eventType = FTC_Timer_Display.MatchData.EventTypes.Qualifier;
            this.serverOpts.Location = new System.Drawing.Point(0, 0);
            this.serverOpts.Name = "serverOpts";
            this.serverOpts.Size = new System.Drawing.Size(657, 456);
            this.serverOpts.TabIndex = 0;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel5;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "Server";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.globalOpts);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(657, 456);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.superTabItem2;
            // 
            // globalOpts
            // 
            this.globalOpts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.globalOpts.Location = new System.Drawing.Point(0, 0);
            this.globalOpts.Name = "globalOpts";
            this.globalOpts.Size = new System.Drawing.Size(657, 456);
            this.globalOpts.TabIndex = 0;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel4;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Global";
            // 
            // stepsBar
            // 
            // 
            // 
            // 
            this.stepsBar.BackgroundStyle.Class = "ProgressSteps";
            this.stepsBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.stepsBar.ContainerControlProcessDialogKey = true;
            this.stepsBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepsBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stepIntro,
            this.stepPrevSettings,
            this.stepAppMode,
            this.stepGlobal,
            this.stepServer,
            this.stepClient,
            this.stepReview});
            this.stepsBar.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.stepsBar.Location = new System.Drawing.Point(3, 3);
            this.stepsBar.Name = "stepsBar";
            this.stepsBar.Size = new System.Drawing.Size(657, 24);
            this.stepsBar.TabIndex = 1;
            this.stepsBar.Visible = false;
            // 
            // stepIntro
            // 
            this.stepIntro.Name = "stepIntro";
            this.stepIntro.SymbolSize = 13F;
            this.stepIntro.Text = "Welcome";
            this.stepIntro.Value = 100;
            // 
            // stepPrevSettings
            // 
            this.stepPrevSettings.Name = "stepPrevSettings";
            this.stepPrevSettings.SymbolSize = 13F;
            this.stepPrevSettings.Text = "Current Settings";
            // 
            // stepAppMode
            // 
            this.stepAppMode.Name = "stepAppMode";
            this.stepAppMode.SymbolSize = 13F;
            this.stepAppMode.Text = "Select Application Mode";
            // 
            // stepGlobal
            // 
            this.stepGlobal.Name = "stepGlobal";
            this.stepGlobal.SymbolSize = 13F;
            this.stepGlobal.Text = "Global Settings";
            // 
            // stepServer
            // 
            this.stepServer.Name = "stepServer";
            this.stepServer.SymbolSize = 13F;
            this.stepServer.Text = "Server Only Options";
            // 
            // stepClient
            // 
            this.stepClient.Name = "stepClient";
            this.stepClient.SymbolSize = 13F;
            this.stepClient.Text = "Client Only Options";
            // 
            // stepReview
            // 
            this.stepReview.Name = "stepReview";
            this.stepReview.Stretch = true;
            this.stepReview.SymbolSize = 13F;
            this.stepReview.Text = "Review && Save";
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.stepsBar, 0, 0);
            this.tableMain.Controls.Add(this.tabsMain, 0, 1);
            this.tableMain.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMain.Size = new System.Drawing.Size(663, 557);
            this.tableMain.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.Controls.Add(this.btnPrev, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnQuit, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNext, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFinish, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnStartOver, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 520);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(657, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnPrev
            // 
            this.btnPrev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrev.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrev.Enabled = false;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ImageTextSpacing = 2;
            this.btnPrev.Location = new System.Drawing.Point(128, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(119, 28);
            this.btnPrev.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrev.Symbol = "";
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Previous Step";
            this.btnPrev.Click += new System.EventHandler(this.navButtonsHandler);
            // 
            // btnQuit
            // 
            this.btnQuit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(269, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(119, 28);
            this.btnQuit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.navButtonsHandler);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnNext.ImageTextSpacing = 2;
            this.btnNext.Location = new System.Drawing.Point(410, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 28);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.Symbol = "";
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next Step";
            this.btnNext.Click += new System.EventHandler(this.navButtonsHandler);
            // 
            // btnFinish
            // 
            this.btnFinish.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinish.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnFinish.ImageTextSpacing = 2;
            this.btnFinish.Location = new System.Drawing.Point(535, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(119, 28);
            this.btnFinish.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinish.Symbol = "";
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.navButtonsHandler);
            // 
            // btnStartOver
            // 
            this.btnStartOver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStartOver.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStartOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOver.ImageTextSpacing = 2;
            this.btnStartOver.Location = new System.Drawing.Point(3, 3);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(119, 28);
            this.btnStartOver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStartOver.Symbol = "";
            this.btnStartOver.TabIndex = 4;
            this.btnStartOver.Text = "Start Over";
            this.btnStartOver.Click += new System.EventHandler(this.navButtonsHandler);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // frmInitialSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 557);
            this.Controls.Add(this.tableMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInitialSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Setup Wizard";
            this.Load += new System.EventHandler(this.frmInitialSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabsMain)).EndInit();
            this.tabsMain.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.superTabControlPanel6.ResumeLayout(false);
            this.superTabControlPanel5.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.tableMain.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl tabsMain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabWelcome;
        private DevComponents.DotNetBar.ProgressSteps stepsBar;
        private DevComponents.DotNetBar.StepItem stepIntro;
        private DevComponents.DotNetBar.StepItem stepAppMode;
        private DevComponents.DotNetBar.StepItem stepGlobal;
        private DevComponents.DotNetBar.StepItem stepServer;
        private DevComponents.DotNetBar.StepItem stepClient;
        private DevComponents.DotNetBar.StepItem stepReview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevComponents.DotNetBar.LabelX lblWelcome;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private CtrlHeader ctrlHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.ButtonX btnPrev;
        private DevComponents.DotNetBar.ButtonX btnQuit;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.StepItem stepPrevSettings;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tabPreReview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevComponents.DotNetBar.ButtonX btnFinish;
        private DevComponents.DotNetBar.LabelX labelX1;
        private InitializationControls.InitialSettingsView settingsViewPre;
        private DevComponents.DotNetBar.ButtonX btnStartOver;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel7;
        private DevComponents.DotNetBar.SuperTabItem superTabItem5;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel6;
        private DevComponents.DotNetBar.SuperTabItem superTabItem4;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private InitializationControls.CtrlAppModeSelection appModeSelection;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkSkipWelcome;
        private InitializationControls.CtrlGlobal globalOpts;
        private InitializationControls.CtrlServer serverOpts;
        private InitializationControls.CtrlClient clientOpts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private InitializationControls.InitialSettingsView settingsViewPost;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnClearAllSettings;

    }
}