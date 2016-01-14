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
            this.digitMin = new System.Windows.Forms.PictureBox();
            this.digitSec1 = new System.Windows.Forms.PictureBox();
            this.digitSec2 = new System.Windows.Forms.PictureBox();
            this.imgColon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitSec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitSec2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.digitMin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.digitSec1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.digitSec2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgColon, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1410, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // digitMin
            // 
            this.digitMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitMin.Image = ((System.Drawing.Image)(resources.GetObject("digitMin.Image")));
            this.digitMin.Location = new System.Drawing.Point(23, 3);
            this.digitMin.Name = "digitMin";
            this.digitMin.Size = new System.Drawing.Size(402, 547);
            this.digitMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digitMin.TabIndex = 2;
            this.digitMin.TabStop = false;
            // 
            // digitSec1
            // 
            this.digitSec1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitSec1.Image = ((System.Drawing.Image)(resources.GetObject("digitSec1.Image")));
            this.digitSec1.Location = new System.Drawing.Point(567, 3);
            this.digitSec1.Name = "digitSec1";
            this.digitSec1.Size = new System.Drawing.Size(402, 547);
            this.digitSec1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digitSec1.TabIndex = 3;
            this.digitSec1.TabStop = false;
            // 
            // digitSec2
            // 
            this.digitSec2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitSec2.Image = ((System.Drawing.Image)(resources.GetObject("digitSec2.Image")));
            this.digitSec2.Location = new System.Drawing.Point(975, 3);
            this.digitSec2.Name = "digitSec2";
            this.digitSec2.Size = new System.Drawing.Size(402, 547);
            this.digitSec2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digitSec2.TabIndex = 4;
            this.digitSec2.TabStop = false;
            // 
            // imgColon
            // 
            this.imgColon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgColon.Image = global::FTC_Timer_Display.Properties.Resources.Rcolon;
            this.imgColon.Location = new System.Drawing.Point(431, 3);
            this.imgColon.Name = "imgColon";
            this.imgColon.Size = new System.Drawing.Size(130, 547);
            this.imgColon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgColon.TabIndex = 5;
            this.imgColon.TabStop = false;
            // 
            // ClockFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClockFace";
            this.Size = new System.Drawing.Size(1410, 553);
            this.Resize += new System.EventHandler(this.ClockFace_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitSec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitSec2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox digitMin;
        private System.Windows.Forms.PictureBox digitSec1;
        private System.Windows.Forms.PictureBox digitSec2;
        private System.Windows.Forms.PictureBox imgColon;
    }
}
