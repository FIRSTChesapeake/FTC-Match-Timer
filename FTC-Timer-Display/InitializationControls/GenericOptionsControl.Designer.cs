namespace FTC_Timer_Display.InitializationControls
{
    partial class GenericOptionsControl
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
            this.headCtrl = new FTC_Timer_Display.CtrlHeader();
            this.lblExplain = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.headCtrl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblExplain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.ClickHandler);
            // 
            // headCtrl
            // 
            // 
            // 
            // 
            this.headCtrl.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headCtrl.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.headCtrl.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.headCtrl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.headCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.headCtrl.Location = new System.Drawing.Point(3, 3);
            this.headCtrl.Name = "headCtrl";
            this.headCtrl.Size = new System.Drawing.Size(291, 24);
            this.headCtrl.TabIndex = 0;
            this.headCtrl.Text = "Header";
            this.headCtrl.TextAlignment = System.Drawing.StringAlignment.Center;
            this.headCtrl.Click += new System.EventHandler(this.ClickHandler);
            // 
            // lblExplain
            // 
            // 
            // 
            // 
            this.lblExplain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblExplain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExplain.Location = new System.Drawing.Point(3, 33);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(291, 226);
            this.lblExplain.TabIndex = 1;
            this.lblExplain.Text = "Explain";
            this.lblExplain.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.lblExplain.Click += new System.EventHandler(this.ClickHandler);
            // 
            // GenericOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GenericOptionsControl";
            this.Size = new System.Drawing.Size(297, 262);
            this.Click += new System.EventHandler(this.ClickHandler);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CtrlHeader headCtrl;
        private DevComponents.DotNetBar.LabelX lblExplain;
    }
}
