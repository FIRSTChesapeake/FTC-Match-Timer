namespace FTC_Timer_Display
{
    partial class PeriodProgressBar
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
            this.progressSteps = new DevComponents.DotNetBar.ProgressSteps();
            this.stepWait = new DevComponents.DotNetBar.StepItem();
            this.stepNoCross = new DevComponents.DotNetBar.StepItem();
            this.stepAuto = new DevComponents.DotNetBar.StepItem();
            this.stepDriver = new DevComponents.DotNetBar.StepItem();
            this.stepEndgame = new DevComponents.DotNetBar.StepItem();
            this.stepComplete = new DevComponents.DotNetBar.StepItem();
            this.SuspendLayout();
            // 
            // progressSteps
            // 
            // 
            // 
            // 
            this.progressSteps.BackgroundStyle.Class = "ProgressSteps";
            this.progressSteps.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressSteps.ContainerControlProcessDialogKey = true;
            this.progressSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressSteps.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stepWait,
            this.stepNoCross,
            this.stepAuto,
            this.stepDriver,
            this.stepEndgame,
            this.stepComplete});
            this.progressSteps.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.progressSteps.Location = new System.Drawing.Point(0, 0);
            this.progressSteps.Name = "progressSteps";
            this.progressSteps.Size = new System.Drawing.Size(728, 64);
            this.progressSteps.TabIndex = 24;
            // 
            // stepWait
            // 
            this.stepWait.Name = "stepWait";
            this.stepWait.SymbolSize = 13F;
            this.stepWait.Tag = "0";
            this.stepWait.Text = "<b>Wait for Start</b>\r\n<br/>Match is Ready";
            // 
            // stepNoCross
            // 
            this.stepNoCross.Name = "stepNoCross";
            this.stepNoCross.SymbolSize = 13F;
            this.stepNoCross.Tag = "1";
            this.stepNoCross.Text = "<b>No Cross Auto</b>\r\n<br/>Watch that center line!";
            // 
            // stepAuto
            // 
            this.stepAuto.Name = "stepAuto";
            this.stepAuto.ProgressColors = new System.Drawing.Color[0];
            this.stepAuto.SymbolSize = 13F;
            this.stepAuto.Tag = "1";
            this.stepAuto.Text = "<b>Autonomous</b>\r\n<br/>Can they score!?";
            // 
            // stepDriver
            // 
            this.stepDriver.BeginGroup = true;
            this.stepDriver.Name = "stepDriver";
            this.stepDriver.SymbolSize = 13F;
            this.stepDriver.Tag = "2";
            this.stepDriver.Text = "<b>Driver Controlled</b>\r\n<br/>Teams Take Control";
            // 
            // stepEndgame
            // 
            this.stepEndgame.Name = "stepEndgame";
            this.stepEndgame.SymbolSize = 13F;
            this.stepEndgame.Tag = "3";
            this.stepEndgame.Text = "<b>End Game</b>\r\n<br/>Cap Ball Time";
            // 
            // stepComplete
            // 
            this.stepComplete.BeginGroup = true;
            this.stepComplete.Description = "The match is complete";
            this.stepComplete.Name = "stepComplete";
            this.stepComplete.ProgressColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.stepComplete.Stretch = true;
            this.stepComplete.SymbolSize = 13F;
            this.stepComplete.Tag = "4";
            this.stepComplete.Text = "<b>Complete</b>\r\n<br/>Match Over";
            // 
            // PeriodProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressSteps);
            this.Name = "PeriodProgressBar";
            this.Size = new System.Drawing.Size(728, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ProgressSteps progressSteps;
        private DevComponents.DotNetBar.StepItem stepWait;
        private DevComponents.DotNetBar.StepItem stepNoCross;
        private DevComponents.DotNetBar.StepItem stepAuto;
        private DevComponents.DotNetBar.StepItem stepDriver;
        private DevComponents.DotNetBar.StepItem stepEndgame;
        private DevComponents.DotNetBar.StepItem stepComplete;
    }
}
