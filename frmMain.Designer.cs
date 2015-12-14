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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblDivID = new System.Windows.Forms.Label();
            this.lblDivName = new System.Windows.Forms.Label();
            this.lblFieldID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listFields = new System.Windows.Forms.ListBox();
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
            this.progressDisplay = new FTC_Timer_Display.PeriodProgressBar();
            this.btnTimeoutStart = new DevComponents.DotNetBar.ButtonX();
            this.btnTimeoutCancel = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCycleListener = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblListenStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblLastSvrIP = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLastRecvTime = new System.Windows.Forms.Label();
            this.picRcvTime = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.grpSoundOptions = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoSoundOff = new System.Windows.Forms.RadioButton();
            this.rdoSoundLocal = new System.Windows.Forms.RadioButton();
            this.rdoSoundRemote = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkLocalMute = new System.Windows.Forms.CheckBox();
            this.chkShowHelp = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkToggleDisplay = new System.Windows.Forms.LinkLabel();
            this.linkSetMatchTimes = new System.Windows.Forms.LinkLabel();
            this.linkReInit = new System.Windows.Forms.LinkLabel();
            this.linkSoundTest = new System.Windows.Forms.LinkLabel();
            this.grpPit = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoPitOff = new System.Windows.Forms.RadioButton();
            this.rdoPitActive = new System.Windows.Forms.RadioButton();
            this.rdoPitAll = new System.Windows.Forms.RadioButton();
            this.linkSetScoring = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableFieldControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMinor)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRcvTime)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpSoundOptions.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.grpPit.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicense)).BeginInit();
            this.tableFiledListMgmt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listFields, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableFieldControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableFiledListMgmt, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 662);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblMode, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDivID, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDivName, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblFieldID, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 147);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Division ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Division Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "This Field ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMode.Location = new System.Drawing.Point(101, 47);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(160, 25);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Unknown";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDivID
            // 
            this.lblDivID.AutoSize = true;
            this.lblDivID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDivID.Location = new System.Drawing.Point(101, 72);
            this.lblDivID.Name = "lblDivID";
            this.lblDivID.Size = new System.Drawing.Size(160, 25);
            this.lblDivID.TabIndex = 5;
            this.lblDivID.Text = "Unknown";
            this.lblDivID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDivName
            // 
            this.lblDivName.AutoSize = true;
            this.lblDivName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDivName.Location = new System.Drawing.Point(101, 97);
            this.lblDivName.Name = "lblDivName";
            this.lblDivName.Size = new System.Drawing.Size(160, 25);
            this.lblDivName.TabIndex = 6;
            this.lblDivName.Text = "Unknown";
            this.lblDivName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFieldID
            // 
            this.lblFieldID.AutoSize = true;
            this.lblFieldID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldID.Location = new System.Drawing.Point(101, 122);
            this.lblFieldID.Name = "lblFieldID";
            this.lblFieldID.Size = new System.Drawing.Size(160, 25);
            this.lblFieldID.TabIndex = 7;
            this.lblFieldID.Text = "Unknown";
            this.lblFieldID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label9, 2);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 47);
            this.label9.TabIndex = 8;
            this.label9.Text = "Current Configuration";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listFields
            // 
            this.listFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFields.FormattingEnabled = true;
            this.listFields.ItemHeight = 20;
            this.listFields.Location = new System.Drawing.Point(3, 156);
            this.listFields.Name = "listFields";
            this.listFields.Size = new System.Drawing.Size(264, 223);
            this.listFields.TabIndex = 1;
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
            this.tableFieldControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFieldControl.Location = new System.Drawing.Point(273, 156);
            this.tableFieldControl.Name = "tableFieldControl";
            this.tableFieldControl.RowCount = 10;
            this.tableLayoutPanel1.SetRowSpan(this.tableFieldControl, 2);
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableFieldControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFieldControl.Size = new System.Drawing.Size(625, 452);
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
            // progressDisplay
            // 
            this.tableFieldControl.SetColumnSpan(this.progressDisplay, 4);
            this.progressDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressDisplay.Location = new System.Drawing.Point(3, 188);
            this.progressDisplay.Name = "progressDisplay";
            this.progressDisplay.Size = new System.Drawing.Size(619, 44);
            this.progressDisplay.TabIndex = 21;
            // 
            // btnTimeoutStart
            // 
            this.btnTimeoutStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimeoutStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimeoutStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeoutStart.Location = new System.Drawing.Point(3, 378);
            this.btnTimeoutStart.Name = "btnTimeoutStart";
            this.btnTimeoutStart.PulseSpeed = 35;
            this.btnTimeoutStart.Size = new System.Drawing.Size(150, 71);
            this.btnTimeoutStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnTimeoutStart, new DevComponents.DotNetBar.SuperTooltipInfo("Start Timeout", "Turn off help in Misc Options", "This button will allow you to start a Timeout timer on the currently selected fie" +
            "ld. A timeout running on one field will not prevent you from starting a match on" +
            " another.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnTimeoutStart.TabIndex = 23;
            this.btnTimeoutStart.Text = "Start Timeout";
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
            this.btnTimeoutCancel.Size = new System.Drawing.Size(150, 71);
            this.btnTimeoutCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolTipMgr.SetSuperTooltip(this.btnTimeoutCancel, new DevComponents.DotNetBar.SuperTooltipInfo("Cancel Timeout", "Turn off help in Misc Options", "Cancels the currently running timeout on the selected field.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.btnTimeoutCancel.TabIndex = 24;
            this.btnTimeoutCancel.Text = "Cancel Timeout";
            this.btnTimeoutCancel.Click += new System.EventHandler(this.HandleTimeoutButtons);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btnCycleListener, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblListenStatus, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label14, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblLastSvrIP, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.label15, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblLastRecvTime, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.picRcvTime, 3, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(273, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(625, 147);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnCycleListener
            // 
            this.btnCycleListener.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCycleListener.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tableLayoutPanel4.SetColumnSpan(this.btnCycleListener, 2);
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
            this.tableLayoutPanel4.SetColumnSpan(this.label5, 5);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.grpSoundOptions, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.grpPit, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 385);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(264, 223);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // grpSoundOptions
            // 
            this.grpSoundOptions.Controls.Add(this.flowLayoutPanel2);
            this.grpSoundOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSoundOptions.Location = new System.Drawing.Point(3, 3);
            this.grpSoundOptions.Name = "grpSoundOptions";
            this.grpSoundOptions.Size = new System.Drawing.Size(126, 127);
            this.grpSoundOptions.TabIndex = 0;
            this.grpSoundOptions.TabStop = false;
            this.grpSoundOptions.Text = "Sound";
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(120, 108);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // rdoSoundOff
            // 
            this.rdoSoundOff.AutoSize = true;
            this.rdoSoundOff.Checked = true;
            this.rdoSoundOff.Location = new System.Drawing.Point(3, 3);
            this.rdoSoundOff.Name = "rdoSoundOff";
            this.rdoSoundOff.Size = new System.Drawing.Size(39, 17);
            this.rdoSoundOff.TabIndex = 0;
            this.rdoSoundOff.TabStop = true;
            this.rdoSoundOff.Text = "Off";
            this.rdoSoundOff.UseVisualStyleBackColor = true;
            this.rdoSoundOff.CheckedChanged += new System.EventHandler(this.SoundSettingChangeHandler);
            // 
            // rdoSoundLocal
            // 
            this.rdoSoundLocal.AutoSize = true;
            this.rdoSoundLocal.Location = new System.Drawing.Point(3, 26);
            this.rdoSoundLocal.Name = "rdoSoundLocal";
            this.rdoSoundLocal.Size = new System.Drawing.Size(58, 17);
            this.rdoSoundLocal.TabIndex = 1;
            this.rdoSoundLocal.Text = "Locally";
            this.rdoSoundLocal.UseVisualStyleBackColor = true;
            this.rdoSoundLocal.CheckedChanged += new System.EventHandler(this.SoundSettingChangeHandler);
            // 
            // rdoSoundRemote
            // 
            this.rdoSoundRemote.AutoSize = true;
            this.rdoSoundRemote.Location = new System.Drawing.Point(3, 49);
            this.rdoSoundRemote.Name = "rdoSoundRemote";
            this.rdoSoundRemote.Size = new System.Drawing.Size(69, 17);
            this.rdoSoundRemote.TabIndex = 2;
            this.rdoSoundRemote.Text = "Remotely";
            this.rdoSoundRemote.UseVisualStyleBackColor = true;
            this.rdoSoundRemote.CheckedChanged += new System.EventHandler(this.SoundSettingChangeHandler);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Misc Options";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.chkLocalMute);
            this.flowLayoutPanel3.Controls.Add(this.chkShowHelp);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(120, 65);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // chkLocalMute
            // 
            this.chkLocalMute.AutoSize = true;
            this.chkLocalMute.Location = new System.Drawing.Point(3, 3);
            this.chkLocalMute.Name = "chkLocalMute";
            this.chkLocalMute.Size = new System.Drawing.Size(79, 17);
            this.chkLocalMute.TabIndex = 3;
            this.chkLocalMute.Text = "Local Mute";
            this.chkLocalMute.UseVisualStyleBackColor = true;
            this.chkLocalMute.CheckedChanged += new System.EventHandler(this.LocalMuteHandler);
            // 
            // chkShowHelp
            // 
            this.chkShowHelp.AutoSize = true;
            this.chkShowHelp.Location = new System.Drawing.Point(3, 26);
            this.chkShowHelp.Name = "chkShowHelp";
            this.chkShowHelp.Size = new System.Drawing.Size(78, 17);
            this.chkShowHelp.TabIndex = 5;
            this.chkShowHelp.Text = "Show Help";
            this.chkShowHelp.UseVisualStyleBackColor = true;
            this.chkShowHelp.CheckedChanged += new System.EventHandler(this.chkShowHelp_CheckedChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.linkToggleDisplay);
            this.flowLayoutPanel4.Controls.Add(this.linkSetMatchTimes);
            this.flowLayoutPanel4.Controls.Add(this.linkReInit);
            this.flowLayoutPanel4.Controls.Add(this.linkSoundTest);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(135, 136);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(126, 84);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // linkToggleDisplay
            // 
            this.linkToggleDisplay.AutoSize = true;
            this.linkToggleDisplay.Location = new System.Drawing.Point(3, 0);
            this.linkToggleDisplay.Name = "linkToggleDisplay";
            this.linkToggleDisplay.Size = new System.Drawing.Size(77, 13);
            this.toolTipMgr.SetSuperTooltip(this.linkToggleDisplay, new DevComponents.DotNetBar.SuperTooltipInfo("Toggle Display", "Turn off help in Misc Options", "Show / Hide the timer display window.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.linkToggleDisplay.TabIndex = 0;
            this.linkToggleDisplay.TabStop = true;
            this.linkToggleDisplay.Text = "Toggle Display";
            this.linkToggleDisplay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HandleOptionsLinkLabels);
            // 
            // linkSetMatchTimes
            // 
            this.linkSetMatchTimes.AutoSize = true;
            this.linkSetMatchTimes.Location = new System.Drawing.Point(3, 13);
            this.linkSetMatchTimes.Name = "linkSetMatchTimes";
            this.linkSetMatchTimes.Size = new System.Drawing.Size(92, 13);
            this.toolTipMgr.SetSuperTooltip(this.linkSetMatchTimes, new DevComponents.DotNetBar.SuperTooltipInfo("Edit Match Timing", "Turn off help in Misc Options", "Allows you to set a custom match length as well as custom lengths for all periods" +
            ".\r\nCustom Alliance sizes are also configured here.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.linkSetMatchTimes.TabIndex = 2;
            this.linkSetMatchTimes.TabStop = true;
            this.linkSetMatchTimes.Text = "Edit Match Timing";
            this.linkSetMatchTimes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HandleOptionsLinkLabels);
            // 
            // linkReInit
            // 
            this.linkReInit.AutoSize = true;
            this.linkReInit.Enabled = false;
            this.linkReInit.Location = new System.Drawing.Point(3, 26);
            this.linkReInit.Name = "linkReInit";
            this.linkReInit.Size = new System.Drawing.Size(65, 13);
            this.linkReInit.TabIndex = 1;
            this.linkReInit.TabStop = true;
            this.linkReInit.Text = "Reconfigure";
            this.linkReInit.Visible = false;
            this.linkReInit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HandleOptionsLinkLabels);
            // 
            // linkSoundTest
            // 
            this.linkSoundTest.AutoSize = true;
            this.linkSoundTest.Location = new System.Drawing.Point(3, 39);
            this.linkSoundTest.Name = "linkSoundTest";
            this.linkSoundTest.Size = new System.Drawing.Size(67, 13);
            this.toolTipMgr.SetSuperTooltip(this.linkSoundTest, new DevComponents.DotNetBar.SuperTooltipInfo("Test Sounds", "Turn off help in Misc Options", "Allows testing of loaded sound resources locally.\r\nThis is not affected by the So" +
            "und Location selected.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.linkSoundTest.TabIndex = 3;
            this.linkSoundTest.TabStop = true;
            this.linkSoundTest.Text = "Test Sounds";
            this.linkSoundTest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HandleOptionsLinkLabels);
            // 
            // grpPit
            // 
            this.grpPit.Controls.Add(this.flowLayoutPanel5);
            this.grpPit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPit.Location = new System.Drawing.Point(135, 3);
            this.grpPit.Name = "grpPit";
            this.grpPit.Size = new System.Drawing.Size(126, 127);
            this.grpPit.TabIndex = 6;
            this.grpPit.TabStop = false;
            this.grpPit.Text = "Pit Display";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.rdoPitOff);
            this.flowLayoutPanel5.Controls.Add(this.rdoPitActive);
            this.flowLayoutPanel5.Controls.Add(this.rdoPitAll);
            this.flowLayoutPanel5.Controls.Add(this.linkSetScoring);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(120, 108);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // rdoPitOff
            // 
            this.rdoPitOff.AutoSize = true;
            this.rdoPitOff.Location = new System.Drawing.Point(3, 3);
            this.rdoPitOff.Name = "rdoPitOff";
            this.rdoPitOff.Size = new System.Drawing.Size(39, 17);
            this.toolTipMgr.SetSuperTooltip(this.rdoPitOff, new DevComponents.DotNetBar.SuperTooltipInfo("Pit Display: Off", "Turn off help in Misc Options", "Turns off the pit display.\r\nNo pit display information will be transmitted.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.rdoPitOff.TabIndex = 0;
            this.rdoPitOff.Text = "Off";
            this.rdoPitOff.UseVisualStyleBackColor = true;
            this.rdoPitOff.CheckedChanged += new System.EventHandler(this.pitDataSelectionHandler);
            // 
            // rdoPitActive
            // 
            this.rdoPitActive.AutoSize = true;
            this.rdoPitActive.Checked = true;
            this.rdoPitActive.Location = new System.Drawing.Point(3, 26);
            this.rdoPitActive.Name = "rdoPitActive";
            this.rdoPitActive.Size = new System.Drawing.Size(79, 17);
            this.toolTipMgr.SetSuperTooltip(this.rdoPitActive, new DevComponents.DotNetBar.SuperTooltipInfo("Pit Display: Active Only", "Turn off help in Misc Options", "The server will only transmit the selected field to the pit display.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.rdoPitActive.TabIndex = 1;
            this.rdoPitActive.TabStop = true;
            this.rdoPitActive.Text = "Active Only";
            this.rdoPitActive.UseVisualStyleBackColor = true;
            this.rdoPitActive.CheckedChanged += new System.EventHandler(this.pitDataSelectionHandler);
            // 
            // rdoPitAll
            // 
            this.rdoPitAll.AutoSize = true;
            this.rdoPitAll.Location = new System.Drawing.Point(3, 49);
            this.rdoPitAll.Name = "rdoPitAll";
            this.rdoPitAll.Size = new System.Drawing.Size(66, 17);
            this.toolTipMgr.SetSuperTooltip(this.rdoPitAll, new DevComponents.DotNetBar.SuperTooltipInfo("Pit Display: All Fields", "Turn off help in Misc Options", "The server will transmit all active fields to the pit display.", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.rdoPitAll.TabIndex = 2;
            this.rdoPitAll.Text = "All Fields";
            this.rdoPitAll.UseVisualStyleBackColor = true;
            this.rdoPitAll.CheckedChanged += new System.EventHandler(this.pitDataSelectionHandler);
            // 
            // linkSetScoring
            // 
            this.linkSetScoring.AutoSize = true;
            this.linkSetScoring.Location = new System.Drawing.Point(3, 69);
            this.linkSetScoring.Name = "linkSetScoring";
            this.linkSetScoring.Size = new System.Drawing.Size(96, 13);
            this.toolTipMgr.SetSuperTooltip(this.linkSetScoring, new DevComponents.DotNetBar.SuperTooltipInfo("Set Scoring Server", "Turn off help in Misc Options", "Set the IP of the Scoring Server so the Pit Displays know where to retrieve the m" +
            "atch data.\r\n(This will depreciate eventually.)", null, null, DevComponents.DotNetBar.eTooltipColor.Green));
            this.linkSetScoring.TabIndex = 3;
            this.linkSetScoring.TabStop = true;
            this.linkSetScoring.Text = "Set Scoring Server";
            this.linkSetScoring.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSetScoring_LinkClicked);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.picLicense, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblVer, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(273, 614);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(625, 45);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.labelX1);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 39);
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
            this.picLicense.Size = new System.Drawing.Size(151, 39);
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
            this.lblVer.Size = new System.Drawing.Size(150, 39);
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
            this.tableFiledListMgmt.Location = new System.Drawing.Point(3, 614);
            this.tableFiledListMgmt.Name = "tableFiledListMgmt";
            this.tableFiledListMgmt.RowCount = 1;
            this.tableFiledListMgmt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFiledListMgmt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableFiledListMgmt.Size = new System.Drawing.Size(264, 45);
            this.tableFiledListMgmt.TabIndex = 8;
            // 
            // btnAddField
            // 
            this.btnAddField.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddField.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddField.Location = new System.Drawing.Point(3, 3);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(126, 39);
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
            this.btnRemoveField.Size = new System.Drawing.Size(126, 39);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirginiaFIRST FTC Match Timer Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableFieldControl.ResumeLayout(false);
            this.tableFieldControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchNumberMinor)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRcvTime)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grpSoundOptions.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.grpPit.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicense)).EndInit();
            this.tableFiledListMgmt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblDivID;
        private System.Windows.Forms.Label lblDivName;
        private System.Windows.Forms.Label lblFieldID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listFields;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblListenStatus;
        private DevComponents.DotNetBar.ButtonX btnCycleListener;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLastRecvTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLastSvrIP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox grpSoundOptions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rdoSoundOff;
        private System.Windows.Forms.RadioButton rdoSoundLocal;
        private System.Windows.Forms.RadioButton rdoSoundRemote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox chkLocalMute;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.LinkLabel linkToggleDisplay;
        private System.Windows.Forms.LinkLabel linkReInit;
        private System.Windows.Forms.LinkLabel linkSetMatchTimes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableFiledListMgmt;
        private DevComponents.DotNetBar.ButtonX btnRemoveField;
        private PeriodProgressBar progressDisplay;
        private DevComponents.DotNetBar.StyleManager styleMgr;
        private System.Windows.Forms.PictureBox picRcvTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox picLicense;
        private System.Windows.Forms.GroupBox grpPit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.RadioButton rdoPitOff;
        private System.Windows.Forms.RadioButton rdoPitActive;
        private System.Windows.Forms.RadioButton rdoPitAll;
        private System.Windows.Forms.LinkLabel linkSetScoring;
        private DevComponents.DotNetBar.LabelX lblVer;
        private DevComponents.DotNetBar.ButtonX btnTimeoutStart;
        private DevComponents.DotNetBar.ButtonX btnTimeoutCancel;
        private System.Windows.Forms.CheckBox chkShowHelp;
        private DevComponents.DotNetBar.SuperTooltip toolTipMgr;
        private System.Windows.Forms.LinkLabel linkSoundTest;

    }
}