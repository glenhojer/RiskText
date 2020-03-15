namespace RiskText
{
    partial class AddingForm
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
            this.grpRisk = new System.Windows.Forms.GroupBox();
            this.txtRiskType = new System.Windows.Forms.TextBox();
            this.updIndex = new System.Windows.Forms.NumericUpDown();
            this.lblRiskType = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.txtRiskName = new System.Windows.Forms.TextBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.lblRiskName = new System.Windows.Forms.Label();
            this.grpText = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtReportingName = new System.Windows.Forms.TextBox();
            this.lblLongName = new System.Windows.Forms.Label();
            this.grpRisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updIndex)).BeginInit();
            this.grpText.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRisk
            // 
            this.grpRisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRisk.Controls.Add(this.txtReportingName);
            this.grpRisk.Controls.Add(this.lblLongName);
            this.grpRisk.Controls.Add(this.txtRiskType);
            this.grpRisk.Controls.Add(this.updIndex);
            this.grpRisk.Controls.Add(this.lblRiskType);
            this.grpRisk.Controls.Add(this.lblIndex);
            this.grpRisk.Controls.Add(this.txtParent);
            this.grpRisk.Controls.Add(this.txtRiskName);
            this.grpRisk.Controls.Add(this.lblParent);
            this.grpRisk.Controls.Add(this.lblRiskName);
            this.grpRisk.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grpRisk.Location = new System.Drawing.Point(2, 3);
            this.grpRisk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRisk.Name = "grpRisk";
            this.grpRisk.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRisk.Size = new System.Drawing.Size(537, 97);
            this.grpRisk.TabIndex = 0;
            this.grpRisk.TabStop = false;
            this.grpRisk.Text = "Main Risk";
            // 
            // txtRiskType
            // 
            this.txtRiskType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRiskType.Location = new System.Drawing.Point(325, 67);
            this.txtRiskType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRiskType.Name = "txtRiskType";
            this.txtRiskType.Size = new System.Drawing.Size(200, 20);
            this.txtRiskType.TabIndex = 7;
            // 
            // updIndex
            // 
            this.updIndex.Location = new System.Drawing.Point(106, 68);
            this.updIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updIndex.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updIndex.Name = "updIndex";
            this.updIndex.Size = new System.Drawing.Size(62, 20);
            this.updIndex.TabIndex = 7;
            // 
            // lblRiskType
            // 
            this.lblRiskType.AutoSize = true;
            this.lblRiskType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRiskType.Location = new System.Drawing.Point(270, 70);
            this.lblRiskType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRiskType.Name = "lblRiskType";
            this.lblRiskType.Size = new System.Drawing.Size(51, 13);
            this.lblRiskType.TabIndex = 6;
            this.lblRiskType.Text = "Risk type";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIndex.Location = new System.Drawing.Point(7, 70);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(33, 13);
            this.lblIndex.TabIndex = 6;
            this.lblIndex.Text = "Index";
            // 
            // txtParent
            // 
            this.txtParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParent.Location = new System.Drawing.Point(327, 16);
            this.txtParent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(198, 20);
            this.txtParent.TabIndex = 3;
            // 
            // txtRiskName
            // 
            this.txtRiskName.Location = new System.Drawing.Point(106, 16);
            this.txtRiskName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRiskName.Name = "txtRiskName";
            this.txtRiskName.Size = new System.Drawing.Size(144, 20);
            this.txtRiskName.TabIndex = 2;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParent.Location = new System.Drawing.Point(270, 19);
            this.lblParent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(38, 13);
            this.lblParent.TabIndex = 1;
            this.lblParent.Text = "Parent";
            // 
            // lblRiskName
            // 
            this.lblRiskName.AutoSize = true;
            this.lblRiskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiskName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRiskName.Location = new System.Drawing.Point(7, 19);
            this.lblRiskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRiskName.Name = "lblRiskName";
            this.lblRiskName.Size = new System.Drawing.Size(39, 13);
            this.lblRiskName.TabIndex = 0;
            this.lblRiskName.Text = "Name";
            // 
            // grpText
            // 
            this.grpText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpText.Controls.Add(this.txtText);
            this.grpText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grpText.Location = new System.Drawing.Point(2, 104);
            this.grpText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpText.Name = "grpText";
            this.grpText.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpText.Size = new System.Drawing.Size(538, 378);
            this.grpText.TabIndex = 1;
            this.grpText.TabStop = false;
            this.grpText.Text = "Text";
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(7, 15);
            this.txtText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(519, 358);
            this.txtText.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(329, 484);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 19);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(9, 484);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 19);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtReportingName
            // 
            this.txtReportingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportingName.Location = new System.Drawing.Point(106, 42);
            this.txtReportingName.Margin = new System.Windows.Forms.Padding(2);
            this.txtReportingName.Name = "txtReportingName";
            this.txtReportingName.Size = new System.Drawing.Size(420, 20);
            this.txtReportingName.TabIndex = 9;
            // 
            // lblLongName
            // 
            this.lblLongName.AutoSize = true;
            this.lblLongName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLongName.Location = new System.Drawing.Point(7, 45);
            this.lblLongName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLongName.Name = "lblLongName";
            this.lblLongName.Size = new System.Drawing.Size(84, 13);
            this.lblLongName.TabIndex = 8;
            this.lblLongName.Text = "Reporting Name";
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(544, 510);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpText);
            this.Controls.Add(this.grpRisk);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddingForm";
            this.Text = "Add - Main Risk";
            this.grpRisk.ResumeLayout(false);
            this.grpRisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updIndex)).EndInit();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRisk;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label lblRiskName;
        private System.Windows.Forms.TextBox txtRiskName;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.GroupBox grpText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRiskType;
        private System.Windows.Forms.NumericUpDown updIndex;
        private System.Windows.Forms.Label lblRiskType;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox txtReportingName;
        private System.Windows.Forms.Label lblLongName;
    }
}