namespace FTC_Timer_Display
{
    partial class CtrlTimeLengthEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlTimeLengthEntry));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.clrPicker = new DevComponents.DotNetBar.ColorPickerButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numMin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numSec, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clrPicker, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(3, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(143, 30);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Unset";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMin
            // 
            this.numMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMin.Location = new System.Drawing.Point(152, 3);
            this.numMin.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(59, 20);
            this.numMin.TabIndex = 1;
            this.numMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMin.ValueChanged += new System.EventHandler(this.NumsChangedHandler);
            this.numMin.Click += new System.EventHandler(this.numMin_Click);
            // 
            // numSec
            // 
            this.numSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSec.Location = new System.Drawing.Point(217, 3);
            this.numSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(59, 20);
            this.numSec.TabIndex = 2;
            this.numSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSec.ValueChanged += new System.EventHandler(this.NumsChangedHandler);
            // 
            // clrPicker
            // 
            this.clrPicker.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.clrPicker.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.clrPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clrPicker.Image = ((System.Drawing.Image)(resources.GetObject("clrPicker.Image")));
            this.clrPicker.Location = new System.Drawing.Point(282, 3);
            this.clrPicker.Name = "clrPicker";
            this.clrPicker.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.clrPicker.Size = new System.Drawing.Size(44, 24);
            this.clrPicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.clrPicker.TabIndex = 3;
            // 
            // CtrlTimeLengthEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CtrlTimeLengthEntry";
            this.Size = new System.Drawing.Size(329, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numSec;
        private DevComponents.DotNetBar.ColorPickerButton clrPicker;
    }
}
