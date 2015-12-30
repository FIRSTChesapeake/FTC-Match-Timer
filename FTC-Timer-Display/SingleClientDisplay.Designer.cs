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
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.picInd = new System.Windows.Forms.PictureBox();
            this.tableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInd)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 3;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Controls.Add(this.lblFieldName, 1, 0);
            this.tableMain.Controls.Add(this.lblState, 2, 0);
            this.tableMain.Controls.Add(this.lblMatch, 2, 1);
            this.tableMain.Controls.Add(this.picInd, 0, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Size = new System.Drawing.Size(255, 40);
            this.tableMain.TabIndex = 0;
            this.tableMain.Click += new System.EventHandler(this.ClickHandler);
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldName.Location = new System.Drawing.Point(43, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.tableMain.SetRowSpan(this.lblFieldName, 2);
            this.lblFieldName.Size = new System.Drawing.Size(94, 40);
            this.lblFieldName.TabIndex = 1;
            this.lblFieldName.Text = "FIELD 0*";
            this.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFieldName.Click += new System.EventHandler(this.ClickHandler);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(143, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(109, 20);
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
            this.lblMatch.Location = new System.Drawing.Point(143, 20);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(109, 20);
            this.lblMatch.TabIndex = 3;
            this.lblMatch.Text = "Q 55-55";
            this.lblMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMatch.Click += new System.EventHandler(this.ClickHandler);
            // 
            // picInd
            // 
            this.picInd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picInd.Image = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.picInd.Location = new System.Drawing.Point(3, 3);
            this.picInd.Name = "picInd";
            this.tableMain.SetRowSpan(this.picInd, 2);
            this.picInd.Size = new System.Drawing.Size(34, 34);
            this.picInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInd.TabIndex = 4;
            this.picInd.TabStop = false;
            // 
            // SingleClientDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableMain);
            this.Name = "SingleClientDisplay";
            this.Size = new System.Drawing.Size(255, 40);
            this.Click += new System.EventHandler(this.ClickHandler);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.PictureBox picInd;
    }
}
