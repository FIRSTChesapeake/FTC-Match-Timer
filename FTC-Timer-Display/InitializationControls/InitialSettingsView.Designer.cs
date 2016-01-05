namespace FTC_Timer_Display.InitializationControls
{
    partial class InitialSettingsView
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
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.lineAppMode = new FTC_Timer_Display.InitializationControls.InitialSettingsLine();
            this.lineDivMode = new FTC_Timer_Display.InitializationControls.InitialSettingsLine();
            this.lineDivID = new FTC_Timer_Display.InitializationControls.InitialSettingsLine();
            this.lineDivName = new FTC_Timer_Display.InitializationControls.InitialSettingsLine();
            this.lineEventType = new FTC_Timer_Display.InitializationControls.InitialSettingsLine();
            this.lineFieldID = new FTC_Timer_Display.InitializationControls.InitialSettingsLine();
            this.lineEventName = new FTC_Timer_Display.InitializationControls.InitialSettingsLine();
            this.ctrlHead = new FTC_Timer_Display.CtrlHeader();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.lineAppMode, 0, 1);
            this.tableMain.Controls.Add(this.lineDivMode, 0, 2);
            this.tableMain.Controls.Add(this.lineDivID, 0, 3);
            this.tableMain.Controls.Add(this.lineDivName, 0, 5);
            this.tableMain.Controls.Add(this.lineEventType, 0, 6);
            this.tableMain.Controls.Add(this.lineFieldID, 0, 7);
            this.tableMain.Controls.Add(this.lineEventName, 0, 4);
            this.tableMain.Controls.Add(this.ctrlHead, 0, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 9;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Size = new System.Drawing.Size(599, 450);
            this.tableMain.TabIndex = 0;
            // 
            // lineAppMode
            // 
            this.lineAppMode.description = "The mode this application will operate under.";
            this.lineAppMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineAppMode.Location = new System.Drawing.Point(4, 40);
            this.lineAppMode.Name = "lineAppMode";
            this.lineAppMode.Size = new System.Drawing.Size(591, 44);
            this.lineAppMode.TabIndex = 0;
            this.lineAppMode.title = "Application Mode";
            this.lineAppMode.value = "This is the Data";
            this.lineAppMode.varName = "";
            this.lineAppMode.ChangeLinkEvent += new System.EventHandler<string>(this.ChangeLinkEventHandler);
            // 
            // lineDivMode
            // 
            this.lineDivMode.description = "Whether this event is and one or more than one division.";
            this.lineDivMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineDivMode.Location = new System.Drawing.Point(4, 91);
            this.lineDivMode.Name = "lineDivMode";
            this.lineDivMode.Size = new System.Drawing.Size(591, 44);
            this.lineDivMode.TabIndex = 1;
            this.lineDivMode.title = "Single or Multi-Division Event";
            this.lineDivMode.value = "This is the Data";
            this.lineDivMode.varName = "";
            this.lineDivMode.ChangeLinkEvent += new System.EventHandler<string>(this.ChangeLinkEventHandler);
            // 
            // lineDivID
            // 
            this.lineDivID.description = "The ID Number for this division.";
            this.lineDivID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineDivID.Location = new System.Drawing.Point(4, 142);
            this.lineDivID.Name = "lineDivID";
            this.lineDivID.Size = new System.Drawing.Size(591, 44);
            this.lineDivID.TabIndex = 2;
            this.lineDivID.title = "Multi-Division ID";
            this.lineDivID.value = "This is the Data";
            this.lineDivID.varName = "";
            this.lineDivID.ChangeLinkEvent += new System.EventHandler<string>(this.ChangeLinkEventHandler);
            // 
            // lineDivName
            // 
            this.lineDivName.description = "The \'friendly name\' for this division.";
            this.lineDivName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineDivName.Location = new System.Drawing.Point(4, 244);
            this.lineDivName.Name = "lineDivName";
            this.lineDivName.Size = new System.Drawing.Size(591, 44);
            this.lineDivName.TabIndex = 3;
            this.lineDivName.title = "Division Name";
            this.lineDivName.value = "This is the Data";
            this.lineDivName.varName = "";
            this.lineDivName.ChangeLinkEvent += new System.EventHandler<string>(this.ChangeLinkEventHandler);
            // 
            // lineEventType
            // 
            this.lineEventType.description = "The type of event you are running.";
            this.lineEventType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineEventType.Location = new System.Drawing.Point(4, 295);
            this.lineEventType.Name = "lineEventType";
            this.lineEventType.Size = new System.Drawing.Size(591, 44);
            this.lineEventType.TabIndex = 4;
            this.lineEventType.title = "Event Type";
            this.lineEventType.value = "This is the Data";
            this.lineEventType.varName = "";
            this.lineEventType.ChangeLinkEvent += new System.EventHandler<string>(this.ChangeLinkEventHandler);
            // 
            // lineFieldID
            // 
            this.lineFieldID.description = "The ID of the field that will be displayed from this computer.";
            this.lineFieldID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineFieldID.Location = new System.Drawing.Point(4, 346);
            this.lineFieldID.Name = "lineFieldID";
            this.lineFieldID.Size = new System.Drawing.Size(591, 44);
            this.lineFieldID.TabIndex = 5;
            this.lineFieldID.title = "This Field Number";
            this.lineFieldID.value = "This is the Data";
            this.lineFieldID.varName = "";
            this.lineFieldID.ChangeLinkEvent += new System.EventHandler<string>(this.ChangeLinkEventHandler);
            // 
            // lineEventName
            // 
            this.lineEventName.description = "The name of your single division event.";
            this.lineEventName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineEventName.Location = new System.Drawing.Point(4, 193);
            this.lineEventName.Name = "lineEventName";
            this.lineEventName.Size = new System.Drawing.Size(591, 44);
            this.lineEventName.TabIndex = 7;
            this.lineEventName.title = "Event Name";
            this.lineEventName.value = "This is the Data";
            this.lineEventName.varName = "";
            this.lineEventName.Visible = false;
            this.lineEventName.ChangeLinkEvent += new System.EventHandler<string>(this.ChangeLinkEventHandler);
            // 
            // ctrlHead
            // 
            // 
            // 
            // 
            this.ctrlHead.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHead.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHead.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.ctrlHead.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ctrlHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHead.Location = new System.Drawing.Point(4, 4);
            this.ctrlHead.Name = "ctrlHead";
            this.ctrlHead.Size = new System.Drawing.Size(591, 29);
            this.ctrlHead.TabIndex = 8;
            this.ctrlHead.Text = "Current Settings";
            this.ctrlHead.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // InitialSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableMain);
            this.Name = "InitialSettingsView";
            this.Size = new System.Drawing.Size(599, 450);
            this.tableMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private InitialSettingsLine lineAppMode;
        private InitialSettingsLine lineDivMode;
        private InitialSettingsLine lineDivID;
        private InitialSettingsLine lineDivName;
        private InitialSettingsLine lineEventType;
        private InitialSettingsLine lineFieldID;
        private InitialSettingsLine lineEventName;
        private CtrlHeader ctrlHead;
    }
}
