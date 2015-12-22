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
            this.lblDivName = new System.Windows.Forms.Label();
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEventType = new System.Windows.Forms.ComboBox();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.swMultiDivision = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.swLoadFields = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.numField = new DevComponents.Editors.IntegerInput();
            this.numDivID = new DevComponents.Editors.IntegerInput();
            this.rdoServerOnly = new System.Windows.Forms.RadioButton();
            this.grpServer.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDivID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContinue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(3, 253);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(271, 39);
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
            this.btnCancel.Location = new System.Drawing.Point(280, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(272, 39);
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
            this.label1.Size = new System.Drawing.Size(126, 25);
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
            this.label3.Size = new System.Drawing.Size(127, 25);
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
            this.rdoPit.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Scoring Broadcast Port:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // txtPitPort
            // 
            this.txtPitPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPitPort.Enabled = false;
            this.txtPitPort.Location = new System.Drawing.Point(136, 78);
            this.txtPitPort.Name = "txtPitPort";
            this.txtPitPort.Size = new System.Drawing.Size(127, 20);
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
            this.txtDivName.Location = new System.Drawing.Point(136, 3);
            this.txtDivName.Name = "txtDivName";
            this.txtDivName.Size = new System.Drawing.Size(127, 20);
            this.txtDivName.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDivName, resources.GetString("txtDivName.ToolTip"));
            // 
            // lblDivName
            // 
            this.lblDivName.AutoSize = true;
            this.lblDivName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDivName.Location = new System.Drawing.Point(3, 0);
            this.lblDivName.Name = "lblDivName";
            this.lblDivName.Size = new System.Drawing.Size(127, 25);
            this.lblDivName.TabIndex = 4;
            this.lblDivName.Text = "Division Name:";
            this.lblDivName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpServer
            // 
            this.grpServer.Controls.Add(this.tableLayoutPanel4);
            this.grpServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpServer.Location = new System.Drawing.Point(280, 3);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(272, 119);
            this.grpServer.TabIndex = 0;
            this.grpServer.TabStop = false;
            this.grpServer.Text = "Server / Local Options";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblDivName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtDivName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cboEventType, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtPitPort, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.swLoadFields, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(266, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
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
            this.cboEventType.Location = new System.Drawing.Point(136, 28);
            this.cboEventType.Name = "cboEventType";
            this.cboEventType.Size = new System.Drawing.Size(127, 21);
            this.cboEventType.TabIndex = 20;
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.tableLayoutPanel5);
            this.grpClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpClient.Location = new System.Drawing.Point(280, 128);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(272, 119);
            this.grpClient.TabIndex = 1;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client / Local Options";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.numField, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(266, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.grpClient, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.grpServer, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCancel, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.btnContinue, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(555, 295);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Options";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.swMultiDivision, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.numDivID, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(265, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 119);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Mode";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rdoServer);
            this.flowLayoutPanel1.Controls.Add(this.rdoServerOnly);
            this.flowLayoutPanel1.Controls.Add(this.rdoClient);
            this.flowLayoutPanel1.Controls.Add(this.rdoLocal);
            this.flowLayoutPanel1.Controls.Add(this.rdoPit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // swMultiDivision
            // 
            // 
            // 
            // 
            this.swMultiDivision.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel7.SetColumnSpan(this.swMultiDivision, 2);
            this.swMultiDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swMultiDivision.Location = new System.Drawing.Point(3, 3);
            this.swMultiDivision.Name = "swMultiDivision";
            this.swMultiDivision.OffText = "Single Division Event";
            this.swMultiDivision.OnText = "Multi-Division Event";
            this.swMultiDivision.Size = new System.Drawing.Size(259, 19);
            this.swMultiDivision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swMultiDivision.TabIndex = 7;
            this.swMultiDivision.Value = true;
            this.swMultiDivision.ValueObject = "Y";
            // 
            // swLoadFields
            // 
            // 
            // 
            // 
            this.swLoadFields.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel4.SetColumnSpan(this.swLoadFields, 2);
            this.swLoadFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swLoadFields.Location = new System.Drawing.Point(3, 53);
            this.swLoadFields.Name = "swLoadFields";
            this.swLoadFields.OffText = "Clear Previous Fields";
            this.swLoadFields.OnText = "Load Previous Fields";
            this.swLoadFields.Size = new System.Drawing.Size(260, 19);
            this.swLoadFields.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swLoadFields.TabIndex = 21;
            this.swLoadFields.Value = true;
            this.swLoadFields.ValueObject = "Y";
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
            this.numField.Location = new System.Drawing.Point(136, 28);
            this.numField.MaxValue = 9;
            this.numField.MinValue = 1;
            this.numField.Name = "numField";
            this.numField.ShowUpDown = true;
            this.numField.Size = new System.Drawing.Size(127, 20);
            this.numField.TabIndex = 9;
            this.numField.Value = 1;
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
            this.numDivID.Location = new System.Drawing.Point(135, 28);
            this.numDivID.MaxValue = 9;
            this.numDivID.MinValue = 1;
            this.numDivID.Name = "numDivID";
            this.numDivID.ShowUpDown = true;
            this.numDivID.Size = new System.Drawing.Size(127, 20);
            this.numDivID.TabIndex = 8;
            this.numDivID.Value = 1;
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
            // frmModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 295);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModeSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Setup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmModeSelection_Load);
            this.grpServer.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.grpClient.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDivID)).EndInit();
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
        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEventType;
        private DevComponents.DotNetBar.Controls.SwitchButton swMultiDivision;
        private DevComponents.DotNetBar.Controls.SwitchButton swLoadFields;
        private DevComponents.Editors.IntegerInput numField;
        private DevComponents.Editors.IntegerInput numDivID;
        private System.Windows.Forms.RadioButton rdoServerOnly;
    }
}