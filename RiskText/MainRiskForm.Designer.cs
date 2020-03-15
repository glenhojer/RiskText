namespace RiskText
{
    partial class MainRiskForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMainRisk = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMainRisk = new System.Windows.Forms.GroupBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtReportingName = new System.Windows.Forms.TextBox();
            this.lblReportingName = new System.Windows.Forms.Label();
            this.lblMainRiskType = new System.Windows.Forms.Label();
            this.txtMainRiskType = new System.Windows.Forms.TextBox();
            this.txtMainRiskID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updMainRiskIndex = new System.Windows.Forms.NumericUpDown();
            this.lblMainRiskName = new System.Windows.Forms.Label();
            this.grpSubRisk = new System.Windows.Forms.GroupBox();
            this.dgvSubRisks = new System.Windows.Forms.DataGridView();
            this.cmsSubRisks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOld = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpMainRisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updMainRiskIndex)).BeginInit();
            this.grpSubRisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubRisks)).BeginInit();
            this.cmsSubRisks.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMainRisk
            // 
            this.txtMainRisk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMainRisk.Location = new System.Drawing.Point(5, 64);
            this.txtMainRisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMainRisk.Multiline = true;
            this.txtMainRisk.Name = "txtMainRisk";
            this.txtMainRisk.Size = new System.Drawing.Size(783, 315);
            this.txtMainRisk.TabIndex = 1;
            this.txtMainRisk.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
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
            this.grpMainRisk.Controls.Add(this.lblMainRiskType);
            this.grpMainRisk.Controls.Add(this.txtMainRiskType);
            this.grpMainRisk.Controls.Add(this.txtMainRiskID);
            this.grpMainRisk.Controls.Add(this.label1);
            this.grpMainRisk.Controls.Add(this.updMainRiskIndex);
            this.grpMainRisk.Controls.Add(this.lblMainRiskName);
            this.grpMainRisk.Controls.Add(this.txtMainRisk);
            this.grpMainRisk.Location = new System.Drawing.Point(0, 31);
            this.grpMainRisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMainRisk.Name = "grpMainRisk";
            this.grpMainRisk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMainRisk.Size = new System.Drawing.Size(800, 385);
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
            this.lblToDate.TabIndex = 11;
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
            this.lblFromDate.TabIndex = 10;
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
            this.dtp.TabIndex = 9;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // txtReportingName
            // 
            this.txtReportingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportingName.Location = new System.Drawing.Point(159, 38);
            this.txtReportingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReportingName.Name = "txtReportingName";
            this.txtReportingName.Size = new System.Drawing.Size(354, 22);
            this.txtReportingName.TabIndex = 8;
            // 
            // lblReportingName
            // 
            this.lblReportingName.AutoSize = true;
            this.lblReportingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportingName.Location = new System.Drawing.Point(5, 42);
            this.lblReportingName.Name = "lblReportingName";
            this.lblReportingName.Size = new System.Drawing.Size(109, 17);
            this.lblReportingName.TabIndex = 7;
            this.lblReportingName.Text = "Reporting name";
            // 
            // lblMainRiskType
            // 
            this.lblMainRiskType.AutoSize = true;
            this.lblMainRiskType.Location = new System.Drawing.Point(353, 12);
            this.lblMainRiskType.Name = "lblMainRiskType";
            this.lblMainRiskType.Size = new System.Drawing.Size(66, 17);
            this.lblMainRiskType.TabIndex = 6;
            this.lblMainRiskType.Text = "Risk type";
            // 
            // txtMainRiskType
            // 
            this.txtMainRiskType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMainRiskType.Location = new System.Drawing.Point(427, 9);
            this.txtMainRiskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMainRiskType.Name = "txtMainRiskType";
            this.txtMainRiskType.Size = new System.Drawing.Size(175, 22);
            this.txtMainRiskType.TabIndex = 5;
            this.txtMainRiskType.TabStop = false;
            // 
            // txtMainRiskID
            // 
            this.txtMainRiskID.Location = new System.Drawing.Point(159, 9);
            this.txtMainRiskID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMainRiskID.Name = "txtMainRiskID";
            this.txtMainRiskID.Size = new System.Drawing.Size(188, 22);
            this.txtMainRiskID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Index";
            // 
            // updMainRiskIndex
            // 
            this.updMainRiskIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updMainRiskIndex.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.updMainRiskIndex.Location = new System.Drawing.Point(716, 10);
            this.updMainRiskIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updMainRiskIndex.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updMainRiskIndex.Name = "updMainRiskIndex";
            this.updMainRiskIndex.Size = new System.Drawing.Size(72, 22);
            this.updMainRiskIndex.TabIndex = 2;
            // 
            // lblMainRiskName
            // 
            this.lblMainRiskName.AutoSize = true;
            this.lblMainRiskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainRiskName.Location = new System.Drawing.Point(5, 12);
            this.lblMainRiskName.Name = "lblMainRiskName";
            this.lblMainRiskName.Size = new System.Drawing.Size(49, 17);
            this.lblMainRiskName.TabIndex = 1;
            this.lblMainRiskName.Text = "Name";
            // 
            // grpSubRisk
            // 
            this.grpSubRisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSubRisk.Controls.Add(this.dgvSubRisks);
            this.grpSubRisk.Location = new System.Drawing.Point(-8, 422);
            this.grpSubRisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSubRisk.Name = "grpSubRisk";
            this.grpSubRisk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSubRisk.Size = new System.Drawing.Size(808, 78);
            this.grpSubRisk.TabIndex = 3;
            this.grpSubRisk.TabStop = false;
            this.grpSubRisk.Text = "Sub risks";
            // 
            // dgvSubRisks
            // 
            this.dgvSubRisks.AllowUserToAddRows = false;
            this.dgvSubRisks.AllowUserToDeleteRows = false;
            this.dgvSubRisks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubRisks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubRisks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubRisks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubRisks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubRisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubRisks.ContextMenuStrip = this.cmsSubRisks;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubRisks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSubRisks.EnableHeadersVisualStyles = false;
            this.dgvSubRisks.Location = new System.Drawing.Point(13, 22);
            this.dgvSubRisks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSubRisks.Name = "dgvSubRisks";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubRisks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSubRisks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSubRisks.RowTemplate.Height = 24;
            this.dgvSubRisks.Size = new System.Drawing.Size(783, 48);
            this.dgvSubRisks.TabIndex = 2;
            this.dgvSubRisks.TabStop = false;
            this.dgvSubRisks.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubRisks_CellMouseDoubleClick);
            // 
            // cmsSubRisks
            // 
            this.cmsSubRisks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSubRisks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.addToolStripMenuItem,
            this.addExistingToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsSubRisks.Name = "cmsSubRisks";
            this.cmsSubRisks.Size = new System.Drawing.Size(212, 124);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.addToolStripMenuItem.Text = "Add New";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addExistingToolStripMenuItem
            // 
            this.addExistingToolStripMenuItem.Name = "addExistingToolStripMenuItem";
            this.addExistingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.addExistingToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.addExistingToolStripMenuItem.Text = "Add Existing";
            this.addExistingToolStripMenuItem.Click += new System.EventHandler(this.addExistingToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.ForeColor = System.Drawing.Color.Red;
            this.lblOld.Location = new System.Drawing.Point(51, 12);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(30, 17);
            this.lblOld.TabIndex = 12;
            this.lblOld.Text = "Old";
            this.lblOld.Visible = false;
            // 
            // MainRiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.grpSubRisk);
            this.Controls.Add(this.grpMainRisk);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainRiskForm";
            this.Text = "MainRiskForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMainRisk.ResumeLayout(false);
            this.grpMainRisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updMainRiskIndex)).EndInit();
            this.grpSubRisk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubRisks)).EndInit();
            this.cmsSubRisks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainRisk;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpMainRisk;
        public System.Windows.Forms.Label lblMainRiskName;
        private System.Windows.Forms.GroupBox grpSubRisk;
        private System.Windows.Forms.DataGridView dgvSubRisks;
        private System.Windows.Forms.ContextMenuStrip cmsSubRisks;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExistingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updMainRiskIndex;
        private System.Windows.Forms.TextBox txtMainRiskID;
        private System.Windows.Forms.Label lblMainRiskType;
        private System.Windows.Forms.TextBox txtMainRiskType;
        private System.Windows.Forms.TextBox txtReportingName;
        public System.Windows.Forms.Label lblReportingName;
        public System.Windows.Forms.DateTimePicker dtp;
        public System.Windows.Forms.Label lblToDate;
        public System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblOld;
    }
}