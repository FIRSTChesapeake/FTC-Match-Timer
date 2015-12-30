namespace FTC_Timer_Display
{
    partial class frmModeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModeSelection));
            this.btnContinue = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoServer = new System.Windows.Forms.RadioButton();
            this.rdoClient = new System.Windows.Forms.RadioButton();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.rdoPit = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPitPort = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDivName = new System.Windows.Forms.TextBox();
            this.rdoServerOnly = new System.Windows.Forms.RadioButton();
            this.lblDivName = new System.Windows.Forms.Label();
            this.tableServer = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEventType = new System.Windows.Forms.ComboBox();
            this.swLoadFields = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.tableClient = new System.Windows.Forms.TableLayoutPanel();
            this.numField = new DevComponents.Editors.IntegerInput();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.swMultiDivision = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.numDivID = new DevComponents.Editors.IntegerInput();
            this.appModeFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.headerAppMode = new FTC_Timer_Display.CtrlHeader();
            this.headerServer = new FTC_Timer_Display.CtrlHeader();
            this.headerGlobal = new FTC_Timer_Display.CtrlHeader();
            this.headerClient = new FTC_Timer_Display.CtrlHeader();
            this.lblVersion = new DevComponents.DotNetBar.LabelX();
            this.tableServer.SuspendLayout();
            this.tableClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numField)).BeginInit();
            this.tableMain.SuspendLayout();
            this.tableGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDivID)).BeginInit();
            this.appModeFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContinue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(3, 254);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(237, 39);
            this.btnContinue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continue";
            this.btnContinue.Click += new System.EventHandler(this.handleButtons);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(246, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(238, 39);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Exit";
            this.btnCancel.Click += new System.EventHandler(this.handleButtons);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Division ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Field Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoServer
            // 
            this.rdoServer.AutoSize = true;
            this.rdoServer.Checked = true;
            this.rdoServer.Location = new System.Drawing.Point(3, 3);
            this.rdoServer.Name = "rdoServer";
            this.rdoServer.Size = new System.Drawing.Size(94, 17);
            this.rdoServer.TabIndex = 10;
            this.rdoServer.TabStop = true;
            this.rdoServer.Text = "Server && Client";
            this.toolTip1.SetToolTip(this.rdoServer, "This mode allows you to control a local timer as well as a number of remote timer" +
        "s.");
            this.rdoServer.UseVisualStyleBackColor = true;
            this.rdoServer.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // rdoClient
            // 
            this.rdoClient.AutoSize = true;
            this.rdoClient.Location = new System.Drawing.Point(3, 49);
            this.rdoClient.Name = "rdoClient";
            this.rdoClient.Size = new System.Drawing.Size(51, 17);
            this.rdoClient.TabIndex = 12;
            this.rdoClient.Text = "Client";
            this.toolTip1.SetToolTip(this.rdoClient, "This mode creates a dependent timer which is controlled by a server elsewhere.");
            this.rdoClient.UseVisualStyleBackColor = true;
            this.rdoClient.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // rdoLocal
            // 
            this.rdoLocal.AutoSize = true;
            this.rdoLocal.Location = new System.Drawing.Point(3, 72);
            this.rdoLocal.Name = "rdoLocal";
            this.rdoLocal.Size = new System.Drawing.Size(75, 17);
            this.rdoLocal.TabIndex = 13;
            this.rdoLocal.TabStop = true;
            this.rdoLocal.Text = "Local Only";
            this.toolTip1.SetToolTip(this.rdoLocal, "This mode creates a local timer than is only controlled locally.\r\nFurther, this m" +
        "ode creates no sockets, allowing it to run on restricted computers\r\nthat are not" +
        " allowed to open udp ports.");
            this.rdoLocal.UseVisualStyleBackColor = true;
            this.rdoLocal.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // rdoPit
            // 
            this.rdoPit.AutoSize = true;
            this.rdoPit.Location = new System.Drawing.Point(103, 3);
            this.rdoPit.Name = "rdoPit";
            this.rdoPit.Size = new System.Drawing.Size(74, 17);
            this.rdoPit.TabIndex = 14;
            this.rdoPit.TabStop = true;
            this.rdoPit.Text = "Pit Display";
            this.toolTip1.SetToolTip(this.rdoPit, "This mode displays a summary of all fields broadcasting from Servers.");
            this.rdoPit.UseVisualStyleBackColor = true;
            this.rdoPit.Visible = false;
            this.rdoPit.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Scoring Port:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // txtPitPort
            // 
            this.txtPitPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPitPort.Enabled = false;
            this.txtPitPort.Location = new System.Drawing.Point(87, 78);
            this.txtPitPort.Name = "txtPitPort";
            this.txtPitPort.Size = new System.Drawing.Size(148, 20);
            this.txtPitPort.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtPitPort, "This is the port the scoring software broadcasts its data to.\r\nThis is not used u" +
        "nless an IP is also specified within the application.");
            this.txtPitPort.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // txtDivName
            // 
            this.txtDivName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDivName.Location = new System.Drawing.Point(87, 3);
            this.txtDivName.Name = "txtDivName";
            this.txtDivName.Size = new System.Drawing.Size(148, 20);
            this.txtDivName.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDivName, resources.GetString("txtDivName.ToolTip"));
            // 
            // rdoServerOnly
            // 
            this.rdoServerOnly.AutoSize = true;
            this.rdoServerOnly.Location = new System.Drawing.Point(3, 26);
            this.rdoServerOnly.Name = "rdoServerOnly";
            this.rdoServerOnly.Size = new System.Drawing.Size(80, 17);
            this.rdoServerOnly.TabIndex = 11;
            this.rdoServerOnly.Text = "Server Only";
            this.toolTip1.SetToolTip(this.rdoServerOnly, "This mode allows you to control a number of remote timers.\r\nHowever, there is no " +
        "local timer.");
            this.rdoServerOnly.UseVisualStyleBackColor = true;
            this.rdoServerOnly.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // lblDivName
            // 
            this.lblDivName.AutoSize = true;
            this.lblDivName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDivName.Location = new System.Drawing.Point(3, 0);
            this.lblDivName.Name = "lblDivName";
            this.lblDivName.Size = new System.Drawing.Size(78, 25);
            this.lblDivName.TabIndex = 4;
            this.lblDivName.Text = "Division Name:";
            this.lblDivName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableServer
            // 
            this.tableServer.ColumnCount = 2;
            this.tableServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableServer.Controls.Add(this.lblDivName, 0, 0);
            this.tableServer.Controls.Add(this.txtDivName, 1, 0);
            this.tableServer.Controls.Add(this.label2, 0, 1);
            this.tableServer.Controls.Add(this.cboEventType, 1, 1);
            this.tableServer.Controls.Add(this.label5, 0, 3);
            this.tableServer.Controls.Add(this.txtPitPort, 1, 3);
            this.tableServer.Controls.Add(this.swLoadFields, 0, 2);
            this.tableServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableServer.Location = new System.Drawing.Point(246, 28);
            this.tableServer.Name = "tableServer";
            this.tableServer.RowCount = 4;
            this.tableServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableServer.Size = new System.Drawing.Size(238, 100);
            this.tableServer.TabIndex = 0;
            this.tableServer.EnabledChanged += new System.EventHandler(this.tablesEnableHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Event Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEventType
            // 
            this.cboEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventType.FormattingEnabled = true;
            this.cboEventType.Items.AddRange(new object[] {
            "Qualifier",
            "Meet",
            "Championship"});
            this.cboEventType.Location = new System.Drawing.Point(87, 28);
            this.cboEventType.Name = "cboEventType";
            this.cboEventType.Size = new System.Drawing.Size(127, 21);
            this.cboEventType.TabIndex = 20;
            // 
            // swLoadFields
            // 
            // 
            // 
            // 
            this.swLoadFields.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableServer.SetColumnSpan(this.swLoadFields, 2);
            this.swLoadFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swLoadFields.Location = new System.Drawing.Point(3, 53);
            this.swLoadFields.Name = "swLoadFields";
            this.swLoadFields.OffText = "Clear Previous Fields";
            this.swLoadFields.OnText = "Load Previous Fields";
            this.swLoadFields.Size = new System.Drawing.Size(232, 19);
            this.swLoadFields.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swLoadFields.TabIndex = 21;
            this.swLoadFields.Value = true;
            this.swLoadFields.ValueObject = "Y";
            // 
            // tableClient
            // 
            this.tableClient.ColumnCount = 2;
            this.tableClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableClient.Controls.Add(this.label3, 0, 1);
            this.tableClient.Controls.Add(this.numField, 1, 1);
            this.tableClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableClient.Location = new System.Drawing.Point(246, 159);
            this.tableClient.Name = "tableClient";
            this.tableClient.RowCount = 3;
            this.tableClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableClient.Size = new System.Drawing.Size(238, 68);
            this.tableClient.TabIndex = 0;
            this.tableClient.EnabledChanged += new System.EventHandler(this.tablesEnableHandler);
            // 
            // numField
            // 
            this.numField.AutoOverwrite = true;
            // 
            // 
            // 
            this.numField.BackgroundStyle.Class = "DateTimeInputBackground";
            this.numField.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numField.ButtonCalculator.Visible = true;
            this.numField.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.numField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numField.Location = new System.Drawing.Point(122, 28);
            this.numField.MaxValue = 9;
            this.numField.MinValue = 1;
            this.numField.Name = "numField";
            this.numField.ShowUpDown = true;
            this.numField.Size = new System.Drawing.Size(113, 20);
            this.numField.TabIndex = 9;
            this.numField.Value = 1;
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Controls.Add(this.tableClient, 1, 3);
            this.tableMain.Controls.Add(this.tableGlobal, 0, 3);
            this.tableMain.Controls.Add(this.tableServer, 1, 1);
            this.tableMain.Controls.Add(this.appModeFlow, 0, 1);
            this.tableMain.Controls.Add(this.btnCancel, 1, 5);
            this.tableMain.Controls.Add(this.btnContinue, 0, 5);
            this.tableMain.Controls.Add(this.headerAppMode, 0, 0);
            this.tableMain.Controls.Add(this.headerServer, 1, 0);
            this.tableMain.Controls.Add(this.headerGlobal, 0, 2);
            this.tableMain.Controls.Add(this.headerClient, 1, 2);
            this.tableMain.Controls.Add(this.lblVersion, 1, 4);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 6;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableMain.Size = new System.Drawing.Size(487, 296);
            this.tableMain.TabIndex = 2;
            // 
            // tableGlobal
            // 
            this.tableGlobal.ColumnCount = 2;
            this.tableGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableGlobal.Controls.Add(this.label1, 0, 1);
            this.tableGlobal.Controls.Add(this.swMultiDivision, 0, 0);
            this.tableGlobal.Controls.Add(this.numDivID, 1, 1);
            this.tableGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGlobal.Location = new System.Drawing.Point(3, 159);
            this.tableGlobal.Name = "tableGlobal";
            this.tableGlobal.RowCount = 3;
            this.tableGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableGlobal.Size = new System.Drawing.Size(237, 68);
            this.tableGlobal.TabIndex = 0;
            // 
            // swMultiDivision
            // 
            // 
            // 
            // 
            this.swMultiDivision.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableGlobal.SetColumnSpan(this.swMultiDivision, 2);
            this.swMultiDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swMultiDivision.Location = new System.Drawing.Point(3, 3);
            this.swMultiDivision.Name = "swMultiDivision";
            this.swMultiDivision.OffText = "Single Division Event";
            this.swMultiDivision.OnText = "Multi-Division Event";
            this.swMultiDivision.Size = new System.Drawing.Size(231, 19);
            this.swMultiDivision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swMultiDivision.TabIndex = 7;
            this.swMultiDivision.Value = true;
            this.swMultiDivision.ValueObject = "Y";
            // 
            // numDivID
            // 
            this.numDivID.AutoOverwrite = true;
            // 
            // 
            // 
            this.numDivID.BackgroundStyle.Class = "DateTimeInputBackground";
            this.numDivID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numDivID.ButtonCalculator.Visible = true;
            this.numDivID.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.numDivID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDivID.Location = new System.Drawing.Point(121, 28);
            this.numDivID.MaxValue = 9;
            this.numDivID.MinValue = 1;
            this.numDivID.Name = "numDivID";
            this.numDivID.ShowUpDown = true;
            this.numDivID.Size = new System.Drawing.Size(113, 20);
            this.numDivID.TabIndex = 8;
            this.numDivID.Value = 1;
            // 
            // appModeFlow
            // 
            this.appModeFlow.Controls.Add(this.rdoServer);
            this.appModeFlow.Controls.Add(this.rdoServerOnly);
            this.appModeFlow.Controls.Add(this.rdoClient);
            this.appModeFlow.Controls.Add(this.rdoLocal);
            this.appModeFlow.Controls.Add(this.rdoPit);
            this.appModeFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appModeFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.appModeFlow.Location = new System.Drawing.Point(3, 28);
            this.appModeFlow.Name = "appModeFlow";
            this.appModeFlow.Size = new System.Drawing.Size(237, 100);
            this.appModeFlow.TabIndex = 0;
            // 
            // headerAppMode
            // 
            // 
            // 
            // 
            this.headerAppMode.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerAppMode.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.headerAppMode.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.headerAppMode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.headerAppMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerAppMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.headerAppMode.Location = new System.Drawing.Point(3, 3);
            this.headerAppMode.Name = "headerAppMode";
            this.headerAppMode.Size = new System.Drawing.Size(237, 19);
            this.headerAppMode.TabIndex = 20;
            this.headerAppMode.Text = "Application Mode";
            this.headerAppMode.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // headerServer
            // 
            // 
            // 
            // 
            this.headerServer.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerServer.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.headerServer.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.headerServer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.headerServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.headerServer.Location = new System.Drawing.Point(246, 3);
            this.headerServer.Name = "headerServer";
            this.headerServer.Size = new System.Drawing.Size(238, 19);
            this.headerServer.TabIndex = 21;
            this.headerServer.Text = "Server / Local Options";
            this.headerServer.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // headerGlobal
            // 
            // 
            // 
            // 
            this.headerGlobal.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerGlobal.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.headerGlobal.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.headerGlobal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.headerGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.headerGlobal.Location = new System.Drawing.Point(3, 134);
            this.headerGlobal.Name = "headerGlobal";
            this.headerGlobal.Size = new System.Drawing.Size(237, 19);
            this.headerGlobal.TabIndex = 22;
            this.headerGlobal.Text = "Global Options";
            this.headerGlobal.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // headerClient
            // 
            // 
            // 
            // 
            this.headerClient.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerClient.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.headerClient.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.headerClient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.headerClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.headerClient.Location = new System.Drawing.Point(246, 134);
            this.headerClient.Name = "headerClient";
            this.headerClient.Size = new System.Drawing.Size(238, 19);
            this.headerClient.TabIndex = 23;
            this.headerClient.Text = "Client / Local Options";
            this.headerClient.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            // 
            // 
            // 
            this.lblVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(404, 233);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(80, 15);
            this.lblVersion.TabIndex = 24;
            this.lblVersion.Text = "Version 0.0.0.0";
            this.lblVersion.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lblVersion.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 296);
            this.ControlBox = false;
            this.Controls.Add(this.tableMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModeSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Setup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmModeSelection_Load);
            this.tableServer.ResumeLayout(false);
            this.tableServer.PerformLayout();
            this.tableClient.ResumeLayout(false);
            this.tableClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numField)).EndInit();
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.tableGlobal.ResumeLayout(false);
            this.tableGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDivID)).EndInit();
            this.appModeFlow.ResumeLayout(false);
            this.appModeFlow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnContinue;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoServer;
        private System.Windows.Forms.RadioButton rdoClient;
        private System.Windows.Forms.RadioButton rdoLocal;
        private System.Windows.Forms.RadioButton rdoPit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPitPort;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDivName;
        private System.Windows.Forms.TextBox txtDivName;
        private System.Windows.Forms.TableLayoutPanel tableServer;
        private System.Windows.Forms.TableLayoutPanel tableClient;
        private System.Windows.Forms.TableLayoutPanel tableGlobal;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.FlowLayoutPanel appModeFlow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEventType;
        private DevComponents.DotNetBar.Controls.SwitchButton swMultiDivision;
        private DevComponents.DotNetBar.Controls.SwitchButton swLoadFields;
        private DevComponents.Editors.IntegerInput numField;
        private DevComponents.Editors.IntegerInput numDivID;
        private System.Windows.Forms.RadioButton rdoServerOnly;
        private CtrlHeader headerAppMode;
        private CtrlHeader headerServer;
        private CtrlHeader headerGlobal;
        private CtrlHeader headerClient;
        private DevComponents.DotNetBar.LabelX lblVersion;
    }
}