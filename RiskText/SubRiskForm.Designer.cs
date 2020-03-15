namespace RiskText
{
    partial class SubRiskForm
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
            this.txtSubRisk = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMainRisk = new System.Windows.Forms.GroupBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtReportingName = new System.Windows.Forms.TextBox();
            this.lblReportingName = new System.Windows.Forms.Label();
            this.lblSubRiskIndex = new System.Windows.Forms.Label();
            this.updSubRiskIndex = new System.Windows.Forms.NumericUpDown();
            this.txtSubRiskID = new System.Windows.Forms.TextBox();
            this.txtRiskType = new System.Windows.Forms.TextBox();
            this.lblRiskType = new System.Windows.Forms.Label();
            this.lblSubRiskID = new System.Windows.Forms.Label();
            this.lblOld = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpMainRisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSubRiskIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubRisk
            // 
            this.txtSubRisk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubRisk.Location = new System.Drawing.Point(5, 65);
            this.txtSubRisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubRisk.Multiline = true;
            this.txtSubRisk.Name = "txtSubRisk";
            this.txtSubRisk.Size = new System.Drawing.Size(784, 312);
            this.txtSubRisk.TabIndex = 2;
            this.txtSubRisk.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // grpMainRisk
            // 
            this.grpMainRisk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMainRisk.Controls.Add(this.lblOld);
            this.grpMainRisk.Controls.Add(this.lblToDate);
            this.grpMainRisk.Controls.Add(this.lblFromDate);
            this.grpMainRisk.Controls.Add(this.dtp);
            this.grpMainRisk.Controls.Add(this.txtReportingName);
            this.grpMainRisk.Controls.Add(this.lblReportingName);
            this.grpMainRisk.Controls.Add(this.lblSubRiskIndex);
            this.grpMainRisk.Controls.Add(this.updSubRiskIndex);
            this.grpMainRisk.Controls.Add(this.txtSubRiskID);
            this.grpMainRisk.Controls.Add(this.txtRiskType);
            this.grpMainRisk.Controls.Add(this.lblRiskType);
            this.grpMainRisk.Controls.Add(this.lblSubRiskID);
            this.grpMainRisk.Controls.Add(this.txtSubRisk);
            this.grpMainRisk.Location = new System.Drawing.Point(0, 31);
            this.grpMainRisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMainRisk.Name = "grpMainRisk";
            this.grpMainRisk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMainRisk.Size = new System.Drawing.Size(801, 378);
            this.grpMainRisk.TabIndex = 2;
            this.grpMainRisk.TabStop = false;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblToDate.Location = new System.Drawing.Point(706, 41);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(82, 17);
            this.lblToDate.TabIndex = 14;
            this.lblToDate.Text = "31-12-4000";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFromDate.Location = new System.Drawing.Point(520, 41);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(82, 17);
            this.lblFromDate.TabIndex = 13;
            this.lblFromDate.Text = "01-01-2000";
            // 
            // dtp
            // 
            this.dtp.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(610, 39);
            this.dtp.Margin = new System.Windows.Forms.Padding(4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(92, 22);
            this.dtp.TabIndex = 12;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // txtReportingName
            // 
            this.txtReportingName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportingName.Location = new System.Drawing.Point(159, 38);
            this.txtReportingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReportingName.Name = "txtReportingName";
            this.txtReportingName.Size = new System.Drawing.Size(324, 22);
            this.txtReportingName.TabIndex = 10;
            // 
            // lblReportingName
            // 
            this.lblReportingName.AutoSize = true;
            this.lblReportingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportingName.Location = new System.Drawing.Point(5, 42);
            this.lblReportingName.Name = "lblReportingName";
            this.lblReportingName.Size = new System.Drawing.Size(109, 17);
            this.lblReportingName.TabIndex = 9;
            this.lblReportingName.Text = "Reporting name";
            // 
            // lblSubRiskIndex
            // 
            this.lblSubRiskIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubRiskIndex.AutoSize = true;
            this.lblSubRiskIndex.Location = new System.Drawing.Point(669, 12);
            this.lblSubRiskIndex.Name = "lblSubRiskIndex";
            this.lblSubRiskIndex.Size = new System.Drawing.Size(41, 17);
            this.lblSubRiskIndex.TabIndex = 7;
            this.lblSubRiskIndex.Text = "Index";
            // 
            // updSubRiskIndex
            // 
            this.updSubRiskIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updSubRiskIndex.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updSubRiskIndex.Location = new System.Drawing.Point(716, 10);
            this.updSubRiskIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updSubRiskIndex.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updSubRiskIndex.Name = "updSubRiskIndex";
            this.updSubRiskIndex.Size = new System.Drawing.Size(72, 22);
            this.updSubRiskIndex.TabIndex = 6;
            // 
            // txtSubRiskID
            // 
            this.txtSubRiskID.Location = new System.Drawing.Point(159, 7);
            this.txtSubRiskID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubRiskID.Name = "txtSubRiskID";
            this.txtSubRiskID.Size = new System.Drawing.Size(188, 22);
            this.txtSubRiskID.TabIndex = 5;
            // 
            // txtRiskType
            // 
            this.txtRiskType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRiskType.Location = new System.Drawing.Point(425, 7);
            this.txtRiskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRiskType.Name = "txtRiskType";
            this.txtRiskType.Size = new System.Drawing.Size(175, 22);
            this.txtRiskType.TabIndex = 3;
            this.txtRiskType.TabStop = false;
            // 
            // lblRiskType
            // 
            this.lblRiskType.AutoSize = true;
            this.lblRiskType.Location = new System.Drawing.Point(353, 12);
            this.lblRiskType.Name = "lblRiskType";
            this.lblRiskType.Size = new System.Drawing.Size(66, 17);
            this.lblRiskType.TabIndex = 4;
            this.lblRiskType.Text = "Risk type";
            this.lblRiskType.Click += new System.EventHandler(this.lblRiskType_Click);
            // 
            // lblSubRiskID
            // 
            this.lblSubRiskID.AutoSize = true;
            this.lblSubRiskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubRiskID.Location = new System.Drawing.Point(5, 12);
            this.lblSubRiskID.Name = "lblSubRiskID";
            this.lblSubRiskID.Size = new System.Drawing.Size(49, 17);
            this.lblSubRiskID.TabIndex = 1;
            this.lblSubRiskID.Text = "Name";
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.ForeColor = System.Drawing.Color.Red;
            this.lblOld.Location = new System.Drawing.Point(51, 12);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(30, 17);
            this.lblOld.TabIndex = 15;
            this.lblOld.Text = "Old";
            this.lblOld.Visible = false;
            // 
            // SubRiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(801, 410);
            this.Controls.Add(this.grpMainRisk);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SubRiskForm";
            this.Text = "SubRiskForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMainRisk.ResumeLayout(false);
            this.grpMainRisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSubRiskIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubRisk;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpMainRisk;
        private System.Windows.Forms.Label lblSubRiskID;
        private System.Windows.Forms.TextBox txtRiskType;
        private System.Windows.Forms.Label lblRiskType;
        private System.Windows.Forms.TextBox txtSubRiskID;
        private System.Windows.Forms.Label lblSubRiskIndex;
        private System.Windows.Forms.NumericUpDown updSubRiskIndex;
        private System.Windows.Forms.TextBox txtReportingName;
        public System.Windows.Forms.Label lblReportingName;
        public System.Windows.Forms.DateTimePicker dtp;
        public System.Windows.Forms.Label lblToDate;
        public System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblOld;
    }
}