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
            this.lblMatchNumber = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.clockFace = new FTC_Timer_Display.ClockFace();
            this.matchPeriodCtrl = new FTC_Timer_Display.MatchPeriodCtrl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picState = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picState)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatchNumber
            // 
            // 
            // 
            // 
            this.lblMatchNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMatchNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchNumber.Location = new System.Drawing.Point(153, 3);
            this.lblMatchNumber.Name = "lblMatchNumber";
            this.lblMatchNumber.Size = new System.Drawing.Size(741, 144);
            this.lblMatchNumber.TabIndex = 4;
            this.lblMatchNumber.Text = "Division 0 Field 0\r\nQualification Match 0";
            this.lblMatchNumber.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Controls.Add(this.lblMatchNumber, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.clockFace, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.matchPeriodCtrl, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox4, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1047, 541);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // clockFace
            // 
            this.clockFace.BackColor = System.Drawing.Color.Black;
            this.clockFace.blink = false;
            this.clockFace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel3.SetColumnSpan(this.clockFace, 3);
            this.clockFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockFace.Location = new System.Drawing.Point(3, 153);
            this.clockFace.Name = "clockFace";
            this.clockFace.Size = new System.Drawing.Size(1041, 235);
            this.clockFace.TabIndex = 8;
            this.clockFace.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // matchPeriodCtrl
            // 
            this.matchPeriodCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchPeriodCtrl.Location = new System.Drawing.Point(153, 394);
            this.matchPeriodCtrl.Name = "matchPeriodCtrl";
            this.matchPeriodCtrl.Size = new System.Drawing.Size(741, 144);
            this.matchPeriodCtrl.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FTC_Timer_Display.Properties.Resources.gamelogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::FTC_Timer_Display.Properties.Resources.vaflogo;
            this.pictureBox3.Location = new System.Drawing.Point(3, 394);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::FTC_Timer_Display.Properties.Resources.vaflogo;
            this.pictureBox4.Location = new System.Drawing.Point(900, 394);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(144, 144);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::FTC_Timer_Display.Properties.Resources.ftc_logo_new;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.picState, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(900, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 144);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // picState
            // 
            this.picState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picState.Image = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.picState.Location = new System.Drawing.Point(112, 3);
            this.picState.Name = "picState";
            this.picState.Size = new System.Drawing.Size(29, 29);
            this.picState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picState.TabIndex = 0;
            this.picState.TabStop = false;
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 541);
            this.Controls.Add(this.tableLayoutPanel3);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDisplay_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDisplay_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDisplay_KeyPress);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX lblMatchNumber;
        private ClockFace clockFace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MatchPeriodCtrl matchPeriodCtrl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picState;
    }
}

