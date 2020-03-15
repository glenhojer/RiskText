namespace RiskText
{
    partial class ChooseSubRisk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSubrisks = new System.Windows.Forms.DataGridView();
            this.SubRiskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubRiskIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubRiskType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubrisks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubrisks
            // 
            this.dgvSubrisks.AllowUserToAddRows = false;
            this.dgvSubrisks.AllowUserToDeleteRows = false;
            this.dgvSubrisks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubrisks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubrisks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubrisks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubrisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubrisks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubRiskID,
            this.SubRiskIK,
            this.SubRiskType});
            this.dgvSubrisks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubrisks.EnableHeadersVisualStyles = false;
            this.dgvSubrisks.Location = new System.Drawing.Point(12, 12);
            this.dgvSubrisks.Name = "dgvSubrisks";
            this.dgvSubrisks.ReadOnly = true;
            this.dgvSubrisks.RowHeadersVisible = false;
            this.dgvSubrisks.RowTemplate.Height = 24;
            this.dgvSubrisks.Size = new System.Drawing.Size(266, 425);
            this.dgvSubrisks.TabIndex = 0;
            this.dgvSubrisks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSubrisks_MouseDoubleClick);
            // 
            // SubRiskID
            // 
            this.SubRiskID.HeaderText = "Name";
            this.SubRiskID.Name = "SubRiskID";
            this.SubRiskID.ReadOnly = true;
            // 
            // SubRiskIK
            // 
            this.SubRiskIK.HeaderText = "IK";
            this.SubRiskIK.Name = "SubRiskIK";
            this.SubRiskIK.ReadOnly = true;
            this.SubRiskIK.Visible = false;
            // 
            // SubRiskType
            // 
            this.SubRiskType.HeaderText = "Risk type";
            this.SubRiskType.Name = "SubRiskType";
            this.SubRiskType.ReadOnly = true;
            // 
            // ChooseSubRisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(290, 450);
            this.Controls.Add(this.dgvSubrisks);
            this.Name = "ChooseSubRisk";
            this.Text = "Sub Risk";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubrisks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubrisks;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubRiskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubRiskIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubRiskType;
    }
}