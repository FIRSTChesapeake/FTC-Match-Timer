namespace FTC_Timer_Display
{
    partial class SingleClientDisplay
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
            this.picInd = new System.Windows.Forms.PictureBox();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInd)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.picInd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFieldName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblState, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(409, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picInd
            // 
            this.picInd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picInd.Image = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.picInd.Location = new System.Drawing.Point(3, 3);
            this.picInd.Name = "picInd";
            this.picInd.Size = new System.Drawing.Size(34, 36);
            this.picInd.TabIndex = 0;
            this.picInd.TabStop = false;
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldName.Location = new System.Drawing.Point(43, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(263, 42);
            this.lblFieldName.TabIndex = 1;
            this.lblFieldName.Text = "FIELD 1";
            this.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(312, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(94, 42);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Stopped";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SingleClientDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SingleClientDisplay";
            this.Size = new System.Drawing.Size(409, 42);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picInd;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblState;
    }
}
