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
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableCurrentConfig = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDivIDLabel = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblDivID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableFieldControl = new System.Windows.Forms.TableLayoutPanel();
            this.lblFieldHead = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCurrentPeriod = new System.Windows.Forms.Label();
            this.lblMatchStatus = new System.Windows.Forms.Label();
            this.lblTimerValue = new System.Windows.Forms.Label();
            this.numMatchNumberMajor = new System.Windows.Forms.NumericUpDown();
            this.numMatchNumberMinor = new System.Windows.Forms.NumericUpDown();
            this.cboMatchType = new System.Windows.Forms.ComboBox();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.btnPause = new DevComponents.DotNetBar.ButtonX();
            this.btnStop = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnAdvance = new DevComponents.DotNetBar.ButtonX();
            this.btnTimeoutStart = new DevComponents.DotNetBar.ButtonX();
            this.btnTimeoutCancel = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableCommStatus = new System.Windows.Forms.TableLayoutPanel();
            this.btnCycleListener = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblListenStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblLastSvrIP = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLastRecvTime = new System.Windows.Forms.Label();
            this.picRcvTime = new System.Windows.Forms.PictureBox();
            this.tableOther = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkSetMatchTimes = new System.Windows.Forms.LinkLabel();
            this.linkSettings = new System.Windows.Forms.LinkLabel();
            this.linkSoundTest = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisplayStatus = new System.Windows.Forms.Label();
            this.btnChangeDisplayState = new DevComponents.DotNetBar.ButtonX();
            this.tableLinks = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picLicense = new System.Windows.Forms.PictureBox();
            this.lblVer = new DevComponents.DotNetBar.LabelX();
            this.tableFiledListMgmt = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddField = new DevComponents.DotNetBar.ButtonX();
            this.btnRemoveField = new DevComponents.DotNetBar.ButtonX();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.styleMgr = new DevComponents.DotNetBar.StyleManager(this.components);
            this.toolTipMgr = new DevComponents.DotNetBar.SuperTooltip();
            this.flowFields = new System.Windows.Forms.FlowLayoutPanel();
            this.swLocalMute = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.grpLocalTimer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressDisplay = new FTC_Timer_Display.PeriodProgressBar();
            this.tableMain.SuspendLayout();
            this.tableCurrentConfig.SuspendLayout();
            this.tableFieldControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMinor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableCommStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRcvTime)).BeginInit();
            this.tableOther.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLinks.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicense)).BeginInit();
            this.tableFiledListMgmt.SuspendLayout();
            this.grpLocalTimer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.tableCurrentConfig, 0, 0);
            this.tableMain.Controls.Add(this.tableFieldControl, 1, 1);
            this.tableMain.Controls.Add(this.tableCommStatus, 1, 0);
            this.tableMain.Controls.Add(this.tableOther, 0, 2);
            this.tableMain.Controls.Add(this.tableLinks, 1, 3);
            this.tableMain.Controls.Add(this.tableFiledListMgmt, 0, 3);
            this.tableMain.Controls.Add(this.flowFields, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 4;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableMain.Size = new System.Drawing.Size(901, 586);
            this.tableMain.TabIndex = 0;
            // 
            // tableCurrentConfig
            // 
            this.tableCurrentConfig.AutoSize = true;
            this.tableCurrentConfig.ColumnCount = 2;
            this.tableCurrentConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableCurrentConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCurrentConfig.Controls.Add(this.label1, 0, 1);
            this.tableCurrentConfig.Controls.Add(this.lblDivIDLabel, 0, 2);
            this.tableCurrentConfig.Controls.Add(this.lblMode, 1, 1);
            this.tableCurrentConfig.Controls.Add(this.lblDivID, 1, 2);
            this.tableCurrentConfig.Controls.Add(this.label9, 0, 0);
            this.tableCurrentConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCurrentConfig.Location = new System.Drawing.Point(3, 3);
            this.tableCurrentConfig.Name = "tableCurrentConfig";
            this.tableCurrentConfig.RowCount = 3;
            this.tableCurrentConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableCurrentConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCurrentConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCurrentConfig.Size = new System.Drawing.Size(264, 70);
            this.tableCurrentConfig.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDivIDLabel
            // 
            this.lblDivIDLabel.AutoSize = true;
            this.lblDivIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDivIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivIDLabel.Location = new System.Drawing.Point(3, 45);
            this.lblDivIDLabel.Name = "lblDivIDLabel";
            this.lblDivIDLabel.Size = new System.Drawing.Size(86, 25);
            this.lblDivIDLabel.TabIndex = 1;
            this.lblDivIDLabel.Text = "Division:";
            this.lblDivIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMode.Location = new System.Drawing.Point(95, 20);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(166, 25);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Unknown";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDivID
            // 
            this.lblDivID.AutoSize = true;
            this.lblDivID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDivID.Location = new System.Drawing.Point(95, 45);
            this.lblDivID.Name = "lblDivID";
            this.lblDivID.Size = new System.Drawing.Size(166, 25);
            this.lblDivID.TabIndex = 5;
            this.lblDivID.Text = "Unknown";
            this.lblDivID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tableCurrentConfig.SetColumnSpan(this.label9, 2);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Current Configuration";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableFieldControl
            // 
            this.tableFieldControl.ColumnCount = 4;
            this.tableFieldControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFieldControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFieldControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFieldControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFieldControl.Controls.Add(this.lblFieldHead, 0, 0);
            this.tableFieldControl.Controls.Add(this.label6, 0, 1);
            this.tableFieldControl.Controls.Add(this.label7, 0, 2);
            this.tableFieldControl.Controls.Add(this.label8, 0, 3);
            this.tableFieldControl.Controls.Add(this.label10, 0, 4);
            this.tableFieldControl.Controls.Add(this.label12, 0, 5);
            this.tableFieldControl.Controls.Add(this.lblCurrentPeriod, 2, 2);
            this.tableFieldControl.Controls.Add(this.lblMatchStatus, 2, 3);
            this.tableFieldControl.Controls.Add(this.lblTimerValue, 2, 5);
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
            this.tableFieldControl.Controls.Add(this.pictureBox1, 3, 9);
            this.tableFieldControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFieldControl.Location = new System.Drawing.Point(273, 79);
            this.tableFieldControl.Name = "tableFieldControl";
            this.tableFieldControl.RowCount = 11;
            this.tableMain.SetRowSpan(this.tableFieldControl, 2);
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
            this.tableFieldControl.Size = new System.Drawing.Size(625, 454);
            this.tableFieldControl.TabIndex = 3;
            // 
            // lblFieldHead
            // 
            this.lblFieldHead.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.lblFieldHead, 4);
            this.lblFieldHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldHead.Location = new System.Drawing.Point(3, 0);
            this.lblFieldHead.Name = "lblFieldHead";
            this.lblFieldHead.Size = new System.Drawing.Size(619, 30);
            this.lblFieldHead.TabIndex = 0;
            this.lblFieldHead.Text = "No Selected Field";
            this.lblFieldHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Match Type:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Current Period:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Match Status:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.label10, 2);
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(306, 30);
            this.label10.TabIndex = 4;
            this.label10.Text = "Match Number:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.label12, 2);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(306, 30);
            this.label12.TabIndex = 6;
            this.label12.Text = "Timer Value:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentPeriod
            // 
            this.lblCurrentPeriod.AutoSize = true;
            this.tableFieldControl.SetColumnSpan(this.lblCurrentPeriod, 2);
            this.lblCurrentPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPeriod.Location = new System.Drawing.Point(315, 65);
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
            this.lblMatchStatus.Location = new System.Drawing.Point(315, 95);
            this.lblMatchStatus.Name = "lblMatchStatus";
            this.lblMatchStatus.Size = new System.Drawing.Size(307, 30);
            this.lblMatchStatus.TabIndex = 9;
            this.lblMatchStatus.Text = "Unknown";
            this.lblMatchStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimerValue
            // 
            this.lblTimerValue.AutoSize = true;
            this.lblTimerValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerValue.Location = new System.Drawing.Point(315, 155);
            this.lblTimerValue.Name = "lblTimerValue";
            this.lblTimerValue.Size = new System.Drawing.Size(150, 30);
            this.lblTimerValue.TabIndex = 12;
            this.lblTimerValue.Text = "Unknown";
            this.lblTimerValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMatchNumberMajor
            // 
            this.numMatchNumberMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMatchNumberMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMatchNumberMajor.Location = new System.Drawing.Point(315, 128);
            this.numMatchNumberMajor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMatchNumberMajor.Name = "numMatchNumberMajor";
            this.numMatchNumberMajor.Size = new System.Drawing.Size(150, 26);
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
            this.numMatchNumberMinor.Location = new System.Drawing.Point(471, 128);
            this.numMatchNumberMinor.Name = "numMatchNumberMinor";
            this.numMatchNumberMinor.Size = new System.Drawing.Size(151, 26);
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
            this.cboMatchType.Location = new System.Drawing.Point(315, 33);
            this.cboMatchType.Name = "cboMatchType";
            this.cboMatchType.Size = new System.Drawing.Size(307, 28);
            this.cboMatchType.TabIndex = 15;
            this.cboMatchType.SelectedIndexChanged += new System.EventHandler(this.MatchTypeChangeHandler);
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tableFieldControl.SetColumnSpan(this.btnStart, 2);
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 238);
            this.btnStart.Name = "btnStart";
            this.btnStart.PulseSpeed = 35;
            this.btnStart.Size = new System.Drawing.Size(306, 64);
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
            this.btnPause.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPause.Location = new System.Drawing.Point(471, 238);
            this.btnPause.Name = "btnPause";
            this.btnPause.PulseSpeed = 35;
            this.btnPause.Size = new System.Drawing.Size(151, 64);
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
            this.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(471, 308);
            this.btnStop.Name = "btnStop";
            this.btnStop.PulseSpeed = 35;
            this.btnStop.Size = new System.Drawing.Size(151, 64);
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
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(159, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.PulseSpeed = 35;
            this.btnReset.Size = new System.Drawing.Size(150, 64);
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
            this.btnAdvance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvance.Location = new System.Drawing.Point(3, 308);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.PulseSpeed = 35;
            this.btnAdvance.Size = new System.Drawing.Size(150, 64);
            this.btnAdvance.StopPulseOnMouseOver = false;
            this.btnAdvance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnAdvance, new DevComponents.DotNetBar.SuperTooltipInfo("Advance to Next Match", "Turn off help in Misc Options", "This button will advance to the next match using the available fields.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnAdvance.TabIndex = 20;
            this.btnAdvance.Text = "Advance to\r\nNext Match\r\n(F2)";
            this.btnAdvance.Click += new System.EventHandler(this.FieldControlButtonsHandler);
            // 
            // btnTimeoutStart
            // 
            this.btnTimeoutStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimeoutStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimeoutStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeoutStart.Location = new System.Drawing.Point(3, 378);
            this.btnTimeoutStart.Name = "btnTimeoutStart";
            this.btnTimeoutStart.PulseSpeed = 35;
            this.btnTimeoutStart.Size = new System.Drawing.Size(150, 64);
            this.btnTimeoutStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnTimeoutStart, new DevComponents.DotNetBar.SuperTooltipInfo("Start Timeout", "Turn off help in Misc Options", "This button will allow you to start a Timeout timer on the currently selected fie" +
            "ld. A timeout running on one field will not prevent you from starting a match on" +
            " another.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnTimeoutStart.TabIndex = 23;
            this.btnTimeoutStart.Text = "Start\r\nTimeout";
            this.btnTimeoutStart.Click += new System.EventHandler(this.HandleTimeoutButtons);
            // 
            // btnTimeoutCancel
            // 
            this.btnTimeoutCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimeoutCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimeoutCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeoutCancel.Location = new System.Drawing.Point(159, 378);
            this.btnTimeoutCancel.Name = "btnTimeoutCancel";
            this.btnTimeoutCancel.PulseSpeed = 35;
            this.btnTimeoutCancel.Size = new System.Drawing.Size(150, 64);
            this.btnTimeoutCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnTimeoutCancel, new DevComponents.DotNetBar.SuperTooltipInfo("Cancel Timeout", "Turn off help in Misc Options", "Cancels the currently running timeout on the selected field.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnTimeoutCancel.TabIndex = 24;
            this.btnTimeoutCancel.Text = "Cancel\r\nTimeout";
            this.btnTimeoutCancel.Click += new System.EventHandler(this.HandleTimeoutButtons);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FTC_Timer_Display.Properties.Resources.vaflogo;
            this.pictureBox1.Location = new System.Drawing.Point(471, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableCommStatus
            // 
            this.tableCommStatus.AutoSize = true;
            this.tableCommStatus.ColumnCount = 5;
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableCommStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCommStatus.Controls.Add(this.btnCycleListener, 0, 2);
            this.tableCommStatus.Controls.Add(this.label5, 0, 0);
            this.tableCommStatus.Controls.Add(this.label13, 0, 1);
            this.tableCommStatus.Controls.Add(this.lblListenStatus, 1, 1);
            this.tableCommStatus.Controls.Add(this.label14, 2, 1);
            this.tableCommStatus.Controls.Add(this.lblLastSvrIP, 4, 1);
            this.tableCommStatus.Controls.Add(this.label15, 2, 2);
            this.tableCommStatus.Controls.Add(this.lblLastRecvTime, 4, 2);
            this.tableCommStatus.Controls.Add(this.picRcvTime, 3, 2);
            this.tableCommStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCommStatus.Location = new System.Drawing.Point(273, 3);
            this.tableCommStatus.Name = "tableCommStatus";
            this.tableCommStatus.RowCount = 3;
            this.tableCommStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableCommStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCommStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCommStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCommStatus.Size = new System.Drawing.Size(625, 70);
            this.tableCommStatus.TabIndex = 4;
            // 
            // btnCycleListener
            // 
            this.btnCycleListener.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCycleListener.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tableCommStatus.SetColumnSpan(this.btnCycleListener, 2);
            this.btnCycleListener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCycleListener.Enabled = false;
            this.btnCycleListener.Location = new System.Drawing.Point(3, 48);
            this.btnCycleListener.Name = "btnCycleListener";
            this.btnCycleListener.Size = new System.Drawing.Size(290, 19);
            this.btnCycleListener.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnCycleListener, new DevComponents.DotNetBar.SuperTooltipInfo("Change Controlling Location", "Turn off help in Misc Options", "This will change the status of the listening socket and swap control from a Serve" +
            "r to the Local Client and back.\r\n\r\nThis is not available in some Run Modes.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnCycleListener.TabIndex = 3;
            this.btnCycleListener.Text = "Chg";
            this.btnCycleListener.Click += new System.EventHandler(this.btnCycleListener_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableCommStatus.SetColumnSpan(this.label5, 5);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(619, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Communications Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Listener Status:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblListenStatus
            // 
            this.lblListenStatus.AutoSize = true;
            this.lblListenStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListenStatus.Location = new System.Drawing.Point(151, 20);
            this.lblListenStatus.Name = "lblListenStatus";
            this.lblListenStatus.Size = new System.Drawing.Size(142, 25);
            this.lblListenStatus.TabIndex = 2;
            this.lblListenStatus.Text = "Unknown";
            this.lblListenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(299, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Last Received From:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastSvrIP
            // 
            this.lblLastSvrIP.AutoSize = true;
            this.lblLastSvrIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastSvrIP.Location = new System.Drawing.Point(477, 20);
            this.lblLastSvrIP.Name = "lblLastSvrIP";
            this.lblLastSvrIP.Size = new System.Drawing.Size(145, 25);
            this.lblLastSvrIP.TabIndex = 6;
            this.lblLastSvrIP.Text = "Never";
            this.lblLastSvrIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(299, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 25);
            this.label15.TabIndex = 5;
            this.label15.Text = "Last Receive Time:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastRecvTime
            // 
            this.lblLastRecvTime.AutoSize = true;
            this.lblLastRecvTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastRecvTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastRecvTime.Location = new System.Drawing.Point(477, 45);
            this.lblLastRecvTime.Name = "lblLastRecvTime";
            this.lblLastRecvTime.Size = new System.Drawing.Size(145, 25);
            this.lblLastRecvTime.TabIndex = 7;
            this.lblLastRecvTime.Text = "Never";
            this.lblLastRecvTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picRcvTime
            // 
            this.picRcvTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRcvTime.Image = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.picRcvTime.Location = new System.Drawing.Point(447, 48);
            this.picRcvTime.Name = "picRcvTime";
            this.picRcvTime.Size = new System.Drawing.Size(24, 19);
            this.picRcvTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toolTipMgr.SetSuperTooltip(this.picRcvTime, new DevComponents.DotNetBar.SuperTooltipInfo("Receiving Indicator", "Turn off help in Misc Options", "This indicates the receiving status of the local timer.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.picRcvTime.TabIndex = 8;
            this.picRcvTime.TabStop = false;
            // 
            // tableOther
            // 
            this.tableOther.ColumnCount = 2;
            this.tableOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOther.Controls.Add(this.groupBox2, 1, 0);
            this.tableOther.Controls.Add(this.grpLocalTimer, 1, 1);
            this.tableOther.Controls.Add(this.groupBox1, 0, 1);
            this.tableOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOther.Location = new System.Drawing.Point(3, 309);
            this.tableOther.Name = "tableOther";
            this.tableOther.RowCount = 2;
            this.tableOther.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOther.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOther.Size = new System.Drawing.Size(264, 224);
            this.tableOther.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(135, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 106);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.linkSetMatchTimes);
            this.flowLayoutPanel4.Controls.Add(this.linkSettings);
            this.flowLayoutPanel4.Controls.Add(this.linkSoundTest);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(120, 87);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // linkSetMatchTimes
            // 
            this.linkSetMatchTimes.AutoSize = true;
            this.linkSetMatchTimes.Location = new System.Drawing.Point(3, 0);
            this.linkSetMatchTimes.Name = "linkSetMatchTimes";
            this.linkSetMatchTimes.Size = new System.Drawing.Size(92, 13);
            this.toolTipMgr.SetSuperTooltip(this.linkSetMatchTimes, new DevComponents.DotNetBar.SuperTooltipInfo("Edit Match Timing", "Turn off help in Misc Options", "Allows you to set a custom match length as well as custom lengths for all periods" +
            ".\r\nCustom Alliance sizes are also configured here.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.linkSetMatchTimes.TabIndex = 2;
            this.linkSetMatchTimes.TabStop = true;
            this.linkSetMatchTimes.Text = "Edit Match Timing";
            this.linkSetMatchTimes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HandleOptionsLinkLabels);
            // 
            // linkSettings
            // 
            this.linkSettings.AutoSize = true;
            this.linkSettings.Location = new System.Drawing.Point(3, 13);
            this.linkSettings.Name = "linkSettings";
            this.linkSettings.Size = new System.Drawing.Size(45, 13);
            this.linkSettings.TabIndex = 1;
            this.linkSettings.TabStop = true;
            this.linkSettings.Text = "Settings";
            this.linkSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HandleOptionsLinkLabels);
            // 
            // linkSoundTest
            // 
            this.linkSoundTest.AutoSize = true;
            this.linkSoundTest.Location = new System.Drawing.Point(3, 26);
            this.linkSoundTest.Name = "linkSoundTest";
            this.linkSoundTest.Size = new System.Drawing.Size(67, 13);
            this.toolTipMgr.SetSuperTooltip(this.linkSoundTest, new DevComponents.DotNetBar.SuperTooltipInfo("Test Sounds", "Turn off help in Misc Options", "Allows testing of loaded sound resources locally.\r\nThis is not affected by the So" +
            "und Location selected.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.linkSoundTest.TabIndex = 3;
            this.linkSoundTest.TabStop = true;
            this.linkSoundTest.Text = "Test Sounds";
            this.linkSoundTest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HandleOptionsLinkLabels);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.lblDisplayStatus, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnChangeDisplayState, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(120, 87);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // lblDisplayStatus
            // 
            this.lblDisplayStatus.AutoSize = true;
            this.lblDisplayStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplayStatus.Location = new System.Drawing.Point(3, 0);
            this.lblDisplayStatus.Name = "lblDisplayStatus";
            this.lblDisplayStatus.Size = new System.Drawing.Size(114, 25);
            this.lblDisplayStatus.TabIndex = 0;
            this.lblDisplayStatus.Text = "Unknown";
            this.lblDisplayStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangeDisplayState
            // 
            this.btnChangeDisplayState.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeDisplayState.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChangeDisplayState.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeDisplayState.Location = new System.Drawing.Point(3, 28);
            this.btnChangeDisplayState.Name = "btnChangeDisplayState";
            this.btnChangeDisplayState.Size = new System.Drawing.Size(114, 41);
            this.btnChangeDisplayState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChangeDisplayState.TabIndex = 1;
            this.btnChangeDisplayState.Text = "Change\r\nDisplay Status";
            this.btnChangeDisplayState.Click += new System.EventHandler(this.btnChangeDisplayState_Click);
            // 
            // tableLinks
            // 
            this.tableLinks.ColumnCount = 4;
            this.tableLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLinks.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLinks.Controls.Add(this.picLicense, 3, 0);
            this.tableLinks.Controls.Add(this.lblVer, 2, 0);
            this.tableLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLinks.Location = new System.Drawing.Point(273, 539);
            this.tableLinks.Name = "tableLinks";
            this.tableLinks.RowCount = 1;
            this.tableLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLinks.Size = new System.Drawing.Size(625, 44);
            this.tableLinks.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.tableLinks.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.labelX1);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 38);
            this.flowLayoutPanel1.TabIndex = 0;
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
            // picLicense
            // 
            this.picLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLicense.Image = global::FTC_Timer_Display.Properties.Resources.ccShareAlike;
            this.picLicense.Location = new System.Drawing.Point(471, 3);
            this.picLicense.Name = "picLicense";
            this.picLicense.Size = new System.Drawing.Size(151, 38);
            this.picLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLicense.TabIndex = 1;
            this.picLicense.TabStop = false;
            this.picLicense.Click += new System.EventHandler(this.picLicense_Click);
            // 
            // lblVer
            // 
            // 
            // 
            // 
            this.lblVer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVer.Location = new System.Drawing.Point(315, 3);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(150, 38);
            this.lblVer.TabIndex = 2;
            this.lblVer.Text = "Version 1.0.0.0";
            this.lblVer.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tableFiledListMgmt
            // 
            this.tableFiledListMgmt.ColumnCount = 2;
            this.tableFiledListMgmt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFiledListMgmt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFiledListMgmt.Controls.Add(this.btnAddField, 0, 0);
            this.tableFiledListMgmt.Controls.Add(this.btnRemoveField, 1, 0);
            this.tableFiledListMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFiledListMgmt.Location = new System.Drawing.Point(3, 539);
            this.tableFiledListMgmt.Name = "tableFiledListMgmt";
            this.tableFiledListMgmt.RowCount = 1;
            this.tableFiledListMgmt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFiledListMgmt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableFiledListMgmt.Size = new System.Drawing.Size(264, 44);
            this.tableFiledListMgmt.TabIndex = 8;
            // 
            // btnAddField
            // 
            this.btnAddField.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddField.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddField.Location = new System.Drawing.Point(3, 3);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(126, 38);
            this.btnAddField.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnAddField, new DevComponents.DotNetBar.SuperTooltipInfo("Add Field", "Turn off help in Misc Options", "Adds a field to this server so it may be controlled.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnAddField.TabIndex = 0;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.Click += new System.EventHandler(this.HandleFieldListMgmtButtons);
            // 
            // btnRemoveField
            // 
            this.btnRemoveField.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemoveField.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemoveField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveField.Location = new System.Drawing.Point(135, 3);
            this.btnRemoveField.Name = "btnRemoveField";
            this.btnRemoveField.Size = new System.Drawing.Size(126, 38);
            this.btnRemoveField.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnRemoveField, new DevComponents.DotNetBar.SuperTooltipInfo("Remove Field", "Turn off help in Misc Options", "Removes a field from this server.\r\n(This feature currently bugged.)", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnRemoveField.TabIndex = 1;
            this.btnRemoveField.Text = "Remove Field";
            this.btnRemoveField.Click += new System.EventHandler(this.HandleFieldListMgmtButtons);
            // 
            // displayTimer
            // 
            this.displayTimer.Enabled = true;
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
            // flowFields
            // 
            this.flowFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFields.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowFields.Location = new System.Drawing.Point(3, 79);
            this.flowFields.Name = "flowFields";
            this.flowFields.Size = new System.Drawing.Size(264, 224);
            this.flowFields.TabIndex = 9;
            // 
            // swLocalMute
            // 
            // 
            // 
            // 
            this.swLocalMute.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swLocalMute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swLocalMute.Location = new System.Drawing.Point(3, 16);
            this.swLocalMute.Name = "swLocalMute";
            this.swLocalMute.OffText = "NOT MUTED";
            this.swLocalMute.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.swLocalMute.OnText = "MUTED";
            this.swLocalMute.Size = new System.Drawing.Size(120, 87);
            this.swLocalMute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swLocalMute.TabIndex = 7;
            this.swLocalMute.ValueChanged += new System.EventHandler(this.LocalMuteHandler);
            // 
            // grpLocalTimer
            // 
            this.grpLocalTimer.Controls.Add(this.tableLayoutPanel6);
            this.grpLocalTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLocalTimer.Location = new System.Drawing.Point(135, 115);
            this.grpLocalTimer.Name = "grpLocalTimer";
            this.grpLocalTimer.Size = new System.Drawing.Size(126, 106);
            this.grpLocalTimer.TabIndex = 9;
            this.grpLocalTimer.TabStop = false;
            this.grpLocalTimer.Text = "Local Timer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.swLocalMute);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Mute";
            // 
            // progressDisplay
            // 
            this.tableFieldControl.SetColumnSpan(this.progressDisplay, 4);
            this.progressDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressDisplay.Location = new System.Drawing.Point(3, 188);
            this.progressDisplay.Name = "progressDisplay";
            this.progressDisplay.Size = new System.Drawing.Size(619, 44);
            this.progressDisplay.TabIndex = 21;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 586);
            this.Controls.Add(this.tableMain);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirginiaFIRST FTC Match Timer Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.tableCurrentConfig.ResumeLayout(false);
            this.tableCurrentConfig.PerformLayout();
            this.tableFieldControl.ResumeLayout(false);
            this.tableFieldControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMinor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableCommStatus.ResumeLayout(false);
            this.tableCommStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRcvTime)).EndInit();
            this.tableOther.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLinks.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicense)).EndInit();
            this.tableFiledListMgmt.ResumeLayout(false);
            this.grpLocalTimer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TableLayoutPanel tableCurrentConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDivIDLabel;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblDivID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer displayTimer;
        private System.Windows.Forms.TableLayoutPanel tableFieldControl;
        private System.Windows.Forms.Label lblFieldHead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCurrentPeriod;
        private System.Windows.Forms.Label lblMatchStatus;
        private System.Windows.Forms.Label lblTimerValue;
        private System.Windows.Forms.NumericUpDown numMatchNumberMajor;
        private System.Windows.Forms.NumericUpDown numMatchNumberMinor;
        private System.Windows.Forms.ComboBox cboMatchType;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private DevComponents.DotNetBar.ButtonX btnPause;
        private DevComponents.DotNetBar.ButtonX btnStop;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnAdvance;
        private DevComponents.DotNetBar.ButtonX btnAddField;
        private System.Windows.Forms.TableLayoutPanel tableCommStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblListenStatus;
        private DevComponents.DotNetBar.ButtonX btnCycleListener;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLastRecvTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLastSvrIP;
        private System.Windows.Forms.TableLayoutPanel tableOther;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.LinkLabel linkSettings;
        private System.Windows.Forms.LinkLabel linkSetMatchTimes;
        private System.Windows.Forms.TableLayoutPanel tableLinks;
        private System.Windows.Forms.TableLayoutPanel tableFiledListMgmt;
        private DevComponents.DotNetBar.ButtonX btnRemoveField;
        private PeriodProgressBar progressDisplay;
        private DevComponents.DotNetBar.StyleManager styleMgr;
        private System.Windows.Forms.PictureBox picRcvTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox picLicense;
        private DevComponents.DotNetBar.LabelX lblVer;
        private DevComponents.DotNetBar.ButtonX btnTimeoutStart;
        private DevComponents.DotNetBar.ButtonX btnTimeoutCancel;
        private DevComponents.DotNetBar.SuperTooltip toolTipMgr;
        private System.Windows.Forms.LinkLabel linkSoundTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblDisplayStatus;
        private DevComponents.DotNetBar.ButtonX btnChangeDisplayState;
        private System.Windows.Forms.FlowLayoutPanel flowFields;
        private DevComponents.DotNetBar.Controls.SwitchButton swLocalMute;
        private System.Windows.Forms.GroupBox grpLocalTimer;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}