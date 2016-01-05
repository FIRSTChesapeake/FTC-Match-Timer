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
            this.picServerClient = new System.Windows.Forms.PictureBox();
            this.picClient = new System.Windows.Forms.PictureBox();
            this.chkClient = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkServerClient = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkServerOnly = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.picServerOnly = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.ctrlHeader2 = new FTC_Timer_Display.CtrlHeader();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picServerClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServerOnly)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.picServerClient, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.picClient, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.chkClient, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.chkServerClient, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.chkServerOnly, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.picServerOnly, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.ctrlHeader1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ctrlHeader2, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 2, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(653, 456);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // picServerClient
            // 
            this.picServerClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picServerClient.Image = ((System.Drawing.Image)(resources.GetObject("picServerClient.Image")));
            this.picServerClient.Location = new System.Drawing.Point(3, 63);
            this.picServerClient.Name = "picServerClient";
            this.picServerClient.Size = new System.Drawing.Size(318, 177);
            this.picServerClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picServerClient.TabIndex = 1;
            this.picServerClient.TabStop = false;
            this.picServerClient.Click += new System.EventHandler(this.PicClickHandler);
            // 
            // picClient
            // 
            this.picClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picClient.Image = ((System.Drawing.Image)(resources.GetObject("picClient.Image")));
            this.picClient.Location = new System.Drawing.Point(332, 63);
            this.picClient.Name = "picClient";
            this.picClient.Size = new System.Drawing.Size(318, 177);
            this.picClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClient.TabIndex = 2;
            this.picClient.TabStop = false;
            this.picClient.Click += new System.EventHandler(this.PicClickHandler);
            // 
            // chkClient
            // 
            // 
            // 
            // 
            this.chkClient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkClient.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClient.Location = new System.Drawing.Point(332, 33);
            this.chkClient.Name = "chkClient";
            this.chkClient.Size = new System.Drawing.Size(318, 24);
            this.chkClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkClient.TabIndex = 4;
            this.chkClient.Text = "Remote Timer controlled from elsewhere.";
            this.chkClient.Click += new System.EventHandler(this.CheckClickHandler);
            // 
            // chkServerClient
            // 
            // 
            // 
            // 
            this.chkServerClient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkServerClient.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkServerClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkServerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkServerClient.Location = new System.Drawing.Point(3, 33);
            this.chkServerClient.Name = "chkServerClient";
            this.chkServerClient.Size = new System.Drawing.Size(318, 24);
            this.chkServerClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkServerClient.TabIndex = 5;
            this.chkServerClient.Text = "Control Remote Timers && Display Local Timer.";
            this.chkServerClient.Click += new System.EventHandler(this.CheckClickHandler);
            // 
            // chkServerOnly
            // 
            // 
            // 
            // 
            this.chkServerOnly.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkServerOnly.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkServerOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkServerOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkServerOnly.Location = new System.Drawing.Point(3, 246);
            this.chkServerOnly.Name = "chkServerOnly";
            this.chkServerOnly.Size = new System.Drawing.Size(318, 24);
            this.chkServerOnly.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkServerOnly.TabIndex = 3;
            this.chkServerOnly.Text = "Control Remote timers only. No Local Timer.";
            this.chkServerOnly.Click += new System.EventHandler(this.CheckClickHandler);
            // 
            // picServerOnly
            // 
            this.picServerOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picServerOnly.Image = ((System.Drawing.Image)(resources.GetObject("picServerOnly.Image")));
            this.picServerOnly.Location = new System.Drawing.Point(3, 276);
            this.picServerOnly.Name = "picServerOnly";
            this.picServerOnly.Size = new System.Drawing.Size(318, 177);
            this.picServerOnly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picServerOnly.TabIndex = 0;
            this.picServerOnly.TabStop = false;
            this.picServerOnly.Click += new System.EventHandler(this.PicClickHandler);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelX2);
            this.flowLayoutPanel1.Controls.Add(this.labelX3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(332, 276);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 177);
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
            this.labelX3.Text = "If you only need one field, select the first option.<br/>\r\n(Remote && Local)";
            this.labelX3.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX3.WordWrap = true;
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
            this.ctrlHeader2.Location = new System.Drawing.Point(332, 246);
            this.ctrlHeader2.Name = "ctrlHeader2";
            this.ctrlHeader2.Size = new System.Drawing.Size(318, 24);
            this.ctrlHeader2.TabIndex = 8;
            this.ctrlHeader2.Text = "Notes";
            this.ctrlHeader2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // CtrlAppModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "CtrlAppModeSelection";
            this.Size = new System.Drawing.Size(653, 456);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picServerClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServerOnly)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox picServerOnly;
        private System.Windows.Forms.PictureBox picServerClient;
        private System.Windows.Forms.PictureBox picClient;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkServerOnly;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkClient;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkServerClient;
        private CtrlHeader ctrlHeader1;
        private CtrlHeader ctrlHeader2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}
