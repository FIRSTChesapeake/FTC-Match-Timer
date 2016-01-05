namespace FTC_Timer_Display.PacDevices
{
    partial class PacDeviceSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacDeviceSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboPacDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReInit = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnShutdown = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.linkBuy = new System.Windows.Forms.LinkLabel();
            this.lblButtonStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.swRefresh = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cboPacDevices, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnShutdown, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ctrlHeader1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkBuy, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblButtonStatus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReInit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.swRefresh, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 486);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cboPacDevices
            // 
            this.cboPacDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPacDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacDevices.Enabled = false;
            this.cboPacDevices.FormattingEnabled = true;
            this.cboPacDevices.Location = new System.Drawing.Point(145, 33);
            this.cboPacDevices.Name = "cboPacDevices";
            this.cboPacDevices.Size = new System.Drawing.Size(287, 21);
            this.cboPacDevices.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select USB Button Device:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReInit
            // 
            this.btnReInit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReInit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReInit.Location = new System.Drawing.Point(438, 33);
            this.btnReInit.Name = "btnReInit";
            this.btnReInit.Size = new System.Drawing.Size(144, 24);
            this.btnReInit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReInit.TabIndex = 2;
            this.btnReInit.Text = "Initialize Buttons";
            this.btnReInit.Click += new System.EventHandler(this.btnReInit_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel1.SetColumnSpan(this.labelX1, 3);
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(3, 123);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(579, 315);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = resources.GetString("labelX1.Text");
            this.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnShutdown
            // 
            this.btnShutdown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShutdown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShutdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShutdown.Location = new System.Drawing.Point(438, 93);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(144, 24);
            this.btnShutdown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShutdown.TabIndex = 4;
            this.btnShutdown.Text = "Disconnect Button";
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Button Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkBuy
            // 
            this.linkBuy.AutoSize = true;
            this.linkBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkBuy.Location = new System.Drawing.Point(145, 90);
            this.linkBuy.Name = "linkBuy";
            this.linkBuy.Size = new System.Drawing.Size(287, 30);
            this.linkBuy.TabIndex = 7;
            this.linkBuy.TabStop = true;
            this.linkBuy.Text = "Purchase: http://www.usbbutton.com";
            this.linkBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkBuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBuy_LinkClicked);
            // 
            // lblButtonStatus
            // 
            this.lblButtonStatus.AutoSize = true;
            this.lblButtonStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblButtonStatus.Location = new System.Drawing.Point(145, 60);
            this.lblButtonStatus.Name = "lblButtonStatus";
            this.lblButtonStatus.Size = new System.Drawing.Size(287, 30);
            this.lblButtonStatus.TabIndex = 8;
            this.lblButtonStatus.Text = "Unknown";
            this.lblButtonStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // swRefresh
            // 
            // 
            // 
            // 
            this.swRefresh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swRefresh.Location = new System.Drawing.Point(438, 63);
            this.swRefresh.Name = "swRefresh";
            this.swRefresh.OffText = "Don\'t Refresh";
            this.swRefresh.OnText = "Auto Refresh";
            this.swRefresh.Size = new System.Drawing.Size(144, 24);
            this.swRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swRefresh.TabIndex = 9;
            this.swRefresh.Value = true;
            this.swRefresh.ValueObject = "Y";
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
            this.ctrlHeader1.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(579, 24);
            this.ctrlHeader1.TabIndex = 6;
            this.ctrlHeader1.Text = "USB-Button Options";
            this.ctrlHeader1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // PacDeviceSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PacDeviceSettings";
            this.Size = new System.Drawing.Size(585, 486);
            this.Load += new System.EventHandler(this.PacDeviceSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboPacDevices;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnReInit;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnShutdown;
        private System.Windows.Forms.Label label2;
        private CtrlHeader ctrlHeader1;
        private System.Windows.Forms.LinkLabel linkBuy;
        private System.Windows.Forms.Label lblButtonStatus;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.SwitchButton swRefresh;
    }
}
