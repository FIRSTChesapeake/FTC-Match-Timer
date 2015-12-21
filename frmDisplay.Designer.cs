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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.logoTableLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.logoTableRight = new System.Windows.Forms.TableLayoutPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.clockFace = new FTC_Timer_Display.ClockFace();
            this.matchPeriodCtrl = new FTC_Timer_Display.MatchPeriodCtrl();
            this.lblFieldDataStatus = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel3.SuspendLayout();
            this.logoTableLeft.SuspendLayout();
            this.logoTableRight.SuspendLayout();
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
            this.tableLayoutPanel3.Controls.Add(this.matchPeriodCtrl, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.logoTableLeft, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.logoTableRight, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblFieldDataStatus, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1047, 552);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::FTC_Timer_Display.Properties.Resources.ftc_logo_new;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(900, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 144);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::FTC_Timer_Display.Properties.Resources.gamelogo;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 144);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // logoTableLeft
            // 
            this.logoTableLeft.BackgroundImage = global::FTC_Timer_Display.Properties.Resources.vaflogo;
            this.logoTableLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoTableLeft.ColumnCount = 1;
            this.logoTableLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logoTableLeft.Controls.Add(this.lblDate, 0, 1);
            this.logoTableLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoTableLeft.Location = new System.Drawing.Point(3, 405);
            this.logoTableLeft.Name = "logoTableLeft";
            this.logoTableLeft.RowCount = 2;
            this.tableLayoutPanel3.SetRowSpan(this.logoTableLeft, 2);
            this.logoTableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logoTableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.logoTableLeft.Size = new System.Drawing.Size(144, 144);
            this.logoTableLeft.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 109);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(138, 35);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "12/31/2015";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoTableRight
            // 
            this.logoTableRight.BackgroundImage = global::FTC_Timer_Display.Properties.Resources.vaflogo;
            this.logoTableRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoTableRight.ColumnCount = 1;
            this.logoTableRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logoTableRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.logoTableRight.Controls.Add(this.lblTime, 0, 1);
            this.logoTableRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoTableRight.Location = new System.Drawing.Point(900, 405);
            this.logoTableRight.Name = "logoTableRight";
            this.logoTableRight.RowCount = 2;
            this.tableLayoutPanel3.SetRowSpan(this.logoTableRight, 2);
            this.logoTableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logoTableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.logoTableRight.Size = new System.Drawing.Size(144, 144);
            this.logoTableRight.TabIndex = 15;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(3, 109);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(138, 35);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00 PM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.clockFace.Size = new System.Drawing.Size(1041, 246);
            this.clockFace.TabIndex = 8;
            this.clockFace.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // matchPeriodCtrl
            // 
            this.matchPeriodCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchPeriodCtrl.Location = new System.Drawing.Point(153, 405);
            this.matchPeriodCtrl.Name = "matchPeriodCtrl";
            this.matchPeriodCtrl.Size = new System.Drawing.Size(741, 114);
            this.matchPeriodCtrl.TabIndex = 9;
            // 
            // lblFieldDataStatus
            // 
            this.lblFieldDataStatus.BackColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.lblFieldDataStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFieldDataStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldDataStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldDataStatus.Location = new System.Drawing.Point(153, 525);
            this.lblFieldDataStatus.Name = "lblFieldDataStatus";
            this.lblFieldDataStatus.Size = new System.Drawing.Size(741, 24);
            this.lblFieldDataStatus.TabIndex = 16;
            this.lblFieldDataStatus.Text = "FIELD AWAITING INITIALIZATION";
            this.lblFieldDataStatus.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 552);
            this.Controls.Add(this.tableLayoutPanel3);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDisplay_FormClosing);
            this.Load += new System.EventHandler(this.frmDisplay_Load);
            this.VisibleChanged += new System.EventHandler(this.frmDisplay_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDisplay_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDisplay_KeyPress);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.logoTableLeft.ResumeLayout(false);
            this.logoTableLeft.PerformLayout();
            this.logoTableRight.ResumeLayout(false);
            this.logoTableRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblMatchNumber;
        private ClockFace clockFace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MatchPeriodCtrl matchPeriodCtrl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel logoTableLeft;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel logoTableRight;
        private System.Windows.Forms.Label lblTime;
        private DevComponents.DotNetBar.LabelX lblFieldDataStatus;
    }
}

