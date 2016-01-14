namespace FTC_Timer_Display.SettingsControls
{
    partial class CtrlLoggingSettings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnDefaults = new DevComponents.DotNetBar.ButtonX();
            this.flowChecks = new System.Windows.Forms.FlowLayoutPanel();
            this.flowFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.ctrlHeader1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDefaults, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowChecks, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowFiles, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 410);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tableLayoutPanel1.SetColumnSpan(this.ctrlHeader1, 4);
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader1.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(517, 24);
            this.ctrlHeader1.TabIndex = 1;
            this.ctrlHeader1.Text = "What to Log";
            this.ctrlHeader1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select what you want in the log below. Note that Errors are always logged.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(76, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Logging Settings";
            this.btnSave.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(226, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 34);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel Changes";
            this.btnCancel.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnDefaults
            // 
            this.btnDefaults.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDefaults.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDefaults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDefaults.Location = new System.Drawing.Point(376, 373);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(144, 34);
            this.btnDefaults.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDefaults.TabIndex = 6;
            this.btnDefaults.Text = "Restore Defaults";
            this.btnDefaults.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // flowChecks
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowChecks, 4);
            this.flowChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowChecks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowChecks.Location = new System.Drawing.Point(3, 53);
            this.flowChecks.Name = "flowChecks";
            this.flowChecks.Size = new System.Drawing.Size(517, 144);
            this.flowChecks.TabIndex = 7;
            // 
            // flowFiles
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowFiles, 4);
            this.flowFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFiles.Location = new System.Drawing.Point(3, 223);
            this.flowFiles.Name = "flowFiles";
            this.flowFiles.Size = new System.Drawing.Size(517, 144);
            this.flowFiles.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 4);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Logging Locations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CtrlLoggingSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CtrlLoggingSettings";
            this.Size = new System.Drawing.Size(523, 410);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CtrlHeader ctrlHeader1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnDefaults;
        private System.Windows.Forms.FlowLayoutPanel flowChecks;
        private System.Windows.Forms.FlowLayoutPanel flowFiles;
        private System.Windows.Forms.Label label2;
    }
}
