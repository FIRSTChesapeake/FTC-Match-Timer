namespace FTC_Timer_Display.InitializationControls
{
    partial class CtrlGlobal
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.ctrlHeader2 = new FTC_Timer_Display.CtrlHeader();
            this.numDivNumber = new DevComponents.Editors.IntegerInput();
            this.optSingle = new FTC_Timer_Display.InitializationControls.GenericOptionsControl();
            this.optMulti = new FTC_Timer_Display.InitializationControls.GenericOptionsControl();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDivNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelX2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelX3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.ctrlHeader2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.numDivNumber, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.optSingle, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.optMulti, 2, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(730, 591);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel4.SetColumnSpan(this.labelX2, 3);
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.FontBold = true;
            this.labelX2.Location = new System.Drawing.Point(3, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(724, 24);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Is this a Single or Multi-Division Event?";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.FontBold = true;
            this.labelX3.Location = new System.Drawing.Point(3, 133);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(309, 24);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "What is the Division Number?";
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
            this.tableLayoutPanel4.SetColumnSpan(this.ctrlHeader2, 3);
            this.ctrlHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader2.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader2.Name = "ctrlHeader2";
            this.ctrlHeader2.Size = new System.Drawing.Size(724, 24);
            this.ctrlHeader2.TabIndex = 2;
            this.ctrlHeader2.Text = "Global Options";
            this.ctrlHeader2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // numDivNumber
            // 
            // 
            // 
            // 
            this.numDivNumber.BackgroundStyle.Class = "DateTimeInputBackground";
            this.numDivNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numDivNumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.numDivNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDivNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDivNumber.Location = new System.Drawing.Point(318, 133);
            this.numDivNumber.MaxValue = 9;
            this.numDivNumber.MinValue = 1;
            this.numDivNumber.Name = "numDivNumber";
            this.numDivNumber.ShowUpDown = true;
            this.numDivNumber.Size = new System.Drawing.Size(94, 23);
            this.numDivNumber.TabIndex = 4;
            this.numDivNumber.Value = 1;
            // 
            // optSingle
            // 
            this.optSingle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optSingle.explain = "This event only has <u>one</u> division.";
            this.optSingle.header = "Single Division Event";
            this.optSingle.isSelected = false;
            this.optSingle.Location = new System.Drawing.Point(3, 63);
            this.optSingle.Name = "optSingle";
            this.optSingle.selectedValue = null;
            this.optSingle.Size = new System.Drawing.Size(309, 64);
            this.optSingle.TabIndex = 5;
            this.optSingle.Selected += new System.EventHandler(this.SelectHandler);
            // 
            // optMulti
            // 
            this.optMulti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optMulti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optMulti.explain = "This event has <u>two or more</u> divisions.";
            this.optMulti.header = "Multi-Division Event";
            this.optMulti.isSelected = false;
            this.optMulti.Location = new System.Drawing.Point(418, 63);
            this.optMulti.Name = "optMulti";
            this.optMulti.selectedValue = null;
            this.optMulti.Size = new System.Drawing.Size(309, 64);
            this.optMulti.TabIndex = 6;
            this.optMulti.Selected += new System.EventHandler(this.SelectHandler);
            // 
            // CtrlGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "CtrlGlobal";
            this.Size = new System.Drawing.Size(730, 591);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDivNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private CtrlHeader ctrlHeader2;
        private DevComponents.Editors.IntegerInput numDivNumber;
        private GenericOptionsControl optSingle;
        private GenericOptionsControl optMulti;
    }
}
