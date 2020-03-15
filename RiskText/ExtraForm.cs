using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace RiskText
{
    public partial class ExtraForm : Form
    {
        public string connectionString;
        public string mainRiskID;
        public int mainRiskIK;
        public int mainRiskIndex;
        public string mainRiskText;
        public string mainRiskType;
        public string mainRiskReportingName;
        DataGridViewCell dgvCell;

        public ExtraForm()
        {
            InitializeComponent();
        }
        public ExtraForm(DataGridViewCell _dgvCell, string _connectionString)
        {
            dgvCell = _dgvCell;
            
            connectionString = _connectionString;
            InitializeComponent();
            init();
            if(Environment.UserName != RiskTextForm.userID)
            {
                saveToolStripMenuItem.Enabled = false;
                addToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                addExistingToolStripMenuItem.Enabled = false;
                removeToolStripMenuItem.Enabled = false;
            }
        }

        private void init()
        {
        //    dgvSubRisks.Rows.Clear();
        //    dgvSubRisks.Columns.Clear();
        //    mainRiskID = dgvCell.OwningColumn.HeaderText;
        //    this.Text = "Main risk - " + mainRiskID;
        //    string SQL = $"SELECT * From Documents.MainRisk " +
        //        $" Where MainRiskID = '{mainRiskID}'";
        //    using (var dt = RiskTextForm.SQLDataTable(SQL, connectionString))
        //    {
        //        if (dt == null || dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("Not Available");
        //            this.Close();
        //            return;
        //        }
        //        mainRiskText = dt.Rows[0]["MainRiskText"].ToString();
        //        mainRiskType = dt.Rows[0]["MainRiskType"].ToString();
        //        mainRiskIK = (int)dt.Rows[0]["MainRiskIK"];
        //        mainRiskIndex = (int)dt.Rows[0]["MainRiskIndex"];
        //        mainRiskReportingName = dt.Rows[0]["MainRiskReportingName"].ToString();

        //    }
        //    txtMainRiskID.Text = mainRiskID;
        //    txtMainRisk.Text = mainRiskText;
        //    updMainRiskIndex.Value = mainRiskIndex;
        //    txtMainRiskType.Text = mainRiskType;
        //    txtReportingName.Text = mainRiskReportingName;
        //    txtMainRisk.DeselectAll();

        //    SQL = "SELECT SR.SubRiskID, SR.SubRiskIK From Documents.MainRisk as MR, Documents.MainRisk2SubRisk as MR2SR, Documents.SubRisk as SR" +
        //                    $" WHERE " +
        //                    $"SR.SubRiskIK = MR2SR.SubRiskIK AND " +
        //                    $"MR.MainRiskIK = MR2SR.MainRiskIK AND " +
        //                    $"MR.MainRiskIK = '{mainRiskIK}' " +
        //                    $"ORDER BY SR.SubRiskIndex ASC";
        //    using (var dt = RiskTextForm.SQLDataTable(SQL, connectionString))
        //    {
        //        DataGridViewCheckBoxColumn dgvCol;
        //        if (dt == null || dt.Rows.Count == 0)
        //        {

        //            dgvCol = new DataGridViewCheckBoxColumn
        //            {
        //                HeaderText = "None"
        //            };
        //            dgvCol.HeaderCell.Tag = 0;
        //            dgvCol.FlatStyle = FlatStyle.Flat;
        //            dgvCol.CellTemplate.Value = true;
        //            dgvSubRisks.Columns.Add(dgvCol);
        //        }
        //        else
        //        {

        //            foreach (DataRow row in dt.Rows)
        //            {
        //                dgvCol = new DataGridViewCheckBoxColumn
        //                {
        //                    HeaderText = row["SubRiskID"].ToString()
        //                };
        //                dgvCol.HeaderCell.Tag = (int)row["SubRiskIK"];
        //                dgvCol.FlatStyle = FlatStyle.Flat;
        //                dgvSubRisks.Columns.Add(dgvCol);
        //            }
        //        }
        //    }
                


        //    dgvSubRisks.Rows.Add();
        //    dgvSubRisks.Rows[0].HeaderCell.Value = dgvCell.OwningColumn.HeaderText;
        //    dgvSubRisks.CurrentCell = null;
        //    for (int j = 0; j < dgvSubRisks.ColumnCount; j++)
        //    {
        //        dgvSubRisks.Rows[0].Cells[j].Value = true;
        //    }

        //    int i = 0;
        //    dgvSubRisks.CurrentCell = null;
            

        }

        //private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            //string SQL = $"UPDATE Documents.MainRisk SET MainRiskID = '{txtMainRiskID.Text}', MainRiskText = '{txtMainRisk.Text}', MainRiskIndex = {(int)updMainRiskIndex.Value}, MainRiskType = '{txtMainRiskType.Text}', MainRiskReportingName = '{txtReportingName.Text}'" +
            //            $" WHERE MainRiskIK = '{mainRiskIK}'";
            //RiskTextForm.SQLNonQuery(SQL, connectionString);
            //MessageBox.Show("Saved");
            //this.Close();
            
        //}

        //private void openToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            //SubRiskForm subRisk = new SubRiskForm(dgvSubRisks.CurrentCell, connectionString);
            //try
            //{
            //    subRisk.Show();
            //}
            //catch (Exception)
            //{
            //    subRisk = null;
            //}
        //}

        //private void addToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddingForm adding = new AddingForm(txtMainRiskID.Text, connectionString);
        //    adding.Show();
        //}

        //private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    init();
        //}

        //private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            //try
            //{
            //    string SubRiskID = dgvSubRisks.CurrentCell.OwningColumn.HeaderText;
            //    int SubRiskIK = (int)dgvSubRisks.CurrentCell.OwningColumn.HeaderCell.Tag;
            //    var result = MessageBox.Show($"Do you wish to Delete '{SubRiskID}'", $"Delete {SubRiskID}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        string SQL = $"Delete From Documents.SubRisk where SubRiskIK = {SubRiskIK}";
            //        RiskTextForm.SQLNonQuery(SQL, connectionString);

            //        SQL = $"Delete From Documents.MainRisk2SubRisk where SubRiskIK = '{SubRiskIK}'";
            //        RiskTextForm.SQLNonQuery(SQL, connectionString);
            //        MessageBox.Show("Deleted");
            //    }
            //    init();
            //}
            //catch (Exception)
            //{

            //}

        //}

        //private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    int SubRiskIK = 0;

            //if(dgvSubRisks.CurrentCell == null || dgvSubRisks.CurrentCell.OwningColumn.Index == -1 || dgvSubRisks.CurrentCell.OwningColumn.HeaderText == "None")
            //{
            //    return;
            //}
            //else
            //{
            //    SubRiskIK = (int)dgvSubRisks.CurrentCell.OwningColumn.HeaderCell.Tag;

            //    string SQL = $"Delete from Documents.MainRisk2SubRisk Where MainRiskIK = {mainRiskIK} AND SubRiskIK = {SubRiskIK}";
            //    RiskTextForm.SQLNonQuery(SQL, connectionString);
            //    init();
            //}

        //}

        //private void dgvSubRisks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
            //SubRiskForm subRisk = new SubRiskForm(dgvSubRisks.CurrentCell, connectionString);
            //try
            //{
            //    subRisk.Show();
            //}
            //catch (Exception)
            //{
            //    subRisk = null;
            //}
        //}
    }
}
