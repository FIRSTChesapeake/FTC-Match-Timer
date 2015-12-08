namespace FTC_Timer_Display
{
    partial class frmDisplay
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplay));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.imgMinute = new System.Windows.Forms.PictureBox();
            this.imgColon = new System.Windows.Forms.PictureBox();
            this.imgSecond1 = new System.Windows.Forms.PictureBox();
            this.imgSecond2 = new System.Windows.Forms.PictureBox();
            this.lblMatchNumber = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblMatchStatus = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecond1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecond2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::FTC_Timer_Display.Properties.Resources.DisplayBackgroundHD;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FTC_Timer_Display.Properties.Resources.gamelogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::FTC_Timer_Display.Properties.Resources.FTClogo;
            this.pictureBox2.Location = new System.Drawing.Point(787, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Controls.Add(this.imgMinute, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.imgColon, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.imgSecond1, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.imgSecond2, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblMatchNumber, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelX2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblMatchStatus, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelX4, 5, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(264, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(517, 535);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // imgMinute
            // 
            this.imgMinute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgMinute.Image = ((System.Drawing.Image)(resources.GetObject("imgMinute.Image")));
            this.imgMinute.Location = new System.Drawing.Point(53, 123);
            this.imgMinute.Name = "imgMinute";
            this.imgMinute.Size = new System.Drawing.Size(109, 289);
            this.imgMinute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMinute.TabIndex = 0;
            this.imgMinute.TabStop = false;
            // 
            // imgColon
            // 
            this.imgColon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgColon.Image = global::FTC_Timer_Display.Properties.Resources.Wcolonoff;
            this.imgColon.Location = new System.Drawing.Point(168, 123);
            this.imgColon.Name = "imgColon";
            this.imgColon.Size = new System.Drawing.Size(59, 289);
            this.imgColon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgColon.TabIndex = 1;
            this.imgColon.TabStop = false;
            // 
            // imgSecond1
            // 
            this.imgSecond1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSecond1.Image = ((System.Drawing.Image)(resources.GetObject("imgSecond1.Image")));
            this.imgSecond1.Location = new System.Drawing.Point(233, 123);
            this.imgSecond1.Name = "imgSecond1";
            this.imgSecond1.Size = new System.Drawing.Size(109, 289);
            this.imgSecond1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSecond1.TabIndex = 2;
            this.imgSecond1.TabStop = false;
            // 
            // imgSecond2
            // 
            this.imgSecond2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSecond2.Image = ((System.Drawing.Image)(resources.GetObject("imgSecond2.Image")));
            this.imgSecond2.Location = new System.Drawing.Point(348, 123);
            this.imgSecond2.Name = "imgSecond2";
            this.imgSecond2.Size = new System.Drawing.Size(109, 289);
            this.imgSecond2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSecond2.TabIndex = 3;
            this.imgSecond2.TabStop = false;
            // 
            // lblMatchNumber
            // 
            // 
            // 
            // 
            this.lblMatchNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel2.SetColumnSpan(this.lblMatchNumber, 6);
            this.lblMatchNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchNumber.Location = new System.Drawing.Point(3, 53);
            this.lblMatchNumber.Name = "lblMatchNumber";
            this.lblMatchNumber.Size = new System.Drawing.Size(511, 64);
            this.lblMatchNumber.TabIndex = 4;
            this.lblMatchNumber.Text = "Division 0 Field 0\r\nQualification Match 0";
            this.lblMatchNumber.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Blue;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(3, 418);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 64);
            this.labelX2.TabIndex = 5;
            // 
            // lblMatchStatus
            // 
            // 
            // 
            // 
            this.lblMatchStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel2.SetColumnSpan(this.lblMatchStatus, 4);
            this.lblMatchStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchStatus.Location = new System.Drawing.Point(53, 418);
            this.lblMatchStatus.Name = "lblMatchStatus";
            this.lblMatchStatus.Size = new System.Drawing.Size(404, 64);
            this.lblMatchStatus.TabIndex = 6;
            this.lblMatchStatus.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX4.Location = new System.Drawing.Point(463, 418);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(51, 64);
            this.labelX4.TabIndex = 7;
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDisplay_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDisplay_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDisplay_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecond1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecond2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox imgMinute;
        private System.Windows.Forms.PictureBox imgColon;
        private System.Windows.Forms.PictureBox imgSecond1;
        private System.Windows.Forms.PictureBox imgSecond2;
        private DevComponents.DotNetBar.LabelX lblMatchNumber;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblMatchStatus;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}

