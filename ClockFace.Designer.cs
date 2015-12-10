namespace FTC_Timer_Display
{
    partial class ClockFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockFace));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblColon = new DevComponents.DotNetBar.LabelX();
            this.digitMin = new System.Windows.Forms.PictureBox();
            this.digitSec1 = new System.Windows.Forms.PictureBox();
            this.digitSec2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitSec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitSec2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.lblColon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.digitMin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.digitSec1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.digitSec2, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 373);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblColon
            // 
            // 
            // 
            // 
            this.lblColon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblColon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColon.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColon.ForeColor = System.Drawing.Color.Red;
            this.lblColon.Location = new System.Drawing.Point(265, 3);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(94, 367);
            this.lblColon.TabIndex = 1;
            this.lblColon.Text = ":";
            this.lblColon.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // digitMin
            // 
            this.digitMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitMin.Image = ((System.Drawing.Image)(resources.GetObject("digitMin.Image")));
            this.digitMin.Location = new System.Drawing.Point(23, 3);
            this.digitMin.Name = "digitMin";
            this.digitMin.Size = new System.Drawing.Size(236, 367);
            this.digitMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digitMin.TabIndex = 2;
            this.digitMin.TabStop = false;
            // 
            // digitSec1
            // 
            this.digitSec1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitSec1.Image = ((System.Drawing.Image)(resources.GetObject("digitSec1.Image")));
            this.digitSec1.Location = new System.Drawing.Point(365, 3);
            this.digitSec1.Name = "digitSec1";
            this.digitSec1.Size = new System.Drawing.Size(237, 367);
            this.digitSec1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digitSec1.TabIndex = 3;
            this.digitSec1.TabStop = false;
            // 
            // digitSec2
            // 
            this.digitSec2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitSec2.Image = ((System.Drawing.Image)(resources.GetObject("digitSec2.Image")));
            this.digitSec2.Location = new System.Drawing.Point(608, 3);
            this.digitSec2.Name = "digitSec2";
            this.digitSec2.Size = new System.Drawing.Size(237, 367);
            this.digitSec2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digitSec2.TabIndex = 4;
            this.digitSec2.TabStop = false;
            // 
            // ClockFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClockFace";
            this.Size = new System.Drawing.Size(879, 373);
            this.Resize += new System.EventHandler(this.ClockFace_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitSec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitSec2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX lblColon;
        private System.Windows.Forms.PictureBox digitMin;
        private System.Windows.Forms.PictureBox digitSec1;
        private System.Windows.Forms.PictureBox digitSec2;
    }
}
