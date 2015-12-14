namespace FTC_Timer_Display
{
    partial class frmSoundTest
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableSounds = new System.Windows.Forms.TableLayoutPanel();
            this.btnStopAll = new DevComponents.DotNetBar.ButtonX();
            this.flowSounds = new System.Windows.Forms.FlowLayoutPanel();
            this.swLoop = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.tableVoice = new System.Windows.Forms.TableLayoutPanel();
            this.btnSpeak = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpeak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.knobVolume = new DevComponents.Instrumentation.KnobControl();
            this.knobRate = new DevComponents.Instrumentation.KnobControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableSounds.SuspendLayout();
            this.tableVoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableSounds, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableVoice, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pre-Generated Sounds";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voice Synthesizer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableSounds
            // 
            this.tableSounds.ColumnCount = 1;
            this.tableSounds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSounds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSounds.Controls.Add(this.btnStopAll, 0, 2);
            this.tableSounds.Controls.Add(this.flowSounds, 0, 0);
            this.tableSounds.Controls.Add(this.swLoop, 0, 1);
            this.tableSounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSounds.Location = new System.Drawing.Point(4, 30);
            this.tableSounds.Name = "tableSounds";
            this.tableSounds.RowCount = 3;
            this.tableSounds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSounds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableSounds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSounds.Size = new System.Drawing.Size(299, 227);
            this.tableSounds.TabIndex = 2;
            // 
            // btnStopAll
            // 
            this.btnStopAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStopAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStopAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopAll.Location = new System.Drawing.Point(3, 190);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(293, 34);
            this.btnStopAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStopAll.TabIndex = 3;
            this.btnStopAll.Text = "Stop All";
            this.btnStopAll.Click += new System.EventHandler(this.HandlePreRecordedSoundsButtons);
            // 
            // flowSounds
            // 
            this.flowSounds.AutoSize = true;
            this.flowSounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSounds.Location = new System.Drawing.Point(3, 3);
            this.flowSounds.MinimumSize = new System.Drawing.Size(0, 35);
            this.flowSounds.Name = "flowSounds";
            this.flowSounds.Size = new System.Drawing.Size(293, 156);
            this.flowSounds.TabIndex = 5;
            // 
            // swLoop
            // 
            // 
            // 
            // 
            this.swLoop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swLoop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swLoop.Location = new System.Drawing.Point(3, 165);
            this.swLoop.Name = "swLoop";
            this.swLoop.OffText = "PLAY ONCE";
            this.swLoop.OnText = "LOOP FOREVER";
            this.swLoop.Size = new System.Drawing.Size(293, 19);
            this.swLoop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swLoop.TabIndex = 6;
            // 
            // tableVoice
            // 
            this.tableVoice.ColumnCount = 2;
            this.tableVoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableVoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableVoice.Controls.Add(this.btnSpeak, 0, 5);
            this.tableVoice.Controls.Add(this.label3, 0, 0);
            this.tableVoice.Controls.Add(this.txtSpeak, 0, 1);
            this.tableVoice.Controls.Add(this.label4, 0, 2);
            this.tableVoice.Controls.Add(this.label5, 1, 2);
            this.tableVoice.Controls.Add(this.knobVolume, 0, 3);
            this.tableVoice.Controls.Add(this.knobRate, 1, 3);
            this.tableVoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableVoice.Location = new System.Drawing.Point(310, 30);
            this.tableVoice.Name = "tableVoice";
            this.tableVoice.RowCount = 6;
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableVoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableVoice.Size = new System.Drawing.Size(299, 227);
            this.tableVoice.TabIndex = 3;
            // 
            // btnSpeak
            // 
            this.btnSpeak.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSpeak.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tableVoice.SetColumnSpan(this.btnSpeak, 2);
            this.btnSpeak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSpeak.Location = new System.Drawing.Point(3, 190);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(293, 34);
            this.btnSpeak.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSpeak.TabIndex = 0;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableVoice.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Text to Speak:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSpeak
            // 
            this.tableVoice.SetColumnSpan(this.txtSpeak, 2);
            this.txtSpeak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpeak.Location = new System.Drawing.Point(3, 28);
            this.txtSpeak.Name = "txtSpeak";
            this.txtSpeak.Size = new System.Drawing.Size(293, 20);
            this.txtSpeak.TabIndex = 2;
            this.txtSpeak.Text = "Good morning! Welcome to the FIRST Tech Challenge.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Voice Volume";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Voice Rate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // knobVolume
            // 
            this.knobVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knobVolume.KnobStyle = DevComponents.Instrumentation.eKnobStyle.Style4;
            this.knobVolume.Location = new System.Drawing.Point(3, 78);
            this.knobVolume.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knobVolume.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knobVolume.Name = "knobVolume";
            this.knobVolume.Size = new System.Drawing.Size(143, 104);
            this.knobVolume.TabIndex = 5;
            this.knobVolume.Text = "knobControl1";
            this.knobVolume.ValueChanged += new System.EventHandler<DevComponents.Instrumentation.ValueChangedEventArgs>(this.KnobChgHandler);
            // 
            // knobRate
            // 
            this.knobRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knobRate.KnobStyle = DevComponents.Instrumentation.eKnobStyle.Style4;
            this.knobRate.Location = new System.Drawing.Point(152, 78);
            this.knobRate.MajorTickAmount = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.knobRate.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.knobRate.MinorTickAmount = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knobRate.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.knobRate.Name = "knobRate";
            this.knobRate.Size = new System.Drawing.Size(144, 104);
            this.knobRate.TabIndex = 6;
            this.knobRate.Text = "knobControl2";
            this.knobRate.ValueChanged += new System.EventHandler<DevComponents.Instrumentation.ValueChangedEventArgs>(this.KnobChgHandler);
            // 
            // frmSoundTest
            // 
            this.ClientSize = new System.Drawing.Size(613, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSoundTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sound Testing";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSoundTest_FormClosing);
            this.Load += new System.EventHandler(this.frmSoundTest_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableSounds.ResumeLayout(false);
            this.tableSounds.PerformLayout();
            this.tableVoice.ResumeLayout(false);
            this.tableVoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableSounds;
        private DevComponents.DotNetBar.ButtonX btnStopAll;
        private System.Windows.Forms.FlowLayoutPanel flowSounds;
        private DevComponents.DotNetBar.Controls.SwitchButton swLoop;
        private System.Windows.Forms.TableLayoutPanel tableVoice;
        private DevComponents.DotNetBar.ButtonX btnSpeak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpeak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevComponents.Instrumentation.KnobControl knobVolume;
        private DevComponents.Instrumentation.KnobControl knobRate;
    }
}