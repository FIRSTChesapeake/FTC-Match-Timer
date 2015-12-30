namespace FTC_Timer_Display
{
    partial class PitFieldDisplay
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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMatchNumber = new System.Windows.Forms.Label();
            this.lblMatchState = new System.Windows.Forms.Label();
            this.lblMatchPeriod = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMatchTime = new System.Windows.Forms.Label();
            this.picMainComms = new System.Windows.Forms.PictureBox();
            this.picMatchState = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainComms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatchState)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 4;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.mainTable.Controls.Add(this.lblHeader, 0, 0);
            this.mainTable.Controls.Add(this.label2, 0, 1);
            this.mainTable.Controls.Add(this.label3, 0, 2);
            this.mainTable.Controls.Add(this.label4, 0, 3);
            this.mainTable.Controls.Add(this.lblMatchNumber, 1, 1);
            this.mainTable.Controls.Add(this.lblMatchState, 1, 2);
            this.mainTable.Controls.Add(this.lblMatchPeriod, 1, 3);
            this.mainTable.Controls.Add(this.label8, 0, 4);
            this.mainTable.Controls.Add(this.lblMatchTime, 1, 4);
            this.mainTable.Controls.Add(this.picMainComms, 2, 4);
            this.mainTable.Controls.Add(this.picMatchState, 2, 2);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 6;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTable.Size = new System.Drawing.Size(323, 220);
            this.mainTable.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.mainTable.SetColumnSpan(this.lblHeader, 4);
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(4, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(315, 54);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Division 1 Field 1";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Match:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Match State:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Match Period:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatchNumber
            // 
            this.lblMatchNumber.AutoSize = true;
            this.mainTable.SetColumnSpan(this.lblMatchNumber, 2);
            this.lblMatchNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchNumber.Location = new System.Drawing.Point(154, 54);
            this.lblMatchNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatchNumber.Name = "lblMatchNumber";
            this.lblMatchNumber.Size = new System.Drawing.Size(155, 38);
            this.lblMatchNumber.TabIndex = 4;
            this.lblMatchNumber.Text = "Unknown";
            this.lblMatchNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatchState
            // 
            this.lblMatchState.AutoSize = true;
            this.lblMatchState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchState.Location = new System.Drawing.Point(154, 92);
            this.lblMatchState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatchState.Name = "lblMatchState";
            this.lblMatchState.Size = new System.Drawing.Size(125, 38);
            this.lblMatchState.TabIndex = 5;
            this.lblMatchState.Text = "Unknown";
            this.lblMatchState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatchPeriod
            // 
            this.lblMatchPeriod.AutoSize = true;
            this.mainTable.SetColumnSpan(this.lblMatchPeriod, 2);
            this.lblMatchPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchPeriod.Location = new System.Drawing.Point(154, 130);
            this.lblMatchPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatchPeriod.Name = "lblMatchPeriod";
            this.lblMatchPeriod.Size = new System.Drawing.Size(155, 38);
            this.lblMatchPeriod.TabIndex = 6;
            this.lblMatchPeriod.Text = "Unknown";
            this.lblMatchPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 38);
            this.label8.TabIndex = 7;
            this.label8.Text = "Time Remaining:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatchTime
            // 
            this.lblMatchTime.AutoSize = true;
            this.lblMatchTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchTime.Location = new System.Drawing.Point(154, 168);
            this.lblMatchTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatchTime.Name = "lblMatchTime";
            this.lblMatchTime.Size = new System.Drawing.Size(125, 38);
            this.lblMatchTime.TabIndex = 8;
            this.lblMatchTime.Text = "Unknown";
            this.lblMatchTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picMainComms
            // 
            this.picMainComms.Image = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.picMainComms.Location = new System.Drawing.Point(286, 171);
            this.picMainComms.Name = "picMainComms";
            this.picMainComms.Size = new System.Drawing.Size(24, 24);
            this.picMainComms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainComms.TabIndex = 9;
            this.picMainComms.TabStop = false;
            // 
            // picMatchState
            // 
            this.picMatchState.Image = global::FTC_Timer_Display.Properties.Resources.indicator_red;
            this.picMatchState.Location = new System.Drawing.Point(286, 95);
            this.picMatchState.Name = "picMatchState";
            this.picMatchState.Size = new System.Drawing.Size(24, 24);
            this.picMatchState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMatchState.TabIndex = 10;
            this.picMatchState.TabStop = false;
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // PitFieldDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.mainTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PitFieldDisplay";
            this.Size = new System.Drawing.Size(323, 220);
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainComms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatchState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMatchNumber;
        private System.Windows.Forms.Label lblMatchState;
        private System.Windows.Forms.Label lblMatchPeriod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMatchTime;
        private System.Windows.Forms.PictureBox picMainComms;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.PictureBox picMatchState;
    }
}
