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
            DevComponents.Instrumentation.GradientFillColor gradientFillColor1 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor2 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator1 = new DevComponents.Instrumentation.NumericIndicator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockFace));
            this.gaugeDisplay = new DevComponents.Instrumentation.GaugeControl();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeDisplay
            // 
            this.gaugeDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            gradientFillColor1.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor1.Color2 = System.Drawing.Color.DarkGray;
            this.gaugeDisplay.Frame.BackColor = gradientFillColor1;
            gradientFillColor2.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor2.BorderWidth = 1;
            gradientFillColor2.Color1 = System.Drawing.Color.White;
            gradientFillColor2.Color2 = System.Drawing.Color.DimGray;
            this.gaugeDisplay.Frame.FrameColor = gradientFillColor2;
            this.gaugeDisplay.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular;
            numericIndicator1.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator1.BackColor.BorderWidth = 3;
            numericIndicator1.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator1.DecimalColor = System.Drawing.Color.Lime;
            numericIndicator1.DecimalDimColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            numericIndicator1.DigitColor = System.Drawing.Color.Red;
            numericIndicator1.DigitDimColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            numericIndicator1.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Center;
            numericIndicator1.EmptyString = "INIT";
            numericIndicator1.FormatString = "";
            numericIndicator1.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator1.Location")));
            numericIndicator1.Name = "mainDigits";
            numericIndicator1.NumberOfDecimals = 0;
            numericIndicator1.NumberOfDigits = 4;
            numericIndicator1.RefreshRate = 100;
            numericIndicator1.ShowDimDecimalPoint = false;
            numericIndicator1.Size = new System.Drawing.SizeF(1F, 1F);
            numericIndicator1.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital16Segment;
            numericIndicator1.Text = "";
            this.gaugeDisplay.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator1});
            this.gaugeDisplay.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gaugeDisplay.Location = new System.Drawing.Point(0, 0);
            this.gaugeDisplay.Name = "gaugeDisplay";
            this.gaugeDisplay.Size = new System.Drawing.Size(1410, 553);
            this.gaugeDisplay.TabIndex = 18;
            this.gaugeDisplay.Text = "gaugeControl1";
            // 
            // ClockFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.gaugeDisplay);
            this.Name = "ClockFace";
            this.Size = new System.Drawing.Size(1410, 553);
            ((System.ComponentModel.ISupportInitialize)(this.gaugeDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Instrumentation.GaugeControl gaugeDisplay;

    }
}
