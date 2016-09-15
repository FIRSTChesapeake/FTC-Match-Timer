namespace FTC_Timer_Display
{
    partial class frmMain
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
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale1 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer1 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale2 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer2 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection1 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor1 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor2 = new DevComponents.Instrumentation.GradientFillColor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableCurrentConfig = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDivIDLabel = new System.Windows.Forms.Label();
            this.lblVer = new DevComponents.DotNetBar.LabelX();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblDivID = new System.Windows.Forms.Label();
            this.ctrlHeader2 = new FTC_Timer_Display.CtrlHeader();
            this.flowFields = new System.Windows.Forms.FlowLayoutPanel();
            this.tableDisplayControl = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlHeader4 = new FTC_Timer_Display.CtrlHeader();
            this.tableDisplayButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDisplayFullscreen = new DevComponents.DotNetBar.ButtonX();
            this.btnDisplayHide = new DevComponents.DotNetBar.ButtonX();
            this.btnDisplayWindow = new DevComponents.DotNetBar.ButtonX();
            this.ctrlHeader3 = new FTC_Timer_Display.CtrlHeader();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMute = new DevComponents.DotNetBar.ButtonX();
            this.remoteController = new FTC_Timer_Display.ArduinoComm.ArduinoController();
            this.tableFieldControl = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimerValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCurrentPeriod = new System.Windows.Forms.Label();
            this.lblMatchStatus = new System.Windows.Forms.Label();
            this.numMatchNumberMajor = new System.Windows.Forms.NumericUpDown();
            this.numMatchNumberMinor = new System.Windows.Forms.NumericUpDown();
            this.cboMatchType = new System.Windows.Forms.ComboBox();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.btnPause = new DevComponents.DotNetBar.ButtonX();
            this.btnStop = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnAdvance = new DevComponents.DotNetBar.ButtonX();
            this.progressDisplay = new FTC_Timer_Display.PeriodProgressBar();
            this.btnTimeoutStart = new DevComponents.DotNetBar.ButtonX();
            this.btnTimeoutCancel = new DevComponents.DotNetBar.ButtonX();
            this.headerFieldHead = new FTC_Timer_Display.CtrlHeader();
            this.gaugeCtrl = new DevComponents.Instrumentation.GaugeControl();
            this.tableCommStatus = new System.Windows.Forms.TableLayoutPanel();
            this.btnCycleListener = new DevComponents.DotNetBar.ButtonX();
            this.label13 = new System.Windows.Forms.Label();
            this.lblListenStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblLastSvrIP = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLastRecvTime = new System.Windows.Forms.Label();
            this.picRcvTime = new System.Windows.Forms.PictureBox();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.tableLinks = new System.Windows.Forms.TableLayoutPanel();
            this.flowBugs = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSettings = new DevComponents.DotNetBar.ButtonX();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.styleMgr = new DevComponents.DotNetBar.StyleManager(this.components);
            this.toolTipMgr = new DevComponents.DotNetBar.SuperTooltip();
            this.tableRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLeft.SuspendLayout();
            this.tableCurrentConfig.SuspendLayout();
            this.tableDisplayControl.SuspendLayout();
            this.tableDisplayButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableFieldControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMinor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeCtrl)).BeginInit();
            this.tableCommStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRcvTime)).BeginInit();
            this.tableLinks.SuspendLayout();
            this.flowBugs.SuspendLayout();
            this.tableRight.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLeft
            // 
            this.tableLeft.ColumnCount = 1;
            this.tableLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLeft.Controls.Add(this.tableCurrentConfig, 0, 0);
            this.tableLeft.Controls.Add(this.flowFields, 0, 2);
            this.tableLeft.Controls.Add(this.tableDisplayControl, 0, 5);
            this.tableLeft.Controls.Add(this.ctrlHeader3, 0, 1);
            this.tableLeft.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.tableLeft.Controls.Add(this.remoteController, 0, 3);
            this.tableLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLeft.Name = "tableLeft";
            this.tableLeft.RowCount = 6;
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLeft.Size = new System.Drawing.Size(264, 607);
            this.tableLeft.TabIndex = 0;
            // 
            // tableCurrentConfig
            // 
            this.tableCurrentConfig.AutoSize = true;
            this.tableCurrentConfig.ColumnCount = 2;
            this.tableCurrentConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableCurrentConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCurrentConfig.Controls.Add(this.label1, 0, 1);
            this.tableCurrentConfig.Controls.Add(this.lblDivIDLabel, 0, 2);
            this.tableCurrentConfig.Controls.Add(this.lblVer, 0, 3);
            this.tableCurrentConfig.Controls.Add(this.lblMode, 1, 1);
            this.tableCurrentConfig.Controls.Add(this.lblDivID, 1, 2);
            this.tableCurrentConfig.Controls.Add(this.ctrlHeader2, 0, 0);
            this.tableCurrentConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCurrentConfig.Location = new System.Drawing.Point(3, 3);
            this.tableCurrentConfig.Name = "tableCurrentConfig";
            this.tableCurrentConfig.RowCount = 4;
            this.tableCurrentConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableCurrentConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCurrentConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCurrentConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCurrentConfig.Size = new System.Drawing.Size(258, 97);
            this.tableCurrentConfig.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDivIDLabel
            // 
            this.lblDivIDLabel.AutoSize = true;
            this.lblDivIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDivIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivIDLabel.Location = new System.Drawing.Point(3, 50);
            this.lblDivIDLabel.Name = "lblDivIDLabel";
            this.lblDivIDLabel.Size = new System.Drawing.Size(86, 20);
            this.lblDivIDLabel.TabIndex = 1;
            this.lblDivIDLabel.Text = "Division:";
            this.lblDivIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVer
            // 
            // 
            // 
            // 
            this.lblVer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableCurrentConfig.SetColumnSpan(this.lblVer, 2);
            this.lblVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVer.Location = new System.Drawing.Point(3, 73);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(252, 21);
            this.lblVer.TabIndex = 2;
            this.lblVer.Text = "Version 1.0.0.0";
            this.lblVer.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMode.Location = new System.Drawing.Point(95, 30);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(160, 20);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Unknown";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDivID
            // 
            this.lblDivID.AutoSize = true;
            this.lblDivID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDivID.Location = new System.Drawing.Point(95, 50);
            this.lblDivID.Name = "lblDivID";
            this.lblDivID.Size = new System.Drawing.Size(160, 20);
            this.lblDivID.TabIndex = 5;
            this.lblDivID.Text = "Unknown";
            this.lblDivID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tableCurrentConfig.SetColumnSpan(this.ctrlHeader2, 2);
            this.ctrlHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader2.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader2.Name = "ctrlHeader2";
            this.ctrlHeader2.Size = new System.Drawing.Size(252, 24);
            this.ctrlHeader2.TabIndex = 6;
            this.ctrlHeader2.Text = "Global Settings";
            this.ctrlHeader2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // flowFields
            // 
            this.flowFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFields.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowFields.Location = new System.Drawing.Point(3, 136);
            this.flowFields.Name = "flowFields";
            this.flowFields.Size = new System.Drawing.Size(258, 275);
            this.flowFields.TabIndex = 9;
            // 
            // tableDisplayControl
            // 
            this.tableDisplayControl.ColumnCount = 1;
            this.tableDisplayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDisplayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDisplayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDisplayControl.Controls.Add(this.ctrlHeader4, 0, 0);
            this.tableDisplayControl.Controls.Add(this.tableDisplayButtons, 0, 1);
            this.tableDisplayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDisplayControl.Location = new System.Drawing.Point(3, 532);
            this.tableDisplayControl.Name = "tableDisplayControl";
            this.tableDisplayControl.RowCount = 2;
            this.tableDisplayControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableDisplayControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDisplayControl.Size = new System.Drawing.Size(258, 72);
            this.tableDisplayControl.TabIndex = 11;
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
            this.ctrlHeader4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader4.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader4.Name = "ctrlHeader4";
            this.ctrlHeader4.Size = new System.Drawing.Size(252, 24);
            this.ctrlHeader4.TabIndex = 14;
            this.ctrlHeader4.Text = "Local Timer Display Control";
            this.ctrlHeader4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tableDisplayButtons
            // 
            this.tableDisplayButtons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableDisplayButtons.ColumnCount = 3;
            this.tableDisplayButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableDisplayButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableDisplayButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableDisplayButtons.Controls.Add(this.btnDisplayFullscreen, 2, 0);
            this.tableDisplayButtons.Controls.Add(this.btnDisplayHide, 0, 0);
            this.tableDisplayButtons.Controls.Add(this.btnDisplayWindow, 1, 0);
            this.tableDisplayButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDisplayButtons.Location = new System.Drawing.Point(3, 33);
            this.tableDisplayButtons.Name = "tableDisplayButtons";
            this.tableDisplayButtons.RowCount = 1;
            this.tableDisplayButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDisplayButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableDisplayButtons.Size = new System.Drawing.Size(252, 36);
            this.tableDisplayButtons.TabIndex = 15;
            // 
            // btnDisplayFullscreen
            // 
            this.btnDisplayFullscreen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDisplayFullscreen.AutoCheckOnClick = true;
            this.btnDisplayFullscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisplayFullscreen.Location = new System.Drawing.Point(171, 5);
            this.btnDisplayFullscreen.Name = "btnDisplayFullscreen";
            this.btnDisplayFullscreen.Size = new System.Drawing.Size(76, 26);
            this.btnDisplayFullscreen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnDisplayFullscreen, new DevComponents.DotNetBar.SuperTooltipInfo("Local Timer Display: Fullscreen", "Turn off help in Misc Options", "This button sets the timer window to fullscreen without borders. This is the prod" +
            "uction mode for the timer display.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnDisplayFullscreen.TabIndex = 16;
            this.btnDisplayFullscreen.Text = "Fullscreen";
            this.btnDisplayFullscreen.Click += new System.EventHandler(this.changeDisplayStateButtonHandler);
            // 
            // btnDisplayHide
            // 
            this.btnDisplayHide.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDisplayHide.AutoCheckOnClick = true;
            this.btnDisplayHide.Checked = true;
            this.btnDisplayHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisplayHide.Location = new System.Drawing.Point(5, 5);
            this.btnDisplayHide.Name = "btnDisplayHide";
            this.btnDisplayHide.Size = new System.Drawing.Size(75, 26);
            this.btnDisplayHide.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnDisplayHide, new DevComponents.DotNetBar.SuperTooltipInfo("Local Timer Display: Hidden", "Turn off help in Misc Options", "This button hides the local timer window entirely.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnDisplayHide.TabIndex = 11;
            this.btnDisplayHide.Text = "Hidden";
            this.btnDisplayHide.Click += new System.EventHandler(this.changeDisplayStateButtonHandler);
            // 
            // btnDisplayWindow
            // 
            this.btnDisplayWindow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDisplayWindow.AutoCheckOnClick = true;
            this.btnDisplayWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisplayWindow.Location = new System.Drawing.Point(88, 5);
            this.btnDisplayWindow.Name = "btnDisplayWindow";
            this.btnDisplayWindow.Size = new System.Drawing.Size(75, 26);
            this.btnDisplayWindow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnDisplayWindow, new DevComponents.DotNetBar.SuperTooltipInfo("Local Timer Display: Windowed", "Turn off help in Misc Options", "This button shows the Local Timer in a window so you can position it on the right" +
            " screen. You can also press escape with the Timer Display as the active window t" +
            "o achieve this.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnDisplayWindow.TabIndex = 15;
            this.btnDisplayWindow.Text = "Windowed";
            this.btnDisplayWindow.Click += new System.EventHandler(this.changeDisplayStateButtonHandler);
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
            this.ctrlHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader3.Location = new System.Drawing.Point(3, 106);
            this.ctrlHeader3.Name = "ctrlHeader3";
            this.ctrlHeader3.Size = new System.Drawing.Size(258, 24);
            this.ctrlHeader3.TabIndex = 12;
            this.ctrlHeader3.Text = "Available Fields";
            this.ctrlHeader3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnMute, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 467);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(258, 59);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnMute
            // 
            this.btnMute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMute.Image = global::FTC_Timer_Display.Properties.Resources.mute_off;
            this.btnMute.Location = new System.Drawing.Point(3, 3);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(123, 53);
            this.btnMute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnMute, new DevComponents.DotNetBar.SuperTooltipInfo("Local Mute", "Turn off help in Misc Options", "This will locally mute game sounds if any are played here.\r\nGreen: Sounds will be" +
            " played.\r\nRed: Sounds are not played.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnMute.TabIndex = 0;
            this.btnMute.Click += new System.EventHandler(this.LocalMuteHandler);
            // 
            // remoteController
            // 
            this.remoteController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteController.Location = new System.Drawing.Point(3, 417);
            this.remoteController.Name = "remoteController";
            this.remoteController.portStatus = false;
            this.remoteController.Size = new System.Drawing.Size(258, 44);
            this.remoteController.TabIndex = 29;
            this.remoteController.DataReceived += new System.EventHandler<FTC_Timer_Display.ArduinoComm.ArduinoMessage>(this.remoteController_DataReceived);
            // 
            // tableFieldControl
            // 
            this.tableFieldControl.ColumnCount = 4;
            this.tableFieldControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFieldControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFieldControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFieldControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFieldControl.Controls.Add(this.lblTimerValue, 2, 5);
            this.tableFieldControl.Controls.Add(this.label6, 1, 1);
            this.tableFieldControl.Controls.Add(this.label7, 1, 2);
            this.tableFieldControl.Controls.Add(this.label8, 1, 3);
            this.tableFieldControl.Controls.Add(this.label10, 1, 4);
            this.tableFieldControl.Controls.Add(this.label12, 1, 5);
            this.tableFieldControl.Controls.Add(this.lblCurrentPeriod, 2, 2);
            this.tableFieldControl.Controls.Add(this.lblMatchStatus, 2, 3);
            this.tableFieldControl.Controls.Add(this.numMatchNumberMajor, 2, 4);
            this.tableFieldControl.Controls.Add(this.numMatchNumberMinor, 3, 4);
            this.tableFieldControl.Controls.Add(this.cboMatchType, 2, 1);
            this.tableFieldControl.Controls.Add(this.btnStart, 0, 7);
            this.tableFieldControl.Controls.Add(this.btnPause, 3, 7);
            this.tableFieldControl.Controls.Add(this.btnStop, 3, 8);
            this.tableFieldControl.Controls.Add(this.btnReset, 1, 8);
            this.tableFieldControl.Controls.Add(this.btnAdvance, 0, 8);
            this.tableFieldControl.Controls.Add(this.progressDisplay, 0, 6);
            this.tableFieldControl.Controls.Add(this.btnTimeoutStart, 0, 9);
            this.tableFieldControl.Controls.Add(this.btnTimeoutCancel, 1, 9);
            this.tableFieldControl.Controls.Add(this.headerFieldHead, 0, 0);
            this.tableFieldControl.Controls.Add(this.gaugeCtrl, 0, 1);
            this.tableFieldControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFieldControl.Location = new System.Drawing.Point(3, 103);
            this.tableFieldControl.Name = "tableFieldControl";
            this.tableFieldControl.RowCount = 11;
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFieldControl.Size = new System.Drawing.Size(623, 451);
            this.tableFieldControl.TabIndex = 3;
            // 
            // lblTimerValue
            // 
            this.lblTimerValue.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.lblTimerValue, 2);
            this.lblTimerValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerValue.Location = new System.Drawing.Point(313, 155);
            this.lblTimerValue.Name = "lblTimerValue";
            this.lblTimerValue.Size = new System.Drawing.Size(307, 30);
            this.lblTimerValue.TabIndex = 28;
            this.lblTimerValue.Text = "Unknown";
            this.lblTimerValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Match Type:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Current Period:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Match Status:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 30);
            this.label10.TabIndex = 4;
            this.label10.Text = "Match Number:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(158, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 30);
            this.label12.TabIndex = 6;
            this.label12.Text = "Timer Value:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentPeriod
            // 
            this.lblCurrentPeriod.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.lblCurrentPeriod, 2);
            this.lblCurrentPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPeriod.Location = new System.Drawing.Point(313, 65);
            this.lblCurrentPeriod.Name = "lblCurrentPeriod";
            this.lblCurrentPeriod.Size = new System.Drawing.Size(307, 30);
            this.lblCurrentPeriod.TabIndex = 8;
            this.lblCurrentPeriod.Text = "Unknown";
            this.lblCurrentPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatchStatus
            // 
            this.lblMatchStatus.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.lblMatchStatus, 2);
            this.lblMatchStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchStatus.Location = new System.Drawing.Point(313, 95);
            this.lblMatchStatus.Name = "lblMatchStatus";
            this.lblMatchStatus.Size = new System.Drawing.Size(307, 30);
            this.lblMatchStatus.TabIndex = 9;
            this.lblMatchStatus.Text = "Unknown";
            this.lblMatchStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMatchNumberMajor
            // 
            this.numMatchNumberMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMatchNumberMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMatchNumberMajor.Location = new System.Drawing.Point(313, 128);
            this.numMatchNumberMajor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMatchNumberMajor.Name = "numMatchNumberMajor";
            this.numMatchNumberMajor.Size = new System.Drawing.Size(149, 26);
            this.numMatchNumberMajor.TabIndex = 13;
            this.numMatchNumberMajor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMatchNumberMajor.ValueChanged += new System.EventHandler(this.MatchNumberChangeHandler);
            // 
            // numMatchNumberMinor
            // 
            this.numMatchNumberMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMatchNumberMinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMatchNumberMinor.Location = new System.Drawing.Point(468, 128);
            this.numMatchNumberMinor.Name = "numMatchNumberMinor";
            this.numMatchNumberMinor.Size = new System.Drawing.Size(152, 26);
            this.numMatchNumberMinor.TabIndex = 14;
            this.numMatchNumberMinor.ValueChanged += new System.EventHandler(this.MatchNumberChangeHandler);
            // 
            // cboMatchType
            // 
            this.tableFieldControl.SetColumnSpan(this.cboMatchType, 2);
            this.cboMatchType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatchType.FormattingEnabled = true;
            this.cboMatchType.Location = new System.Drawing.Point(313, 33);
            this.cboMatchType.Name = "cboMatchType";
            this.cboMatchType.Size = new System.Drawing.Size(307, 28);
            this.cboMatchType.TabIndex = 15;
            this.cboMatchType.SelectedIndexChanged += new System.EventHandler(this.MatchTypeChangeHandler);
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tableFieldControl.SetColumnSpan(this.btnStart, 2);
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 238);
            this.btnStart.Name = "btnStart";
            this.btnStart.PulseSpeed = 35;
            this.btnStart.Size = new System.Drawing.Size(304, 64);
            this.btnStart.StopPulseOnMouseOver = false;
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnStart, new DevComponents.DotNetBar.SuperTooltipInfo("Start Match", "Turn off help in Misc Options", "This button will start the current match on the selected field.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start Match\r\n(F1)";
            this.btnStart.Click += new System.EventHandler(this.FieldControlButtonsHandler);
            // 
            // btnPause
            // 
            this.btnPause.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPause.BackColor = System.Drawing.Color.Red;
            this.btnPause.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPause.Location = new System.Drawing.Point(468, 238);
            this.btnPause.Name = "btnPause";
            this.btnPause.PulseSpeed = 35;
            this.btnPause.Size = new System.Drawing.Size(152, 64);
            this.btnPause.StopPulseOnMouseOver = false;
            this.btnPause.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnPause, new DevComponents.DotNetBar.SuperTooltipInfo("Pause Match", "Turn off help in Misc Options", "Pauses the current match. Pausing a match does not cancel the match and it can be" +
            " resumed immediately.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnPause.TabIndex = 17;
            this.btnPause.Text = "Pause Match\r\n(F11)";
            this.btnPause.Click += new System.EventHandler(this.FieldControlButtonsHandler);
            // 
            // btnStop
            // 
            this.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(468, 308);
            this.btnStop.Name = "btnStop";
            this.btnStop.PulseSpeed = 35;
            this.btnStop.Size = new System.Drawing.Size(152, 64);
            this.btnStop.StopPulseOnMouseOver = false;
            this.btnStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnStop, new DevComponents.DotNetBar.SuperTooltipInfo("Stop Match", "Turn off help in Misc Options", "Stops the current match. Once a match is stopped, it can not be resumed, and must" +
            " be reset.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Stop Match\r\n(F12)";
            this.btnStop.Click += new System.EventHandler(this.FieldControlButtonsHandler);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.BackColor = System.Drawing.Color.Fuchsia;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(158, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.PulseSpeed = 35;
            this.btnReset.Size = new System.Drawing.Size(149, 64);
            this.btnReset.StopPulseOnMouseOver = false;
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnReset, new DevComponents.DotNetBar.SuperTooltipInfo("Reset Match", "Turn off help in Misc Options", "This button will Reset the current match on the current field.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset Match\r\n(F3)";
            this.btnReset.Click += new System.EventHandler(this.FieldControlButtonsHandler);
            // 
            // btnAdvance
            // 
            this.btnAdvance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdvance.BackColor = System.Drawing.Color.Blue;
            this.btnAdvance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvance.Location = new System.Drawing.Point(3, 308);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.PulseSpeed = 35;
            this.btnAdvance.Size = new System.Drawing.Size(149, 64);
            this.btnAdvance.StopPulseOnMouseOver = false;
            this.btnAdvance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnAdvance, new DevComponents.DotNetBar.SuperTooltipInfo("Advance to Next Match", "Turn off help in Misc Options", "This button will advance to the next match using the available fields.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnAdvance.TabIndex = 20;
            this.btnAdvance.Text = "Advance to Next Match\r\n(F2)";
            this.btnAdvance.Click += new System.EventHandler(this.FieldControlButtonsHandler);
            // 
            // progressDisplay
            // 
            this.tableFieldControl.SetColumnSpan(this.progressDisplay, 4);
            this.progressDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressDisplay.Location = new System.Drawing.Point(3, 188);
            this.progressDisplay.Name = "progressDisplay";
            this.progressDisplay.Size = new System.Drawing.Size(617, 44);
            this.progressDisplay.TabIndex = 21;
            this.progressDisplay.Load += new System.EventHandler(this.progressDisplay_Load);
            // 
            // btnTimeoutStart
            // 
            this.btnTimeoutStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimeoutStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimeoutStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeoutStart.Location = new System.Drawing.Point(3, 378);
            this.btnTimeoutStart.Name = "btnTimeoutStart";
            this.btnTimeoutStart.PulseSpeed = 35;
            this.btnTimeoutStart.Size = new System.Drawing.Size(149, 64);
            this.btnTimeoutStart.StopPulseOnMouseOver = false;
            this.btnTimeoutStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnTimeoutStart, new DevComponents.DotNetBar.SuperTooltipInfo("Start Timeout", "Turn off help in Misc Options", "This button will allow you to start a Timeout timer on the currently selected fie" +
            "ld. A timeout running on one field will not prevent you from starting a match on" +
            " another.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnTimeoutStart.TabIndex = 23;
            this.btnTimeoutStart.Text = "Start Timeout\r\n(F6)";
            this.btnTimeoutStart.Click += new System.EventHandler(this.FieldControlButtonsHandler);
            // 
            // btnTimeoutCancel
            // 
            this.btnTimeoutCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimeoutCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTimeoutCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimeoutCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeoutCancel.Location = new System.Drawing.Point(158, 378);
            this.btnTimeoutCancel.Name = "btnTimeoutCancel";
            this.btnTimeoutCancel.PulseSpeed = 35;
            this.btnTimeoutCancel.Size = new System.Drawing.Size(149, 64);
            this.btnTimeoutCancel.StopPulseOnMouseOver = false;
            this.btnTimeoutCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnTimeoutCancel, new DevComponents.DotNetBar.SuperTooltipInfo("Cancel Timeout", "Turn off help in Misc Options", "Cancels the currently running timeout on the selected field.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnTimeoutCancel.TabIndex = 24;
            this.btnTimeoutCancel.Text = "Cancel Timeout\r\n(F7)";
            this.btnTimeoutCancel.Click += new System.EventHandler(this.FieldControlButtonsHandler);
            // 
            // headerFieldHead
            // 
            // 
            // 
            // 
            this.headerFieldHead.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerFieldHead.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.headerFieldHead.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.headerFieldHead.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableFieldControl.SetColumnSpan(this.headerFieldHead, 4);
            this.headerFieldHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerFieldHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.headerFieldHead.Location = new System.Drawing.Point(3, 3);
            this.headerFieldHead.Name = "headerFieldHead";
            this.headerFieldHead.Size = new System.Drawing.Size(617, 24);
            this.headerFieldHead.TabIndex = 26;
            this.headerFieldHead.Text = "Field Control: Division 0 Field 0";
            this.headerFieldHead.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // gaugeCtrl
            // 
            gaugeCircularScale1.BorderColor = System.Drawing.Color.Red;
            gaugeCircularScale1.BorderWidth = 1;
            gaugeCircularScale1.MajorTickMarks.Interval = 1D;
            gaugeCircularScale1.MaxPin.Name = "MaxPin";
            gaugeCircularScale1.MaxValue = 10D;
            gaugeCircularScale1.MinPin.Name = "MinPin";
            gaugeCircularScale1.Name = "Mins";
            gaugePointer1.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer1.CapFillColor.BorderWidth = 1;
            gaugePointer1.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer1.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer1.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer1.FillColor.BorderWidth = 1;
            gaugePointer1.FillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer1.FillColor.Color2 = System.Drawing.Color.Red;
            gaugePointer1.Length = 0.358F;
            gaugePointer1.Name = "pntrMin";
            gaugePointer1.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer1.Value = 0D;
            gaugeCircularScale1.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer1});
            gaugeCircularScale1.Radius = 0.297F;
            gaugeCircularScale1.StartAngle = 130F;
            gaugeCircularScale1.SweepAngle = 280F;
            gaugeCircularScale2.MaxPin.Name = "MaxPin";
            gaugeCircularScale2.MaxValue = 59D;
            gaugeCircularScale2.MinPin.Name = "MinPin";
            gaugeCircularScale2.Name = "Secs";
            gaugePointer2.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer2.CapFillColor.BorderWidth = 1;
            gaugePointer2.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer2.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer2.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer2.FillColor.BorderWidth = 1;
            gaugePointer2.FillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer2.FillColor.Color2 = System.Drawing.Color.YellowGreen;
            gaugePointer2.Name = "pntrSec";
            gaugePointer2.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer2.ThermoBackColor.BorderColor = System.Drawing.Color.Black;
            gaugePointer2.ThermoBackColor.BorderWidth = 1;
            gaugePointer2.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            gaugePointer2.Value = 0D;
            gaugeCircularScale2.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer2});
            gaugeCircularScale2.Radius = 0.418F;
            gaugeSection1.FillColor.Color1 = System.Drawing.Color.CornflowerBlue;
            gaugeSection1.Name = "Section1";
            gaugeCircularScale2.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection1});
            gaugeCircularScale2.StartAngle = 130F;
            gaugeCircularScale2.SweepAngle = 280F;
            this.gaugeCtrl.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale1,
            gaugeCircularScale2});
            this.gaugeCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            gradientFillColor1.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor1.Color2 = System.Drawing.Color.DarkGray;
            this.gaugeCtrl.Frame.BackColor = gradientFillColor1;
            gradientFillColor2.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor2.BorderWidth = 1;
            gradientFillColor2.Color1 = System.Drawing.Color.White;
            gradientFillColor2.Color2 = System.Drawing.Color.DimGray;
            this.gaugeCtrl.Frame.FrameColor = gradientFillColor2;
            this.gaugeCtrl.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular;
            this.gaugeCtrl.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gaugeCtrl.Location = new System.Drawing.Point(3, 33);
            this.gaugeCtrl.Name = "gaugeCtrl";
            this.tableFieldControl.SetRowSpan(this.gaugeCtrl, 5);
            this.gaugeCtrl.Size = new System.Drawing.Size(149, 149);
            this.gaugeCtrl.TabIndex = 27;
            this.gaugeCtrl.Text = "gaugeControl1";
            // 
            // tableCommStatus
            // 
            this.tableCommStatus.AutoSize = true;
            this.tableCommStatus.ColumnCount = 5;
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCommStatus.Controls.Add(this.btnCycleListener, 0, 2);
            this.tableCommStatus.Controls.Add(this.label13, 0, 1);
            this.tableCommStatus.Controls.Add(this.lblListenStatus, 1, 1);
            this.tableCommStatus.Controls.Add(this.label14, 2, 1);
            this.tableCommStatus.Controls.Add(this.lblLastSvrIP, 4, 1);
            this.tableCommStatus.Controls.Add(this.label15, 2, 2);
            this.tableCommStatus.Controls.Add(this.lblLastRecvTime, 4, 2);
            this.tableCommStatus.Controls.Add(this.picRcvTime, 3, 2);
            this.tableCommStatus.Controls.Add(this.ctrlHeader1, 0, 0);
            this.tableCommStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCommStatus.Location = new System.Drawing.Point(3, 3);
            this.tableCommStatus.Name = "tableCommStatus";
            this.tableCommStatus.RowCount = 3;
            this.tableCommStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableCommStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCommStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCommStatus.Size = new System.Drawing.Size(623, 94);
            this.tableCommStatus.TabIndex = 4;
            // 
            // btnCycleListener
            // 
            this.btnCycleListener.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCycleListener.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tableCommStatus.SetColumnSpan(this.btnCycleListener, 2);
            this.btnCycleListener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCycleListener.Enabled = false;
            this.btnCycleListener.Location = new System.Drawing.Point(3, 58);
            this.btnCycleListener.Name = "btnCycleListener";
            this.btnCycleListener.Size = new System.Drawing.Size(276, 33);
            this.btnCycleListener.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnCycleListener, new DevComponents.DotNetBar.SuperTooltipInfo("Change Controlling Location", "Turn off help in Misc Options", "This will change the status of the listening socket and swap control from a Serve" +
            "r to the Local Client and back.\r\n\r\nThis is not available in some Run Modes.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnCycleListener.TabIndex = 3;
            this.btnCycleListener.Text = "Chg";
            this.btnCycleListener.Click += new System.EventHandler(this.btnCycleListener_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Listener Status:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblListenStatus
            // 
            this.lblListenStatus.AutoSize = true;
            this.lblListenStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListenStatus.Location = new System.Drawing.Point(105, 30);
            this.lblListenStatus.Name = "lblListenStatus";
            this.lblListenStatus.Size = new System.Drawing.Size(174, 25);
            this.lblListenStatus.TabIndex = 2;
            this.lblListenStatus.Text = "Unknown";
            this.lblListenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(285, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Last Received From:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastSvrIP
            // 
            this.lblLastSvrIP.AutoSize = true;
            this.lblLastSvrIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastSvrIP.Location = new System.Drawing.Point(445, 30);
            this.lblLastSvrIP.Name = "lblLastSvrIP";
            this.lblLastSvrIP.Size = new System.Drawing.Size(175, 25);
            this.lblLastSvrIP.TabIndex = 6;
            this.lblLastSvrIP.Text = "Never";
            this.lblLastSvrIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(285, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 39);
            this.label15.TabIndex = 5;
            this.label15.Text = "Last Receive Time:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastRecvTime
            // 
            this.lblLastRecvTime.AutoSize = true;
            this.lblLastRecvTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastRecvTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastRecvTime.Location = new System.Drawing.Point(445, 55);
            this.lblLastRecvTime.Name = "lblLastRecvTime";
            this.lblLastRecvTime.Size = new System.Drawing.Size(175, 39);
            this.lblLastRecvTime.TabIndex = 7;
            this.lblLastRecvTime.Text = "Never";
            this.lblLastRecvTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picRcvTime
            // 
            this.picRcvTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRcvTime.Image = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.picRcvTime.Location = new System.Drawing.Point(415, 58);
            this.picRcvTime.Name = "picRcvTime";
            this.picRcvTime.Size = new System.Drawing.Size(24, 33);
            this.picRcvTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toolTipMgr.SetSuperTooltip(this.picRcvTime, new DevComponents.DotNetBar.SuperTooltipInfo("Receiving Indicator", "Turn off help in Misc Options", "This indicates the receiving status of the local timer.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.picRcvTime.TabIndex = 8;
            this.picRcvTime.TabStop = false;
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
            this.tableCommStatus.SetColumnSpan(this.ctrlHeader1, 5);
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader1.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(617, 24);
            this.ctrlHeader1.TabIndex = 9;
            this.ctrlHeader1.Text = "Communication Status";
            this.ctrlHeader1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tableLinks
            // 
            this.tableLinks.ColumnCount = 4;
            this.tableLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLinks.Controls.Add(this.flowBugs, 1, 0);
            this.tableLinks.Controls.Add(this.btnSettings, 0, 0);
            this.tableLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLinks.Location = new System.Drawing.Point(3, 560);
            this.tableLinks.Name = "tableLinks";
            this.tableLinks.RowCount = 1;
            this.tableLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLinks.Size = new System.Drawing.Size(623, 44);
            this.tableLinks.TabIndex = 7;
            // 
            // flowBugs
            // 
            this.tableLinks.SetColumnSpan(this.flowBugs, 2);
            this.flowBugs.Controls.Add(this.labelX1);
            this.flowBugs.Controls.Add(this.linkLabel1);
            this.flowBugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowBugs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowBugs.Location = new System.Drawing.Point(158, 3);
            this.flowBugs.Name = "flowBugs";
            this.flowBugs.Size = new System.Drawing.Size(304, 38);
            this.flowBugs.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(259, 15);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "<b>Please report bugs or make feature requests here:</b>";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(252, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/VirginiaFIRST/FTC-Match-Timer";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSettings
            // 
            this.btnSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Location = new System.Drawing.Point(3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(149, 38);
            this.btnSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Application Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // displayTimer
            // 
            this.displayTimer.Interval = 200;
            this.displayTimer.Tick += new System.EventHandler(this.PerodicTick);
            // 
            // styleMgr
            // 
            this.styleMgr.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleMgr.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // toolTipMgr
            // 
            this.toolTipMgr.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "Turn off help in Misc Options", "", null, null, DevComponents.DotNetBar.eTooltipColor.Green);
            this.toolTipMgr.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // tableRight
            // 
            this.tableRight.ColumnCount = 1;
            this.tableRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRight.Controls.Add(this.tableLinks, 0, 2);
            this.tableRight.Controls.Add(this.tableCommStatus, 0, 0);
            this.tableRight.Controls.Add(this.tableFieldControl, 0, 1);
            this.tableRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRight.Location = new System.Drawing.Point(273, 3);
            this.tableRight.Name = "tableRight";
            this.tableRight.RowCount = 3;
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableRight.Size = new System.Drawing.Size(629, 607);
            this.tableRight.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLeft, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableRight, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 613F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(905, 613);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 613);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.tableLeft.ResumeLayout(false);
            this.tableLeft.PerformLayout();
            this.tableCurrentConfig.ResumeLayout(false);
            this.tableCurrentConfig.PerformLayout();
            this.tableDisplayControl.ResumeLayout(false);
            this.tableDisplayButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableFieldControl.ResumeLayout(false);
            this.tableFieldControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMinor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeCtrl)).EndInit();
            this.tableCommStatus.ResumeLayout(false);
            this.tableCommStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRcvTime)).EndInit();
            this.tableLinks.ResumeLayout(false);
            this.flowBugs.ResumeLayout(false);
            this.flowBugs.PerformLayout();
            this.tableRight.ResumeLayout(false);
            this.tableRight.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLeft;
        private System.Windows.Forms.TableLayoutPanel tableCurrentConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDivIDLabel;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblDivID;
        private System.Windows.Forms.Timer displayTimer;
        private System.Windows.Forms.TableLayoutPanel tableFieldControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCurrentPeriod;
        private System.Windows.Forms.Label lblMatchStatus;
        private System.Windows.Forms.NumericUpDown numMatchNumberMajor;
        private System.Windows.Forms.NumericUpDown numMatchNumberMinor;
        private System.Windows.Forms.ComboBox cboMatchType;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private DevComponents.DotNetBar.ButtonX btnPause;
        private DevComponents.DotNetBar.ButtonX btnStop;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnAdvance;
        private System.Windows.Forms.TableLayoutPanel tableCommStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblListenStatus;
        private DevComponents.DotNetBar.ButtonX btnCycleListener;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLastRecvTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLastSvrIP;
        private System.Windows.Forms.TableLayoutPanel tableLinks;
        private PeriodProgressBar progressDisplay;
        private DevComponents.DotNetBar.StyleManager styleMgr;
        private System.Windows.Forms.PictureBox picRcvTime;
        private System.Windows.Forms.FlowLayoutPanel flowBugs;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevComponents.DotNetBar.LabelX lblVer;
        private DevComponents.DotNetBar.ButtonX btnTimeoutStart;
        private DevComponents.DotNetBar.ButtonX btnTimeoutCancel;
        private DevComponents.DotNetBar.SuperTooltip toolTipMgr;
        private System.Windows.Forms.FlowLayoutPanel flowFields;
        private CtrlHeader headerFieldHead;
        private CtrlHeader ctrlHeader1;
        private CtrlHeader ctrlHeader2;
        private DevComponents.DotNetBar.ButtonX btnSettings;
        private System.Windows.Forms.TableLayoutPanel tableDisplayControl;
        private System.Windows.Forms.TableLayoutPanel tableRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CtrlHeader ctrlHeader3;
        private DevComponents.DotNetBar.ButtonX btnDisplayHide;
        private CtrlHeader ctrlHeader4;
        private DevComponents.DotNetBar.ButtonX btnDisplayWindow;
        private DevComponents.DotNetBar.ButtonX btnDisplayFullscreen;
        private System.Windows.Forms.TableLayoutPanel tableDisplayButtons;
        private DevComponents.Instrumentation.GaugeControl gaugeCtrl;
        private System.Windows.Forms.Label lblTimerValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.ButtonX btnMute;
        private ArduinoComm.ArduinoController remoteController;

    }
}