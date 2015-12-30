namespace FTC_Timer_Display
{
    partial class frmPitDisplay
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picMainComms = new System.Windows.Forms.PictureBox();
            this.flowDiv1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowDiv2 = new System.Windows.Forms.FlowLayoutPanel();
            this.browserDiv1results = new System.Windows.Forms.WebBrowser();
            this.browserDiv2results = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.browserDiv1ranking = new System.Windows.Forms.WebBrowser();
            this.browserDiv2ranking = new System.Windows.Forms.WebBrowser();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainComms)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowDiv1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowDiv2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.browserDiv1results, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.browserDiv2ranking, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.browserDiv1ranking, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.browserDiv2results, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1179, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Controls.Add(this.picMainComms, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(856, 571);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // picMainComms
            // 
            this.picMainComms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMainComms.Image = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.picMainComms.Location = new System.Drawing.Point(288, 3);
            this.picMainComms.Name = "picMainComms";
            this.picMainComms.Size = new System.Drawing.Size(29, 23);
            this.picMainComms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainComms.TabIndex = 0;
            this.picMainComms.TabStop = false;
            // 
            // flowDiv1
            // 
            this.flowDiv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDiv1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowDiv1.Location = new System.Drawing.Point(3, 33);
            this.flowDiv1.Name = "flowDiv1";
            this.tableLayoutPanel1.SetRowSpan(this.flowDiv1, 2);
            this.flowDiv1.Size = new System.Drawing.Size(319, 532);
            this.flowDiv1.TabIndex = 2;
            // 
            // flowDiv2
            // 
            this.flowDiv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDiv2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowDiv2.Location = new System.Drawing.Point(856, 33);
            this.flowDiv2.Name = "flowDiv2";
            this.tableLayoutPanel1.SetRowSpan(this.flowDiv2, 2);
            this.flowDiv2.Size = new System.Drawing.Size(320, 532);
            this.flowDiv2.TabIndex = 3;
            // 
            // browserDiv1results
            // 
            this.browserDiv1results.AllowWebBrowserDrop = false;
            this.browserDiv1results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserDiv1results.IsWebBrowserContextMenuEnabled = false;
            this.browserDiv1results.Location = new System.Drawing.Point(328, 33);
            this.browserDiv1results.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserDiv1results.Name = "browserDiv1results";
            this.browserDiv1results.ScriptErrorsSuppressed = true;
            this.browserDiv1results.Size = new System.Drawing.Size(258, 263);
            this.browserDiv1results.TabIndex = 4;
            this.browserDiv1results.WebBrowserShortcutsEnabled = false;
            // 
            // browserDiv2results
            // 
            this.browserDiv2results.AllowWebBrowserDrop = false;
            this.browserDiv2results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserDiv2results.IsWebBrowserContextMenuEnabled = false;
            this.browserDiv2results.Location = new System.Drawing.Point(592, 33);
            this.browserDiv2results.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserDiv2results.Name = "browserDiv2results";
            this.browserDiv2results.ScriptErrorsSuppressed = true;
            this.browserDiv2results.Size = new System.Drawing.Size(258, 263);
            this.browserDiv2results.TabIndex = 5;
            this.browserDiv2results.WebBrowserShortcutsEnabled = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Division 1 Results";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browserDiv1ranking
            // 
            this.browserDiv1ranking.AllowWebBrowserDrop = false;
            this.browserDiv1ranking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserDiv1ranking.IsWebBrowserContextMenuEnabled = false;
            this.browserDiv1ranking.Location = new System.Drawing.Point(328, 302);
            this.browserDiv1ranking.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserDiv1ranking.Name = "browserDiv1ranking";
            this.browserDiv1ranking.ScriptErrorsSuppressed = true;
            this.browserDiv1ranking.Size = new System.Drawing.Size(258, 263);
            this.browserDiv1ranking.TabIndex = 8;
            this.browserDiv1ranking.WebBrowserShortcutsEnabled = false;
            // 
            // browserDiv2ranking
            // 
            this.browserDiv2ranking.AllowWebBrowserDrop = false;
            this.browserDiv2ranking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserDiv2ranking.IsWebBrowserContextMenuEnabled = false;
            this.browserDiv2ranking.Location = new System.Drawing.Point(592, 302);
            this.browserDiv2ranking.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserDiv2ranking.Name = "browserDiv2ranking";
            this.browserDiv2ranking.ScriptErrorsSuppressed = true;
            this.browserDiv2ranking.Size = new System.Drawing.Size(258, 263);
            this.browserDiv2ranking.TabIndex = 9;
            this.browserDiv2ranking.WebBrowserShortcutsEnabled = false;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Division 2 Results";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel1.SetColumnSpan(this.labelX1, 2);
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(328, 571);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(522, 29);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "This scrolling display is temporary. Better Pit Display coming soon.";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmPitDisplay
            // 
            this.ClientSize = new System.Drawing.Size(1179, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmPitDisplay";
            this.Load += new System.EventHandler(this.frmPitDisplay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPitDisplay_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMainComms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox picMainComms;
        private System.Windows.Forms.Timer timerMain;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.FlowLayoutPanel flowDiv1;
        private System.Windows.Forms.FlowLayoutPanel flowDiv2;
        private System.Windows.Forms.WebBrowser browserDiv1results;
        private System.Windows.Forms.WebBrowser browserDiv2results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser browserDiv1ranking;
        private System.Windows.Forms.WebBrowser browserDiv2ranking;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}