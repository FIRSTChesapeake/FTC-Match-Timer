namespace FTC_Timer_Display.InitializationControls
{
    partial class CtrlAppModeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlAppModeSelection));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.ctrlHeader2 = new FTC_Timer_Display.CtrlHeader();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.appModeServerClient = new FTC_Timer_Display.InitializationControls.AppModeOption();
            this.appModeServerOnly = new FTC_Timer_Display.InitializationControls.AppModeOption();
            this.appModeClient = new FTC_Timer_Display.InitializationControls.AppModeOption();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ctrlHeader1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ctrlHeader2, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.appModeServerClient, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.appModeServerOnly, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.appModeClient, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(653, 456);
            this.tableLayoutPanel4.TabIndex = 1;
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
            this.tableLayoutPanel4.SetColumnSpan(this.ctrlHeader1, 3);
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader1.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(647, 24);
            this.ctrlHeader1.TabIndex = 7;
            this.ctrlHeader1.Text = "Select Application Mode";
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
            this.ctrlHeader2.Location = new System.Drawing.Point(332, 231);
            this.ctrlHeader2.Name = "ctrlHeader2";
            this.ctrlHeader2.Size = new System.Drawing.Size(318, 24);
            this.ctrlHeader2.TabIndex = 8;
            this.ctrlHeader2.Text = "Notes";
            this.ctrlHeader2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelX2);
            this.flowLayoutPanel1.Controls.Add(this.labelX3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(332, 261);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 192);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(315, 52);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Field numbers displayed in diagrams are for<br/>\r\n<u>demonstration only</u>.<br/>" +
    "\r\nYou may use any field numbers between 1 and 9 you desire.<br/>\r\nYou can also a" +
    "ssign any of them as the controller.";
            this.labelX2.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX2.WordWrap = true;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 61);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(304, 40);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "If you only need one field, select option 1.<br/>\r\n(Server && Client)";
            this.labelX3.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX3.WordWrap = true;
            // 
            // appModeServerClient
            // 
            this.appModeServerClient.BackColor = System.Drawing.Color.Yellow;
            this.appModeServerClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appModeServerClient.descrption = "Controls remote timers && displays a local timer.";
            this.appModeServerClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appModeServerClient.Location = new System.Drawing.Point(3, 33);
            this.appModeServerClient.Name = "appModeServerClient";
            this.appModeServerClient.picture = ((System.Drawing.Image)(resources.GetObject("appModeServerClient.picture")));
            this.appModeServerClient.runTypeValue = FTC_Timer_Display.InitialData.RunType.ServerClient;
            this.appModeServerClient.Size = new System.Drawing.Size(318, 192);
            this.appModeServerClient.TabIndex = 10;
            this.appModeServerClient.value = true;
            this.appModeServerClient.Selected += new System.EventHandler<FTC_Timer_Display.InitialData.RunType>(this.ModeClickHandler);
            // 
            // appModeServerOnly
            // 
            this.appModeServerOnly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appModeServerOnly.descrption = "Controls remote timers only. No local timer.";
            this.appModeServerOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appModeServerOnly.Location = new System.Drawing.Point(332, 33);
            this.appModeServerOnly.Name = "appModeServerOnly";
            this.appModeServerOnly.picture = ((System.Drawing.Image)(resources.GetObject("appModeServerOnly.picture")));
            this.appModeServerOnly.runTypeValue = FTC_Timer_Display.InitialData.RunType.Server;
            this.appModeServerOnly.Size = new System.Drawing.Size(318, 192);
            this.appModeServerOnly.TabIndex = 11;
            this.appModeServerOnly.value = false;
            this.appModeServerOnly.Selected += new System.EventHandler<FTC_Timer_Display.InitialData.RunType>(this.ModeClickHandler);
            // 
            // appModeClient
            // 
            this.appModeClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appModeClient.descrption = "Remote timer that is controlled by another server.";
            this.appModeClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appModeClient.Location = new System.Drawing.Point(3, 231);
            this.appModeClient.Name = "appModeClient";
            this.appModeClient.picture = ((System.Drawing.Image)(resources.GetObject("appModeClient.picture")));
            this.tableLayoutPanel4.SetRowSpan(this.appModeClient, 2);
            this.appModeClient.runTypeValue = FTC_Timer_Display.InitialData.RunType.Client;
            this.appModeClient.Size = new System.Drawing.Size(318, 222);
            this.appModeClient.TabIndex = 12;
            this.appModeClient.value = false;
            this.appModeClient.Selected += new System.EventHandler<FTC_Timer_Display.InitialData.RunType>(this.ModeClickHandler);
            // 
            // CtrlAppModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "CtrlAppModeSelection";
            this.Size = new System.Drawing.Size(653, 456);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private CtrlHeader ctrlHeader1;
        private CtrlHeader ctrlHeader2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private AppModeOption appModeServerClient;
        private AppModeOption appModeServerOnly;
        private AppModeOption appModeClient;
    }
}
