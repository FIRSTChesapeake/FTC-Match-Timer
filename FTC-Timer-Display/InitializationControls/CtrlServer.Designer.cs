namespace FTC_Timer_Display.InitializationControls
{
    partial class CtrlServer
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
            this.lblDivNameLabel = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.numScorePort = new DevComponents.Editors.IntegerInput();
            this.cboEventType = new System.Windows.Forms.ComboBox();
            this.txtDivName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScorePort)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ctrlHeader1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDivNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelX3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numScorePort, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboEventType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDivName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDivNameLabel
            // 
            // 
            // 
            // 
            this.lblDivNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDivNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDivNameLabel.FontBold = true;
            this.lblDivNameLabel.Location = new System.Drawing.Point(3, 33);
            this.lblDivNameLabel.Name = "lblDivNameLabel";
            this.lblDivNameLabel.Size = new System.Drawing.Size(157, 24);
            this.lblDivNameLabel.TabIndex = 1;
            this.lblDivNameLabel.Text = "Division Name:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.FontBold = true;
            this.labelX2.Location = new System.Drawing.Point(3, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(157, 24);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Event Type:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.FontBold = true;
            this.labelX3.Location = new System.Drawing.Point(3, 93);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(157, 24);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Scoring Port (future use):";
            // 
            // numScorePort
            // 
            // 
            // 
            // 
            this.numScorePort.BackgroundStyle.Class = "DateTimeInputBackground";
            this.numScorePort.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numScorePort.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.numScorePort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScorePort.Enabled = false;
            this.numScorePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numScorePort.Location = new System.Drawing.Point(166, 93);
            this.numScorePort.MaxValue = 65535;
            this.numScorePort.MinValue = 1;
            this.numScorePort.Name = "numScorePort";
            this.numScorePort.ShowUpDown = true;
            this.numScorePort.Size = new System.Drawing.Size(94, 23);
            this.numScorePort.TabIndex = 4;
            this.numScorePort.Value = 5656;
            // 
            // cboEventType
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboEventType, 2);
            this.cboEventType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventType.FormattingEnabled = true;
            this.cboEventType.Location = new System.Drawing.Point(166, 63);
            this.cboEventType.Name = "cboEventType";
            this.cboEventType.Size = new System.Drawing.Size(325, 21);
            this.cboEventType.TabIndex = 5;
            // 
            // txtDivName
            // 
            // 
            // 
            // 
            this.txtDivName.Border.Class = "TextBoxBorder";
            this.txtDivName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDivName, 2);
            this.txtDivName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDivName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivName.Location = new System.Drawing.Point(166, 33);
            this.txtDivName.Name = "txtDivName";
            this.txtDivName.PreventEnterBeep = true;
            this.txtDivName.Size = new System.Drawing.Size(325, 23);
            this.txtDivName.TabIndex = 6;
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
            this.ctrlHeader1.Size = new System.Drawing.Size(488, 24);
            this.ctrlHeader1.TabIndex = 0;
            this.ctrlHeader1.Text = "Controller (server) Options";
            this.ctrlHeader1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // CtrlServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CtrlServer";
            this.Size = new System.Drawing.Size(494, 372);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numScorePort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CtrlHeader ctrlHeader1;
        private DevComponents.DotNetBar.LabelX lblDivNameLabel;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.IntegerInput numScorePort;
        private System.Windows.Forms.ComboBox cboEventType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDivName;
    }
}
