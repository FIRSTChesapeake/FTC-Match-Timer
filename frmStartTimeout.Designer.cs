namespace FTC_Timer_Display
{
    partial class frmStartTimeout
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoAllianceCalled = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.cboAlliance = new System.Windows.Forms.ComboBox();
            this.txtCustomMsg = new System.Windows.Forms.TextBox();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoSoundNone = new System.Windows.Forms.RadioButton();
            this.rdoSoundBuzzer = new System.Windows.Forms.RadioButton();
            this.rdoSoundVoice = new System.Windows.Forms.RadioButton();
            this.lblAlreadyRunning = new System.Windows.Forms.Label();
            this.timeValue = new FTC_Timer_Display.ctrlTimeLengthEntry();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rdoAllianceCalled, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdoOther, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboAlliance, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomMsg, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.timeValue, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblAlreadyRunning, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // rdoAllianceCalled
            // 
            this.rdoAllianceCalled.AutoSize = true;
            this.rdoAllianceCalled.Checked = true;
            this.rdoAllianceCalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoAllianceCalled.Location = new System.Drawing.Point(3, 33);
            this.rdoAllianceCalled.Name = "rdoAllianceCalled";
            this.rdoAllianceCalled.Size = new System.Drawing.Size(153, 24);
            this.rdoAllianceCalled.TabIndex = 0;
            this.rdoAllianceCalled.TabStop = true;
            this.rdoAllianceCalled.Text = "Alliance Timeout";
            this.rdoAllianceCalled.UseVisualStyleBackColor = true;
            this.rdoAllianceCalled.CheckedChanged += new System.EventHandler(this.RadioButtonChangeHandler);
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoOther.Location = new System.Drawing.Point(3, 63);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(153, 24);
            this.rdoOther.TabIndex = 1;
            this.rdoOther.Text = "Custom Message";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.RadioButtonChangeHandler);
            // 
            // cboAlliance
            // 
            this.cboAlliance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboAlliance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlliance.FormattingEnabled = true;
            this.cboAlliance.Location = new System.Drawing.Point(162, 33);
            this.cboAlliance.Name = "cboAlliance";
            this.cboAlliance.Size = new System.Drawing.Size(153, 21);
            this.cboAlliance.TabIndex = 2;
            // 
            // txtCustomMsg
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCustomMsg, 2);
            this.txtCustomMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomMsg.Enabled = false;
            this.txtCustomMsg.Location = new System.Drawing.Point(3, 93);
            this.txtCustomMsg.Name = "txtCustomMsg";
            this.txtCustomMsg.Size = new System.Drawing.Size(312, 20);
            this.txtCustomMsg.TabIndex = 3;
            this.txtCustomMsg.Text = "Event Required Timeout";
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 263);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 44);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Timeout";
            this.btnStart.Click += new System.EventHandler(this.HandleButtons);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(162, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 44);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "End Timeout Sounds";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rdoSoundNone);
            this.flowLayoutPanel1.Controls.Add(this.rdoSoundBuzzer);
            this.flowLayoutPanel1.Controls.Add(this.rdoSoundVoice);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(147, 75);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rdoSoundNone
            // 
            this.rdoSoundNone.AutoSize = true;
            this.rdoSoundNone.Location = new System.Drawing.Point(3, 3);
            this.rdoSoundNone.Name = "rdoSoundNone";
            this.rdoSoundNone.Size = new System.Drawing.Size(51, 17);
            this.rdoSoundNone.TabIndex = 0;
            this.rdoSoundNone.Text = "None";
            this.rdoSoundNone.UseVisualStyleBackColor = true;
            // 
            // rdoSoundBuzzer
            // 
            this.rdoSoundBuzzer.AutoSize = true;
            this.rdoSoundBuzzer.Checked = true;
            this.rdoSoundBuzzer.Location = new System.Drawing.Point(3, 26);
            this.rdoSoundBuzzer.Name = "rdoSoundBuzzer";
            this.rdoSoundBuzzer.Size = new System.Drawing.Size(57, 17);
            this.rdoSoundBuzzer.TabIndex = 1;
            this.rdoSoundBuzzer.TabStop = true;
            this.rdoSoundBuzzer.Text = "Buzzer";
            this.rdoSoundBuzzer.UseVisualStyleBackColor = true;
            // 
            // rdoSoundVoice
            // 
            this.rdoSoundVoice.AutoSize = true;
            this.rdoSoundVoice.Location = new System.Drawing.Point(3, 49);
            this.rdoSoundVoice.Name = "rdoSoundVoice";
            this.rdoSoundVoice.Size = new System.Drawing.Size(52, 17);
            this.rdoSoundVoice.TabIndex = 2;
            this.rdoSoundVoice.Text = "Voice";
            this.rdoSoundVoice.UseVisualStyleBackColor = true;
            // 
            // lblAlreadyRunning
            // 
            this.lblAlreadyRunning.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblAlreadyRunning, 2);
            this.lblAlreadyRunning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlreadyRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyRunning.ForeColor = System.Drawing.Color.Red;
            this.lblAlreadyRunning.Location = new System.Drawing.Point(3, 0);
            this.lblAlreadyRunning.Name = "lblAlreadyRunning";
            this.lblAlreadyRunning.Size = new System.Drawing.Size(312, 30);
            this.lblAlreadyRunning.TabIndex = 8;
            this.lblAlreadyRunning.Text = "WARNING: Timeout Already in Progress\r\nTime below will be ADDED to the Existing Ti" +
    "meout";
            this.lblAlreadyRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlreadyRunning.Visible = false;
            // 
            // timeValue
            // 
            this.timeValue.Caption = "Length";
            this.tableLayoutPanel1.SetColumnSpan(this.timeValue, 2);
            this.timeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeValue.IndicatorColor = System.Drawing.Color.Empty;
            this.timeValue.Location = new System.Drawing.Point(3, 123);
            this.timeValue.MaximumValue = System.TimeSpan.Parse("00:48:05");
            this.timeValue.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timeValue.Name = "timeValue";
            this.timeValue.Readonly = false;
            this.timeValue.Size = new System.Drawing.Size(312, 24);
            this.timeValue.TabIndex = 6;
            this.timeValue.useColorPicker = false;
            this.timeValue.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // frmStartTimeout
            // 
            this.AcceptButton = this.btnStart;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(318, 310);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStartTimeout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Timeout";
            this.Load += new System.EventHandler(this.frmStartTimeout_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdoAllianceCalled;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.ComboBox cboAlliance;
        private System.Windows.Forms.TextBox txtCustomMsg;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private ctrlTimeLengthEntry timeValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rdoSoundNone;
        private System.Windows.Forms.RadioButton rdoSoundBuzzer;
        private System.Windows.Forms.RadioButton rdoSoundVoice;
        private System.Windows.Forms.Label lblAlreadyRunning;
    }
}