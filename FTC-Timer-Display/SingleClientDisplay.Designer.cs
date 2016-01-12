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
            this.components = new System.ComponentModel.Container();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.tableIndicator = new System.Windows.Forms.TableLayoutPanel();
            this.radial = new DevComponents.DotNetBar.RadialMenu();
            this.radialStart = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialPause = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialStop = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialTimeout = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialStopTimeout = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialReset = new DevComponents.DotNetBar.RadialMenuItem();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.tableMain.SuspendLayout();
            this.tableIndicator.SuspendLayout();
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
            this.tableMain.Controls.Add(this.tableIndicator, 0, 0);
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
            // tableIndicator
            // 
            this.tableIndicator.BackgroundImage = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.tableIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableIndicator.ColumnCount = 1;
            this.tableIndicator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableIndicator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableIndicator.Controls.Add(this.radial, 0, 0);
            this.tableIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableIndicator.Location = new System.Drawing.Point(3, 3);
            this.tableIndicator.Name = "tableIndicator";
            this.tableIndicator.RowCount = 1;
            this.tableMain.SetRowSpan(this.tableIndicator, 2);
            this.tableIndicator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableIndicator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableIndicator.Size = new System.Drawing.Size(34, 34);
            this.tableIndicator.TabIndex = 4;
            // 
            // radial
            // 
            this.radial.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.radial.Colors.RadialMenuButtonBackground = System.Drawing.Color.Transparent;
            this.radial.Colors.RadialMenuButtonBorder = System.Drawing.Color.Transparent;
            this.radial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radial.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.radialStart,
            this.radialPause,
            this.radialStop,
            this.radialTimeout,
            this.radialStopTimeout,
            this.radialReset});
            this.radial.Location = new System.Drawing.Point(3, 3);
            this.radial.Name = "radial";
            this.radial.Size = new System.Drawing.Size(28, 28);
            this.radial.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.radial.SymbolSize = 15F;
            this.radial.TabIndex = 0;
            this.radial.Text = "radialMenu1";
            // 
            // radialStart
            // 
            this.radialStart.Name = "radialStart";
            this.radialStart.Text = "Start";
            this.radialStart.Click += new System.EventHandler(this.radialHandler);
            // 
            // radialPause
            // 
            this.radialPause.Name = "radialPause";
            this.radialPause.Text = "Pause";
            this.radialPause.Click += new System.EventHandler(this.radialHandler);
            // 
            // radialStop
            // 
            this.radialStop.Name = "radialStop";
            this.radialStop.Text = "Stop";
            this.radialStop.Click += new System.EventHandler(this.radialHandler);
            // 
            // radialTimeout
            // 
            this.radialTimeout.Name = "radialTimeout";
            this.radialTimeout.Text = "Timeout";
            this.radialTimeout.Click += new System.EventHandler(this.radialHandler);
            // 
            // radialStopTimeout
            // 
            this.radialStopTimeout.Name = "radialStopTimeout";
            this.radialStopTimeout.Text = "Abort";
            this.radialStopTimeout.Click += new System.EventHandler(this.radialHandler);
            // 
            // radialReset
            // 
            this.radialReset.Name = "radialReset";
            this.radialReset.Text = "Reset";
            this.radialReset.Click += new System.EventHandler(this.radialHandler);
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
            this.tableIndicator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.TableLayoutPanel tableIndicator;
        private DevComponents.DotNetBar.RadialMenu radial;
        private DevComponents.DotNetBar.RadialMenuItem radialStart;
        private DevComponents.DotNetBar.RadialMenuItem radialPause;
        private DevComponents.DotNetBar.RadialMenuItem radialStop;
        private DevComponents.DotNetBar.RadialMenuItem radialTimeout;
        private DevComponents.DotNetBar.RadialMenuItem radialStopTimeout;
        private DevComponents.DotNetBar.RadialMenuItem radialReset;
        private System.Windows.Forms.ToolTip toolTips;
    }
}
