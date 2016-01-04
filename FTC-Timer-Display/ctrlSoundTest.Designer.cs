namespace FTC_Timer_Display
{
    partial class CtrlSoundTest
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
            this.btnStopPregen = new DevComponents.DotNetBar.ButtonX();
            this.flowSounds = new System.Windows.Forms.FlowLayoutPanel();
            this.swLoop = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.tableVoice = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlHeader2 = new FTC_Timer_Display.CtrlHeader();
            this.btnSpeak = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpeak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.slideVoiceVolume = new DevComponents.DotNetBar.Controls.Slider();
            this.slideVoiceRate = new DevComponents.DotNetBar.Controls.Slider();
            this.btnStopVoice = new System.Windows.Forms.Button();
            this.tabCtrlMain = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tableSounds = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.tableVoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCtrlMain)).BeginInit();
            this.tabCtrlMain.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.tableSounds.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStopPregen
            // 
            this.btnStopPregen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStopPregen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStopPregen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopPregen.Location = new System.Drawing.Point(555, 389);
            this.btnStopPregen.Name = "btnStopPregen";
            this.btnStopPregen.Size = new System.Drawing.Size(144, 39);
            this.btnStopPregen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStopPregen.TabIndex = 3;
            this.btnStopPregen.Text = "Stop";
            this.btnStopPregen.Click += new System.EventHandler(this.HandlePreRecordedSoundsButtons);
            // 
            // flowSounds
            // 
            this.flowSounds.AutoScroll = true;
            this.flowSounds.AutoSize = true;
            this.tableSounds.SetColumnSpan(this.flowSounds, 3);
            this.flowSounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSounds.Location = new System.Drawing.Point(3, 28);
            this.flowSounds.MinimumSize = new System.Drawing.Size(0, 35);
            this.flowSounds.Name = "flowSounds";
            this.flowSounds.Size = new System.Drawing.Size(696, 355);
            this.flowSounds.TabIndex = 5;
            // 
            // swLoop
            // 
            // 
            // 
            // 
            this.swLoop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swLoop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swLoop.Location = new System.Drawing.Point(405, 389);
            this.swLoop.Name = "swLoop";
            this.swLoop.OffText = "PLAY ONCE";
            this.swLoop.OnText = "LOOP FOREVER";
            this.swLoop.Size = new System.Drawing.Size(144, 39);
            this.swLoop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swLoop.TabIndex = 6;
            // 
            // tableVoice
            // 
            this.tableVoice.AutoSize = true;
            this.tableVoice.ColumnCount = 4;
            this.tableVoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableVoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableVoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableVoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableVoice.Controls.Add(this.ctrlHeader2, 0, 0);
            this.tableVoice.Controls.Add(this.btnSpeak, 2, 5);
            this.tableVoice.Controls.Add(this.label3, 0, 1);
            this.tableVoice.Controls.Add(this.txtSpeak, 1, 1);
            this.tableVoice.Controls.Add(this.label4, 0, 2);
            this.tableVoice.Controls.Add(this.label5, 0, 3);
            this.tableVoice.Controls.Add(this.slideVoiceVolume, 1, 2);
            this.tableVoice.Controls.Add(this.slideVoiceRate, 1, 3);
            this.tableVoice.Controls.Add(this.btnStopVoice, 3, 5);
            this.tableVoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableVoice.Location = new System.Drawing.Point(0, 0);
            this.tableVoice.Name = "tableVoice";
            this.tableVoice.RowCount = 6;
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableVoice.Size = new System.Drawing.Size(702, 431);
            this.tableVoice.TabIndex = 3;
            // 
            // ctrlHeader2
            // 
            // 
            // 
            // 
            this.ctrlHeader2.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHeader2.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHeader2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableVoice.SetColumnSpan(this.ctrlHeader2, 4);
            this.ctrlHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader2.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader2.Name = "ctrlHeader2";
            this.ctrlHeader2.Size = new System.Drawing.Size(696, 19);
            this.ctrlHeader2.TabIndex = 7;
            this.ctrlHeader2.Text = "Voice Synthesizer";
            this.ctrlHeader2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSpeak
            // 
            this.btnSpeak.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSpeak.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSpeak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSpeak.Location = new System.Drawing.Point(405, 394);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(144, 34);
            this.btnSpeak.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSpeak.TabIndex = 0;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.Click += new System.EventHandler(this.HandlePreRecordedSoundsButtons);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Text to Speak";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSpeak
            // 
            this.tableVoice.SetColumnSpan(this.txtSpeak, 3);
            this.txtSpeak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpeak.Location = new System.Drawing.Point(96, 28);
            this.txtSpeak.Name = "txtSpeak";
            this.txtSpeak.Size = new System.Drawing.Size(603, 20);
            this.txtSpeak.TabIndex = 2;
            this.txtSpeak.Text = "Good morning! Welcome to the FIRST Tech Challenge.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Voice Volume";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Voice Rate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slideVoiceVolume
            // 
            // 
            // 
            // 
            this.slideVoiceVolume.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableVoice.SetColumnSpan(this.slideVoiceVolume, 3);
            this.slideVoiceVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideVoiceVolume.LabelVisible = false;
            this.slideVoiceVolume.Location = new System.Drawing.Point(96, 54);
            this.slideVoiceVolume.Name = "slideVoiceVolume";
            this.slideVoiceVolume.Size = new System.Drawing.Size(603, 29);
            this.slideVoiceVolume.Step = 5;
            this.slideVoiceVolume.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slideVoiceVolume.TabIndex = 5;
            this.slideVoiceVolume.Value = 0;
            this.slideVoiceVolume.ValueChanged += new System.EventHandler(this.sliderChangeHandler);
            // 
            // slideVoiceRate
            // 
            // 
            // 
            // 
            this.slideVoiceRate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableVoice.SetColumnSpan(this.slideVoiceRate, 3);
            this.slideVoiceRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideVoiceRate.LabelVisible = false;
            this.slideVoiceRate.Location = new System.Drawing.Point(96, 89);
            this.slideVoiceRate.Maximum = 10;
            this.slideVoiceRate.Minimum = -10;
            this.slideVoiceRate.Name = "slideVoiceRate";
            this.slideVoiceRate.Size = new System.Drawing.Size(603, 29);
            this.slideVoiceRate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slideVoiceRate.TabIndex = 6;
            this.slideVoiceRate.Value = 0;
            // 
            // btnStopVoice
            // 
            this.btnStopVoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopVoice.Location = new System.Drawing.Point(555, 394);
            this.btnStopVoice.Name = "btnStopVoice";
            this.btnStopVoice.Size = new System.Drawing.Size(144, 34);
            this.btnStopVoice.TabIndex = 8;
            this.btnStopVoice.Text = "Stop";
            this.btnStopVoice.UseVisualStyleBackColor = true;
            this.btnStopVoice.Click += new System.EventHandler(this.HandlePreRecordedSoundsButtons);
            // 
            // tabCtrlMain
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabCtrlMain.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabCtrlMain.ControlBox.MenuBox.Name = "";
            this.tabCtrlMain.ControlBox.Name = "";
            this.tabCtrlMain.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabCtrlMain.ControlBox.MenuBox,
            this.tabCtrlMain.ControlBox.CloseBox});
            this.tabCtrlMain.Controls.Add(this.superTabControlPanel1);
            this.tabCtrlMain.Controls.Add(this.superTabControlPanel2);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.ReorderTabsEnabled = true;
            this.tabCtrlMain.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabCtrlMain.SelectedTabIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(702, 456);
            this.tabCtrlMain.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlMain.TabIndex = 1;
            this.tabCtrlMain.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.tabCtrlMain.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.tableSounds);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(702, 431);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // tableSounds
            // 
            this.tableSounds.ColumnCount = 3;
            this.tableSounds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSounds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSounds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSounds.Controls.Add(this.btnStopPregen, 2, 2);
            this.tableSounds.Controls.Add(this.ctrlHeader1, 0, 0);
            this.tableSounds.Controls.Add(this.swLoop, 1, 2);
            this.tableSounds.Controls.Add(this.flowSounds, 0, 1);
            this.tableSounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSounds.Location = new System.Drawing.Point(0, 0);
            this.tableSounds.Name = "tableSounds";
            this.tableSounds.RowCount = 3;
            this.tableSounds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableSounds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSounds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSounds.Size = new System.Drawing.Size(702, 431);
            this.tableSounds.TabIndex = 0;
            // 
            // ctrlHeader1
            // 
            // 
            // 
            // 
            this.ctrlHeader1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHeader1.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHeader1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableSounds.SetColumnSpan(this.ctrlHeader1, 3);
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader1.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(696, 19);
            this.ctrlHeader1.TabIndex = 6;
            this.ctrlHeader1.Text = "Pre-Generated Sounds";
            this.ctrlHeader1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Pre-Generated Sounds";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.tableVoice);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(702, 431);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Voice Synthesizer";
            // 
            // CtrlSoundTest
            // 
            this.Controls.Add(this.tabCtrlMain);
            this.Name = "CtrlSoundTest";
            this.Size = new System.Drawing.Size(702, 456);
            this.Load += new System.EventHandler(this.frmSoundTest_Load);
            this.tableVoice.ResumeLayout(false);
            this.tableVoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCtrlMain)).EndInit();
            this.tabCtrlMain.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.tableSounds.ResumeLayout(false);
            this.tableSounds.PerformLayout();
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnStopPregen;
        private System.Windows.Forms.FlowLayoutPanel flowSounds;
        private DevComponents.DotNetBar.Controls.SwitchButton swLoop;
        private System.Windows.Forms.TableLayoutPanel tableVoice;
        private DevComponents.DotNetBar.ButtonX btnSpeak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpeak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.Slider slideVoiceVolume;
        private DevComponents.DotNetBar.Controls.Slider slideVoiceRate;
        private CtrlHeader ctrlHeader1;
        private CtrlHeader ctrlHeader2;
        private System.Windows.Forms.TableLayoutPanel tableSounds;
        private DevComponents.DotNetBar.SuperTabControl tabCtrlMain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private System.Windows.Forms.Button btnStopVoice;
    }
}