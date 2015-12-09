namespace FTC_Timer_Display
{
    partial class frmModeSelection
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
            this.btnContinue = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDivName = new System.Windows.Forms.TextBox();
            this.numDivID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numField = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoServerClient = new System.Windows.Forms.RadioButton();
            this.rdoServerOnly = new System.Windows.Forms.RadioButton();
            this.rdoClient = new System.Windows.Forms.RadioButton();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDivID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numField)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnContinue, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDivName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.numDivID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.numField, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdoServerClient, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdoServerOnly, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdoClient, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.rdoLocal, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 241);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContinue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(3, 178);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(167, 60);
            this.btnContinue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continue";
            this.btnContinue.Click += new System.EventHandler(this.handleButtons);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(176, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 60);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Exit";
            this.btnCancel.Click += new System.EventHandler(this.handleButtons);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Division ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Division Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDivName
            // 
            this.txtDivName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDivName.Location = new System.Drawing.Point(176, 128);
            this.txtDivName.Name = "txtDivName";
            this.txtDivName.Size = new System.Drawing.Size(168, 20);
            this.txtDivName.TabIndex = 5;
            // 
            // numDivID
            // 
            this.numDivID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDivID.Location = new System.Drawing.Point(176, 3);
            this.numDivID.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numDivID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDivID.Name = "numDivID";
            this.numDivID.Size = new System.Drawing.Size(168, 20);
            this.numDivID.TabIndex = 6;
            this.numDivID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Field Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numField
            // 
            this.numField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numField.Location = new System.Drawing.Point(176, 153);
            this.numField.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numField.Name = "numField";
            this.numField.Size = new System.Drawing.Size(168, 20);
            this.numField.TabIndex = 8;
            this.numField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mode:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoServerClient
            // 
            this.rdoServerClient.AutoSize = true;
            this.rdoServerClient.Checked = true;
            this.rdoServerClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoServerClient.Location = new System.Drawing.Point(176, 28);
            this.rdoServerClient.Name = "rdoServerClient";
            this.rdoServerClient.Size = new System.Drawing.Size(168, 19);
            this.rdoServerClient.TabIndex = 10;
            this.rdoServerClient.TabStop = true;
            this.rdoServerClient.Text = "Server && Client";
            this.rdoServerClient.UseVisualStyleBackColor = true;
            this.rdoServerClient.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // rdoServerOnly
            // 
            this.rdoServerOnly.AutoSize = true;
            this.rdoServerOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoServerOnly.Location = new System.Drawing.Point(176, 53);
            this.rdoServerOnly.Name = "rdoServerOnly";
            this.rdoServerOnly.Size = new System.Drawing.Size(168, 19);
            this.rdoServerOnly.TabIndex = 11;
            this.rdoServerOnly.Text = "Server Only";
            this.rdoServerOnly.UseVisualStyleBackColor = true;
            this.rdoServerOnly.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // rdoClient
            // 
            this.rdoClient.AutoSize = true;
            this.rdoClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoClient.Location = new System.Drawing.Point(176, 78);
            this.rdoClient.Name = "rdoClient";
            this.rdoClient.Size = new System.Drawing.Size(168, 19);
            this.rdoClient.TabIndex = 12;
            this.rdoClient.Text = "Client";
            this.rdoClient.UseVisualStyleBackColor = true;
            this.rdoClient.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // rdoLocal
            // 
            this.rdoLocal.AutoSize = true;
            this.rdoLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoLocal.Location = new System.Drawing.Point(176, 103);
            this.rdoLocal.Name = "rdoLocal";
            this.rdoLocal.Size = new System.Drawing.Size(168, 19);
            this.rdoLocal.TabIndex = 13;
            this.rdoLocal.TabStop = true;
            this.rdoLocal.Text = "Local Only";
            this.rdoLocal.UseVisualStyleBackColor = true;
            this.rdoLocal.CheckedChanged += new System.EventHandler(this.rdoSelect);
            // 
            // frmModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 241);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModeSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Setup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmModeSelection_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDivID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.ButtonX btnContinue;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDivName;
        private System.Windows.Forms.NumericUpDown numDivID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoServerClient;
        private System.Windows.Forms.RadioButton rdoServerOnly;
        private System.Windows.Forms.RadioButton rdoClient;
        private System.Windows.Forms.RadioButton rdoLocal;
    }
}