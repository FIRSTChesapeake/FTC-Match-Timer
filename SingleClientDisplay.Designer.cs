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
            this.lblMatch = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInd)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.picInd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFieldName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblState, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMatch, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.ClickHandler);
            // 
            // picInd
            // 
            this.picInd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picInd.Image = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.picInd.Location = new System.Drawing.Point(3, 3);
            this.picInd.Name = "picInd";
            this.picInd.Size = new System.Drawing.Size(34, 34);
            this.picInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInd.TabIndex = 0;
            this.picInd.TabStop = false;
            this.picInd.Click += new System.EventHandler(this.ClickHandler);
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldName.Location = new System.Drawing.Point(43, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(84, 40);
            this.lblFieldName.TabIndex = 1;
            this.lblFieldName.Text = "FIELD 0";
            this.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFieldName.Click += new System.EventHandler(this.ClickHandler);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(173, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(79, 40);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Stopped";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblState.Click += new System.EventHandler(this.ClickHandler);
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(133, 0);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(34, 40);
            this.lblMatch.TabIndex = 3;
            this.lblMatch.Text = "1-5";
            this.lblMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMatch.Click += new System.EventHandler(this.ClickHandler);
            // 
            // SingleClientDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SingleClientDisplay";
            this.Size = new System.Drawing.Size(255, 40);
            this.Click += new System.EventHandler(this.ClickHandler);
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
        private System.Windows.Forms.Label lblMatch;
    }
}
