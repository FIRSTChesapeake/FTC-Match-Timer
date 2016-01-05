namespace FTC_Timer_Display.InitializationControls
{
    partial class InitialSettingsLine
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.linkChange = new System.Windows.Forms.LinkLabel();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 3;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableMain.Controls.Add(this.lblTitle, 0, 0);
            this.tableMain.Controls.Add(this.lblDescription, 0, 1);
            this.tableMain.Controls.Add(this.lblData, 1, 0);
            this.tableMain.Controls.Add(this.linkChange, 2, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(557, 44);
            this.tableMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblTitle.Size = new System.Drawing.Size(321, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Item Label";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(3, 18);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(321, 26);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "This is a useful description";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblData.Location = new System.Drawing.Point(330, 0);
            this.lblData.Name = "lblData";
            this.tableMain.SetRowSpan(this.lblData, 2);
            this.lblData.Size = new System.Drawing.Size(174, 44);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "This is the Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkChange
            // 
            this.linkChange.AutoSize = true;
            this.linkChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkChange.Location = new System.Drawing.Point(510, 0);
            this.linkChange.Name = "linkChange";
            this.tableMain.SetRowSpan(this.linkChange, 2);
            this.linkChange.Size = new System.Drawing.Size(44, 44);
            this.linkChange.TabIndex = 3;
            this.linkChange.TabStop = true;
            this.linkChange.Text = "Change";
            this.linkChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChange_LinkClicked);
            // 
            // InitialSettingsLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableMain);
            this.Name = "InitialSettingsLine";
            this.Size = new System.Drawing.Size(557, 44);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.LinkLabel linkChange;
    }
}
