namespace RiskText
{
    partial class ExtraForm
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
            this.txtMainRisk = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMainRisk = new System.Windows.Forms.GroupBox();
            this.lblMainRiskName = new System.Windows.Forms.Label();
            this.cmsSubRisks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpMainRisk.SuspendLayout();
            this.cmsSubRisks.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMainRisk
            // 
            this.txtMainRisk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMainRisk.Location = new System.Drawing.Point(4, 42);
            this.txtMainRisk.Margin = new System.Windows.Forms.Padding(2);
            this.txtMainRisk.Multiline = true;
            this.txtMainRisk.Name = "txtMainRisk";
            this.txtMainRisk.Size = new System.Drawing.Size(588, 344);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveToolStripMenuItem.Text = "Save";            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.updateToolStripMenuItem.Text = "Update";            // 
            // grpMainRisk
            // 
            this.grpMainRisk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMainRisk.Controls.Add(this.cboName);
            this.grpMainRisk.Controls.Add(this.lblMainRiskName);
            this.grpMainRisk.Controls.Add(this.txtMainRisk);
            this.grpMainRisk.Location = new System.Drawing.Point(0, 25);
            this.grpMainRisk.Margin = new System.Windows.Forms.Padding(2);
            this.grpMainRisk.Name = "grpMainRisk";
            this.grpMainRisk.Padding = new System.Windows.Forms.Padding(2);
            this.grpMainRisk.Size = new System.Drawing.Size(600, 313);
            this.grpMainRisk.TabIndex = 2;
            this.grpMainRisk.TabStop = false;
            // 
            // lblMainRiskName
            // 
            this.lblMainRiskName.AutoSize = true;
            this.lblMainRiskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainRiskName.Location = new System.Drawing.Point(4, 10);
            this.lblMainRiskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainRiskName.Name = "lblMainRiskName";
            this.lblMainRiskName.Size = new System.Drawing.Size(39, 13);
            this.lblMainRiskName.TabIndex = 1;
            this.lblMainRiskName.Text = "Name";
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
            this.cmsSubRisks.Size = new System.Drawing.Size(180, 114);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openToolStripMenuItem.Text = "Open";            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addToolStripMenuItem.Text = "Add New";            // 
            // addExistingToolStripMenuItem
            // 
            this.addExistingToolStripMenuItem.Name = "addExistingToolStripMenuItem";
            this.addExistingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.addExistingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addExistingToolStripMenuItem.Text = "Add Existing";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.removeToolStripMenuItem.Text = "Remove";            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteToolStripMenuItem.Text = "Delete";            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Items.AddRange(new object[] {
            "Table Minor",
            "Table Mayor",
            "Table"});
            this.cboName.Location = new System.Drawing.Point(98, 10);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(137, 21);
            this.cboName.TabIndex = 2;
            // 
            // ExtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 422);
            this.Controls.Add(this.grpMainRisk);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExtraForm";
            this.Text = "ExtraForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMainRisk.ResumeLayout(false);
            this.grpMainRisk.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip cmsSubRisks;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExistingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboName;
    }
}