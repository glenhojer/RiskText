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
    public partial class MainRiskForm : Form
    {
        public string connectionString;
        public string mainRiskID;
        public int mainRiskIK;
        public int mainRiskIndex;
        public string mainRiskText;
        public string mainRiskType;
        public string mainRiskReportingName;
        public DateTime mainRiskTo;
        public DateTime mainRiskFrom;
        public DateTime EvalDate;
        DataGridViewCell dgvCell;

        bool readOnly = false;

        public MainRiskForm()
        {
            InitializeComponent();
        }
        public MainRiskForm(DataGridViewCell _dgvCell, string _connectionString, DateTime EvalDate, bool readOnly)
        {
            this.readOnly = readOnly;

            dgvCell = _dgvCell;
            connectionString = _connectionString;
            InitializeComponent();
            dtp.Value = EvalDate;
            init();
            if(readOnly)
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
            dgvSubRisks.Rows.Clear();
            dgvSubRisks.Columns.Clear();
            mainRiskID = dgvCell.OwningColumn.HeaderText;
            this.Text = "Main risk - " + mainRiskID;
            string SQL = 
                $"SELECT " +
                    $"* " +
                $"FROM " +
                    $"[Documents].[MainRisk] " +
                $"WHERE 1 = 1 " +
                    $"AND [MainRiskID] = '{mainRiskID}' " +
                    $"AND [ToDate] > @EvalDate " +
                    $"AND [FromDate] <= @EvalDate ";
            using (var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), true))
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Not Available");
                    this.Close();
                    return;
                }
                mainRiskText = dt.Rows[0]["MainRiskText"].ToString();
                mainRiskType = dt.Rows[0]["MainRiskType"].ToString();
                mainRiskIK = (int)dt.Rows[0]["MainRiskIK"];
                mainRiskIndex = (int)dt.Rows[0]["MainRiskIndex"];
                mainRiskReportingName = dt.Rows[0]["MainRiskReportingName"].ToString();
                mainRiskTo = (DateTime)dt.Rows[0]["ToDate"];
                mainRiskFrom = (DateTime)dt.Rows[0]["FromDate"];


            }
            txtMainRiskID.Text = mainRiskID;
            txtMainRisk.Text = mainRiskText;
            updMainRiskIndex.Value = mainRiskIndex;
            txtMainRiskType.Text = mainRiskType;
            txtReportingName.Text = mainRiskReportingName;
            lblFromDate.Text = mainRiskFrom.ToShortDateString();
            lblToDate.Text = mainRiskTo.ToShortDateString();
            txtMainRisk.DeselectAll();

            SQL =   "SELECT " +
                        "[SR].[SubRiskID], " +
                        "[SR].[SubRiskIK] " +
                    "FROM " +
                        "[Documents].[MainRisk] as [MR], " +
                        "[Documents].[MainRisk2SubRisk] as [MR2SR], " +
                        "[Documents].[SubRisk] as [SR] " +
                    $"WHERE 1=1 " +
                        "AND [SR].[SubRiskIK] = [MR2SR].[SubRiskIK] " +
                        "AND [MR].[MainRiskIK] = [MR2SR].[MainRiskIK] " +
                        $"AND [MR].[MainRiskIK] = '{mainRiskIK}' " +
                        "AND [SR].[FromDate] <= @EvalDate " +
                        "AND [MR2SR].[FromDate] <= @EvalDate " +
                        "AND [SR].[ToDate] > @Evaldate " +
                        "AND [MR2SR].[ToDate] > @Evaldate " +
                    $"ORDER BY " +
                        "[SR].[SubRiskIndex] ASC";
            using (var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), true))
            {
                DataGridViewCheckBoxColumn dgvCol;
                if (dt == null || dt.Rows.Count == 0)
                {

                    dgvCol = new DataGridViewCheckBoxColumn();
                    dgvCol.HeaderText = "None";
                    dgvCol.HeaderCell.Tag = 0;
                    dgvCol.FlatStyle = FlatStyle.Flat;
                    dgvCol.CellTemplate.Value = true;
                    dgvSubRisks.Columns.Add(dgvCol);
                }
                else
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        dgvCol = new DataGridViewCheckBoxColumn();
                        dgvCol.HeaderText = row["SubRiskID"].ToString();
                        dgvCol.HeaderCell.Tag = (int)row["SubRiskIK"];
                        dgvCol.FlatStyle = FlatStyle.Flat;
                        dgvSubRisks.Columns.Add(dgvCol);
                    }
                }
            }
                
            dgvSubRisks.Rows.Add();
            dgvSubRisks.Rows[0].HeaderCell.Value = dgvCell.OwningColumn.HeaderText;
            dgvSubRisks.CurrentCell = null;
            for (int j = 0; j < dgvSubRisks.ColumnCount; j++)
            {
                dgvSubRisks.Rows[0].Cells[j].Value = true;
            }

            dgvSubRisks.CurrentCell = null;
            lblOld.Visible = false;
            if (dtp.Value.Date != DateTime.Today) lblOld.Visible = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (readOnly) return;
            string SQL = "";
            if (!SaveCheck())
            {
                SQL =
                "SELECT " +
                    "* " +
                "FROM " +
                    "[Documents].[MainRisk] " +
                "WHERE 1 = 1 " +
                    "AND [ToDate] = @MaxDate " +
                    $"AND [MainRiskIK] = {mainRiskIK};";
                using (var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), true))
                {

                    if ((DateTime)dt.Rows[0]["FromDate"] == DateTime.Today.Date)
                    {
                        SQL =
                            $"UPDATE " +
                                $"[Documents].[MainRisk] " +
                            $"SET " +
                                $"[MainRiskID] = '{txtMainRiskID.Text}', " +
                                $"[MainRiskText] = '{txtMainRisk.Text}', " +
                                $"[MainRiskIndex] = '{(int)updMainRiskIndex.Value}', " +
                                $"[MainRiskType] = '{txtMainRiskType.Text}', " +
                                $"[MainRiskReportingName] = '{txtReportingName.Text}' " +
                            $"WHERE 1 = 1 " +
                                $"AND [MainRiskIK] = '{mainRiskIK}' " +
                                $"AND [ToDate] = @MaxDate;";
                        RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), false);
                    }
                    else
                    {
                        SQL =
                            $"UPDATE " +
                                $"[Documents].[MainRisk] " +
                            $"SET " +
                                $"[ToDate] = @Today " +
                            $"WHERE 1 = 1 " +
                                $"AND [MainRiskIK] = {mainRiskIK} " +
                                $"AND [ToDate] = @MaxDate " +
                                $"AND [FromDate] <> @Today;" +

                            $"INSERT INTO " +
                                $"[Documents].[MainRisk] " +
                                $"(" +
                                    $" [MainRiskID]," +
                                    $" [MainRiskText]," +
                                    $" [MainRiskIndex]," +
                                    $" [MainRiskType]," +
                                    $" [MainRiskReportingName]," +
                                    $" [FromDate]," +
                                    $" [ToDate]" +
                                $") " +
                            $"VALUES " +
                            $"( " +
                                $" '{txtMainRiskID.Text}'," +
                                $" '{txtMainRisk.Text}'," +
                                $" {(int)updMainRiskIndex.Value}," +
                                $" '{txtMainRiskType.Text}'," +
                                $" '{txtReportingName.Text}'," +
                                $" @Today," +
                                $" @MaxDate" +
                            $") " +
                            $";";
                        RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), false);

                        int newMainRiskIK;
                        SQL =
                            "SELECT " +
                                "[MainRisk2SubRiskIK] as IK, [SubRiskIK], [FromDate], [ToDate] " +
                            "FROM " +
                                "[Documents].[MainRisk2SubRisk] " +
                            "WHERE 1 = 1 " +
                                $"AND [MainRiskIK] = {mainRiskIK} " +
                                "AND [ToDate] = @MaxDate";
                        using (var dtM2S = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), true))
                        {
                            SQL =
                                "SELECT " +
                                    "[MainRiskIK] " +
                                "FROM " +
                                    "[Documents].[MainRisk] " +
                                "WHERE 1 = 1 " +
                                    $"AND [MainRiskID] = '{txtMainRiskID.Text}' " +
                                    "AND [ToDate] = @MaxDate";

                            using (var dtIK = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), true))
                            {
                                newMainRiskIK = (int)dtIK.Rows[0]["MainRiskIK"];
                            }
                            foreach (DataRow row in dtM2S.Rows)
                            {
                                if ((DateTime)row["FromDate"] == DateTime.Today.Date)
                                {
                                    SQL =
                                        $"UPDATE " +
                                            $"[Documents].[MainRisk2SubRiskIK] " +
                                        $"SET " +
                                            $"[MainRiskIK] = {newMainRiskIK}, " +
                                        $"WHERE 1 = 1 " +
                                            $"AND [MainRisk2SubRiskIK] = {(int)row["IK"]} " +
                                            $"AND [ToDate] = @MaxDate;";
                                }
                                else
                                {
                                    SQL =
                                        "UPDATE " +
                                            "[Documents].[MainRisk2SubRisk] " +
                                        "SET " +
                                            "[ToDate] = @Today " +
                                        "WHERE 1 = 1 " +
                                            "AND [ToDate] = @MaxDate " +
                                            $"AND [MainRisk2SubRiskIK] = {(int)row["IK"]}" +

                                            ";" +

                                        "INSERT INTO " +
                                            "[Documents].[MainRisk2SubRisk] " +
                                            "( " +
                                                "[SubRiskIK], " +
                                                "[MainRiskIK], " +
                                                "[FromDate], " +
                                                "[ToDate] " +
                                            ") " +
                                        "VALUES " +
                                        "( " +
                                            $"{(int)row["SubRiskIK"]}, " +
                                            $"{newMainRiskIK}, " +
                                            "@Today, " +
                                            "@MaxDate " +
                                        ")" +
                                        ";";
                                }
                                RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), false);
                            }
                        }
                        SQL =
                            "SELECT " +
                                "[Fund2MainRiskIK] as IK, [Fund_IK], [Major], [FromDate], [ToDate] " +
                            "FROM " +
                                "[Documents].[Fund2MainRisk] " +
                            "WHERE 1 = 1 " +
                                $"AND [MainRiskIK] = {mainRiskIK} " +
                                "AND [ToDate] = @MaxDate";
                        using (var dtF2S = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), true))
                        {
                            foreach (DataRow row in dtF2S.Rows)
                            {
                                if ((DateTime)row["FromDate"] == DateTime.Today.Date)
                                {
                                    SQL =
                                        $"UPDATE " +
                                            $"[Documents].[Fund2MainRisk] " +
                                        $"SET " +
                                            $"[MainRiskIK] = {newMainRiskIK}, " +
                                        $"WHERE 1 = 1 " +
                                            $"AND [Fund2MainRiskIK] = {(int)row["IK"]} " +
                                            $"AND [ToDate] = @MaxDate;";
                                }
                                else
                                {
                                    SQL =
                                        "UPDATE " +
                                            "[Documents].[Fund2MainRisk] " +
                                        "SET " +
                                            "[ToDate] = @Today " +
                                        "WHERE 1 = 1 " +
                                            "AND [ToDate] = @MaxDate " +
                                            $"AND [Fund2MainRiskIK] = {(int)row["IK"]}" +

                                        ";" +

                                        "INSERT INTO " +
                                            "[Documents].[Fund2MainRisk] " +
                                            "( " +
                                                "[Fund_IK], " +
                                                "[MainRiskIK], " +
                                                "[Major], " +
                                                "[FromDate], " +
                                                "[ToDate] " +
                                            ") " +
                                        "VALUES " +
                                        "( " +
                                            $"{(int)row["Fund_IK"]}, " +
                                            $"{newMainRiskIK}, " +
                                            $"{Convert.ToInt32(row["Major"])}, " + 
                                            "@Today, " +
                                            "@MaxDate " +
                                        ")" +
                                        ";";
                                }
                                RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), false);
                            }
                        }



                    }
                    MessageBox.Show("Saved");
                    this.Close();
                }
            }
        }
        private bool SaveCheck()
        {
            string SQL = 
                "SELECT " +
                    "* " +
                "FROM " +
                    "[Documents].[MainRisk] " +
                "WHERE 1 = 1 " +
                    "AND [Fromdate] <= @EvalDate " +
                    "AND [Todate] > @EvalDate " +
                    $"AND [MainRiskIndex] = {updMainRiskIndex.Value} " +
                    $"AND [MainRiskID] = '{txtMainRiskID.Text}' " +
                    $"AND [MainRiskType] = '{txtMainRiskType.Text}' " +
                    $"AND [MainRiskText] like '{txtMainRisk.Text}' " +
                    $"AND [MainRiskReportingName] = '{txtMainRisk.Text}'";
            var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), true);
            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubRiskForm subRisk = new SubRiskForm(dgvSubRisks.CurrentCell, connectionString, this, readOnly);
            try
            {
                subRisk.Show();
            }
            catch (Exception)
            {
                subRisk = null;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (readOnly) return;
            AddingForm adding = new AddingForm(txtMainRiskID.Text, connectionString);
            adding.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            init();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (readOnly) return;
            try
            {
                string SubRiskID = dgvSubRisks.CurrentCell.OwningColumn.HeaderText;
                int SubRiskIK = (int)dgvSubRisks.CurrentCell.OwningColumn.HeaderCell.Tag;
                var result = MessageBox.Show($"Do you wish to Delete '{SubRiskID}'", $"Delete {SubRiskID}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string SQL = "";
                    SQL =   "UPDATE " +
                                "[Documents].[SubRisk] " +
                            "SET " +
                                "[ToDate] = @Today " +
                            "WHERE 1 = 1 " +
                                $"AND [SubRiskIK] = {SubRiskIK} " +
                                "AND [ToDate] = @MaxDate;" +

                           "UPDATE " +
                                "[Documents].[MainRisk2SubRisk] " +
                            "SET " +
                                "[ToDate] = @Today " +
                            "WHERE 1 = 1 " +
                                $"AND [SubRiskIK] = {SubRiskIK} " +
                                "AND [ToDate] = @MaxDate";
                    RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), false);
                    MessageBox.Show("Deleted");
                }
                init();
            }
            catch (Exception)
            {

            }

        }

        private void addExistingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (readOnly) return;
            ChooseSubRisk subRisk = new ChooseSubRisk(connectionString, this);
            try
            {
                subRisk.Show();
                init();
            }
            catch (Exception)
            {
                subRisk = null;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (readOnly) return;
            if (dtp.Value.Date == DateTime.Today)
            {
                int subRiskIK = 0;

                if (dgvSubRisks.CurrentCell == null || dgvSubRisks.CurrentCell.OwningColumn.Index == -1 || dgvSubRisks.CurrentCell.OwningColumn.HeaderText == "None")
                {
                    return;
                }
                else
                {
                    subRiskIK = (int)dgvSubRisks.CurrentCell.OwningColumn.HeaderCell.Tag;

                    string SQL = 
                            "UPDATE " +
                                "[Documents].[MainRisk2SubRisk] " +
                            "SET " +
                                "[ToDate] = @Today " +
                            " WHERE 1 = 1 " +
                                $"AND [SubRiskIK] = {subRiskIK} " +
                                $"AND [MainRiskIK] = {mainRiskIK} " +
                                "AND [ToDate] = @MaxDate";
                    RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), false);
                    MessageBox.Show("Remove");
                    init();
                }
            }
        }

        private void dgvSubRisks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SubRiskForm subRisk = new SubRiskForm(dgvSubRisks.CurrentCell, connectionString, this, readOnly);
            try
            {
                subRisk.Show();
            }
            catch (Exception)
            {
                subRisk = null;
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            init();
        }
    }
}
