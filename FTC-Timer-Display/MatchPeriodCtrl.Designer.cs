namespace FTC_Timer_Display
{
    partial class MatchPeriodCtrl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNocross = new DevComponents.DotNetBar.LabelX();
            this.lblEndgame = new DevComponents.DotNetBar.LabelX();
            this.lblAuto = new DevComponents.DotNetBar.LabelX();
            this.lblDriver = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNocross, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEndgame, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAuto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDriver, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 255);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNocross
            // 
            this.lblNocross.BackColor = System.Drawing.Color.DarkRed;
            // 
            // 
            // 
            this.lblNocross.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNocross.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNocross.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNocross.ForeColor = System.Drawing.Color.Aqua;
            this.lblNocross.Location = new System.Drawing.Point(6, 168);
            this.lblNocross.Name = "lblNocross";
            this.lblNocross.Size = new System.Drawing.Size(372, 81);
            this.lblNocross.TabIndex = 7;
            this.lblNocross.Text = "No Crossing";
            this.lblNocross.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblEndgame
            // 
            this.lblEndgame.BackColor = System.Drawing.Color.DarkRed;
            // 
            // 
            // 
            this.lblEndgame.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEndgame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndgame.ForeColor = System.Drawing.Color.Aqua;
            this.lblEndgame.Location = new System.Drawing.Point(387, 168);
            this.lblEndgame.Name = "lblEndgame";
            this.lblEndgame.Size = new System.Drawing.Size(372, 81);
            this.lblEndgame.TabIndex = 5;
            this.lblEndgame.Text = "End Game";
            this.lblEndgame.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblAuto
            // 
            this.lblAuto.BackColor = System.Drawing.Color.DarkRed;
            // 
            // 
            // 
            this.lblAuto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.ForeColor = System.Drawing.Color.Aqua;
            this.lblAuto.Location = new System.Drawing.Point(6, 6);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(372, 153);
            this.lblAuto.TabIndex = 0;
            this.lblAuto.Text = "Autonomous";
            this.lblAuto.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDriver
            // 
            this.lblDriver.BackColor = System.Drawing.Color.DarkRed;
            // 
            // 
            // 
            this.lblDriver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriver.ForeColor = System.Drawing.Color.Aqua;
            this.lblDriver.Location = new System.Drawing.Point(387, 6);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(372, 153);
            this.lblDriver.TabIndex = 2;
            this.lblDriver.Text = "Driver Controlled";
            this.lblDriver.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // MatchPeriodCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MatchPeriodCtrl";
            this.Size = new System.Drawing.Size(765, 255);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX lblAuto;
        private DevComponents.DotNetBar.LabelX lblDriver;
        private DevComponents.DotNetBar.LabelX lblNocross;
        private DevComponents.DotNetBar.LabelX lblEndgame;
    }
}
