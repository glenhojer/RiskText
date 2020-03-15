namespace RiskText
{
    partial class RiskTextForm
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
            this.dgvRisks = new System.Windows.Forms.DataGridView();
            this.contextMenuDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makeMajorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSRiskText = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prospectusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxDelete = new System.Windows.Forms.ToolStripComboBox();
            this.deleteAboveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxRebuild = new System.Windows.Forms.ToolStripComboBox();
            this.rebuildAboveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cboForening = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisks)).BeginInit();
            this.contextMenuDataGridView.SuspendLayout();
            this.MSRiskText.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRisks
            // 
            this.dgvRisks.AllowUserToAddRows = false;
            this.dgvRisks.AllowUserToDeleteRows = false;
            this.dgvRisks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRisks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRisks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRisks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRisks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRisks.ContextMenuStrip = this.contextMenuDataGridView;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRisks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRisks.EnableHeadersVisualStyles = false;
            this.dgvRisks.Location = new System.Drawing.Point(12, 62);
            this.dgvRisks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRisks.Name = "dgvRisks";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRisks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRisks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvRisks.RowTemplate.Height = 24;
            this.dgvRisks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRisks.Size = new System.Drawing.Size(1751, 946);
            this.dgvRisks.StandardTab = true;
            this.dgvRisks.TabIndex = 1;
            this.dgvRisks.TabStop = false;
            this.dgvRisks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRisks_MouseDoubleClick);
            // 
            // contextMenuDataGridView
            // 
            this.contextMenuDataGridView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeMajorToolStripMenuItem,
            this.openToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuDataGridView.Name = "contextMenuDataGridView";
            this.contextMenuDataGridView.Size = new System.Drawing.Size(213, 108);
            this.contextMenuDataGridView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuDataGridView_Opening);
            // 
            // makeMajorToolStripMenuItem
            // 
            this.makeMajorToolStripMenuItem.Checked = true;
            this.makeMajorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.makeMajorToolStripMenuItem.Name = "makeMajorToolStripMenuItem";
            this.makeMajorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.makeMajorToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.makeMajorToolStripMenuItem.Text = "Make Major";
            this.makeMajorToolStripMenuItem.Click += new System.EventHandler(this.makeMajorToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MSRiskText
            // 
            this.MSRiskText.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSRiskText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ekstraToolStripMenuItem});
            this.MSRiskText.Location = new System.Drawing.Point(0, 0);
            this.MSRiskText.Name = "MSRiskText";
            this.MSRiskText.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MSRiskText.Size = new System.Drawing.Size(1775, 28);
            this.MSRiskText.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.createDocumentToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // createDocumentToolStripMenuItem
            // 
            this.createDocumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prospectusToolStripMenuItem});
            this.createDocumentToolStripMenuItem.Name = "createDocumentToolStripMenuItem";
            this.createDocumentToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.createDocumentToolStripMenuItem.Text = "Create Document";
            // 
            // prospectusToolStripMenuItem
            // 
            this.prospectusToolStripMenuItem.Name = "prospectusToolStripMenuItem";
            this.prospectusToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.prospectusToolStripMenuItem.Text = "Prospectus";
            this.prospectusToolStripMenuItem.Click += new System.EventHandler(this.prospectusToolStripMenuItem_Click);
            // 
            // ekstraToolStripMenuItem
            // 
            this.ekstraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableDescriptionToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.ekstraToolStripMenuItem.Name = "ekstraToolStripMenuItem";
            this.ekstraToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ekstraToolStripMenuItem.Text = "Ekstra";
            // 
            // tableDescriptionToolStripMenuItem
            // 
            this.tableDescriptionToolStripMenuItem.Name = "tableDescriptionToolStripMenuItem";
            this.tableDescriptionToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.tableDescriptionToolStripMenuItem.Text = "Table description";
            this.tableDescriptionToolStripMenuItem.Click += new System.EventHandler(this.tableDescriptionToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1,
            this.rebuildToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAllToolStripMenuItem,
            this.toolStripComboBoxDelete,
            this.deleteAboveToolStripMenuItem});
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.deleteAllToolStripMenuItem.Text = "All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // toolStripComboBoxDelete
            // 
            this.toolStripComboBoxDelete.Items.AddRange(new object[] {
            "Fund2MainRisk",
            "MainRisk",
            "MainRisk2SubRisk",
            "SubRisk"});
            this.toolStripComboBoxDelete.Name = "toolStripComboBoxDelete";
            this.toolStripComboBoxDelete.Size = new System.Drawing.Size(121, 28);
            // 
            // deleteAboveToolStripMenuItem
            // 
            this.deleteAboveToolStripMenuItem.Name = "deleteAboveToolStripMenuItem";
            this.deleteAboveToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.deleteAboveToolStripMenuItem.Text = "Above";
            this.deleteAboveToolStripMenuItem.Click += new System.EventHandler(this.deleteAboveToolStripMenuItem_Click);
            // 
            // rebuildToolStripMenuItem
            // 
            this.rebuildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rebuildAllToolStripMenuItem,
            this.toolStripComboBoxRebuild,
            this.rebuildAboveToolStripMenuItem1});
            this.rebuildToolStripMenuItem.Name = "rebuildToolStripMenuItem";
            this.rebuildToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.rebuildToolStripMenuItem.Text = "Rebuild";
            // 
            // rebuildAllToolStripMenuItem
            // 
            this.rebuildAllToolStripMenuItem.Name = "rebuildAllToolStripMenuItem";
            this.rebuildAllToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.rebuildAllToolStripMenuItem.Text = "All";
            this.rebuildAllToolStripMenuItem.Click += new System.EventHandler(this.rebuildAllToolStripMenuItem_Click);
            // 
            // toolStripComboBoxRebuild
            // 
            this.toolStripComboBoxRebuild.Items.AddRange(new object[] {
            "Fund2MainRisk",
            "MainRisk",
            "MainRisk2SubRisk",
            "SubRisk"});
            this.toolStripComboBoxRebuild.Name = "toolStripComboBoxRebuild";
            this.toolStripComboBoxRebuild.Size = new System.Drawing.Size(121, 28);
            // 
            // rebuildAboveToolStripMenuItem1
            // 
            this.rebuildAboveToolStripMenuItem1.Name = "rebuildAboveToolStripMenuItem1";
            this.rebuildAboveToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.rebuildAboveToolStripMenuItem1.Text = "Above";
            this.rebuildAboveToolStripMenuItem1.Click += new System.EventHandler(this.rebuildAboveToolStripMenuItem1_Click);
            // 
            // cboForening
            // 
            this.cboForening.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForening.FormattingEnabled = true;
            this.cboForening.Location = new System.Drawing.Point(13, 30);
            this.cboForening.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboForening.Name = "cboForening";
            this.cboForening.Size = new System.Drawing.Size(349, 24);
            this.cboForening.Sorted = true;
            this.cboForening.TabIndex = 4;
            this.cboForening.SelectedIndexChanged += new System.EventHandler(this.cboForening_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(1577, 33);
            this.dtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(88, 22);
            this.dtp.TabIndex = 5;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFromDate.Location = new System.Drawing.Point(1487, 35);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(82, 17);
            this.lblFromDate.TabIndex = 6;
            this.lblFromDate.Text = "01-01-2000";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblToDate.Location = new System.Drawing.Point(1671, 35);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(82, 17);
            this.lblToDate.TabIndex = 7;
            this.lblToDate.Text = "31-12-4000";
            // 
            // RiskTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1775, 1019);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cboForening);
            this.Controls.Add(this.MSRiskText);
            this.Controls.Add(this.dgvRisks);
            this.MainMenuStrip = this.MSRiskText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RiskTextForm";
            this.Text = "RiskText";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisks)).EndInit();
            this.contextMenuDataGridView.ResumeLayout(false);
            this.MSRiskText.ResumeLayout(false);
            this.MSRiskText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuDataGridView;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MSRiskText;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prospectusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeMajorToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvRisks;
        public System.Windows.Forms.ComboBox cboForening;
        private System.Windows.Forms.ToolStripMenuItem ekstraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteAboveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebuildAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxRebuild;
        private System.Windows.Forms.ToolStripMenuItem rebuildAboveToolStripMenuItem1;
        public System.Windows.Forms.DateTimePicker dtp;
        public System.Windows.Forms.Label lblFromDate;
        public System.Windows.Forms.Label lblToDate;
    }
}

