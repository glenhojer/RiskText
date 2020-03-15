using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace RiskText
{
    public partial class RiskTextForm : Form
    {

        //public static string connectionString = @"Server=TD0543\TDSQL0543;Database=DBDJB051_01_JCRiskManDB;User Id=JI8227;Password=QF9XyjmB;";
        public static string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True";
        public string connectionStringOracle = "Data Source=PROD;User Id=RISK01;Password=gRisk18;";
        //public static string userID = "ji8227"; //burde nok have noget mere dynamisk
        public static string userID = "glen"; //burde nok have noget mere dynamisk


        public RiskTextForm()
        {
            InitializeComponent();
            string SQL =    "SELECT DISTINCT " +
                                "[Fund_Owner_Name] " +
                            "FROM " +
                                "[Foundation].[Funds] " +
                            "ORDER BY " +
                                "[Fund_Owner_Name], [DisplayOrder] ASC;";
            using (var dtForening = SQLQuery(SQL, connectionString, new Dates(this), true))
            {
                if (dtForening == null || dtForening.Rows.Count == 0)
                {
                }
                else
                {
                    cboForening.Items.Add("All");
                    foreach (DataRow rowPort in dtForening.Rows)
                    {
                        cboForening.Items.Add(rowPort["Fund_Owner_Name"].ToString());
                    }
                }
            }
            cboForening.Text = "All";
            init(cboForening.Text);
            dgvRisks.CurrentCell = null;
            if (Environment.UserName.ToLower() != userID)
            {
                deleteToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                addToolStripMenuItem.Enabled = false;
            }
        }

        private void init(string Forening)
        {
            dgvRisks.Rows.Clear();
            dgvRisks.Columns.Clear();
            dgvRisks.AllowUserToAddRows = false;
            string SQL;
            SQL =   "SELECT " +
                        "* " +
                    "FROM " +
                        "[Documents].[MainRisk] " +
                    "WHERE 1=1 " +
                        "AND [FromDate] <= @EvalDate " +
                        "AND [ToDate] > @EvalDate " +
                    "ORDER BY " +
                        "[MainRiskIndex] ASC";
            using (var dtMainRisk = SQLQuery(SQL, connectionString, new Dates(this), true))
            {
                DataGridViewCheckBoxColumn dgvCol;
                if (dtMainRisk == null || dtMainRisk.Rows.Count == 0)
                {
                    dgvCol = new DataGridViewCheckBoxColumn();
                    dgvCol.HeaderText = "No Risks";
                    dgvCol.HeaderCell.Tag = 0;
                    dgvCol.FlatStyle = FlatStyle.Flat;
                    dgvRisks.Columns.Add(dgvCol);
                }
                else
                {
                    foreach (DataRow row in dtMainRisk.Rows)
                    {
                        dgvCol = new DataGridViewCheckBoxColumn();
                        dgvCol.HeaderText = row["MainRiskID"].ToString();
                        dgvCol.HeaderCell.Tag = (int)row["MainRiskIK"];
                        dgvCol.FlatStyle = FlatStyle.Flat;
                        dgvCol.TrueValue = 1;
                        dgvCol.FalseValue = 0;
                        dgvRisks.Columns.Add(dgvCol);
                    }
                }
            }

            if(Forening == "All")
            {
                SQL =   "SELECT " +
                            "[Fund_IK], " +
                            "[Fund], " +
                            "[Fund_Name], " +
                            "[Fund_Owner_Name] " +
                        "FROM " +
                            "[Foundation].[Funds] " +
                        "ORDER BY " +
                            "[DISPLAY_ORDER_OFFICIAL] ASC;";
            }
            else
            {
                SQL =   $"SELECT " +
                            $"[Fund_IK], " +
                            $"[Fund], " +
                            $"[Fund_Name], " +
                            $"[Fund_Owner_Name] " +
                        $"FROM " +
                            $"[Foundation].[Funds] " +
                        $"WHERE " +
                            $"[Fund_Owner_Name] = '{Forening}' " +
                        $"ORDER BY " +
                            $"[DISPLAY_ORDER_OFFICIAL] ASC;";
            }

            using (var dtFunds = SQLQuery(SQL, connectionString, new Dates(this), true))
            {
                int i = 0;

                if (dtFunds == null || dtFunds.Rows.Count == 0)
                {
                    dgvRisks.Rows.Add();
                    dgvRisks.Rows[0].HeaderCell.Value = "No Funds";
                }
                else
                {
                    foreach (DataRow rowPort in dtFunds.Rows)
                    {
                        i++;
                        dgvRisks.Rows.Add();
                        dgvRisks.Rows[i - 1].HeaderCell.Value = rowPort["Fund_Name"].ToString();
                        dgvRisks.Rows[i - 1].HeaderCell.Tag = (int)rowPort["Fund_IK"];
                        dgvRisks.Rows[i - 1].HeaderCell.ToolTipText = rowPort["Fund"].ToString();
                    }
                }

                if (dtFunds == null || dtFunds.Rows.Count == 0)
                {

                }
                else
                {
                    SQL =   "SELECT " +
                                "[F].[FUND_IK] as [FUND_IK], " +
                                "[MR].[MainRiskID] as [MainRiskID], " +
                                "[F2MR].[Major] as [Major] " +
                            "FROM " +
                                "[Foundation].[Funds] as [F] " +
                                "LEFT JOIN " +
                                    "[Documents].[Fund2MainRisk] as [F2MR] " +
                                        "ON [F].[Fund_IK] = [F2MR].[Fund_IK] " +
                                        "INNER JOIN " +
                                            "[Documents].[MainRisk] as [MR] " +
                                                "ON [F2MR].[MainRiskIK] = [MR].[MainRiskIK] " +
                            "WHERE 1 = 1 " +
                                $"AND [MR].[FromDate] <= @EvalDate " +
                                $"AND [F2MR].[FromDate] <= @EvalDate " +
                                $"AND [MR].[ToDate] > @EvalDate " +
                                $"AND [F2MR].[ToDate] > @EvalDate";

                    using (var dtfund2MR = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), true))
                    {
                        foreach (DataGridViewRow r in dgvRisks.Rows)
                        {
                            DataRow[] result;
                            foreach (DataGridViewCell c in r.Cells)
                            {
                                if(c.OwningColumn.HeaderText == "No Funds")
                                {
                                    break;
                                }
                                result = dtfund2MR.Select($"FUND_IK = {(int)c.OwningRow.HeaderCell.Tag} AND MainRiskID = '{c.OwningColumn.HeaderText}'");
                                if (result.LongCount() != 0)
                                {
                                    c.Value = 1;
                                    c.Style.ForeColor = SystemColors.ControlLightLight;
                                    c.Tag = result[0]["Major"];

                                    c.Style.BackColor = SystemColors.ControlDarkDark;
                                    if ((bool)result[0]["Major"])
                                    {
                                        c.Style.BackColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    c.Value = 0;
                                    c.Tag = false;
                                }
                            }
                        }
                    }
 
                }
                dgvRisks.CurrentCell = null;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRiskForm mainRisk = new MainRiskForm(dgvRisks.CurrentCell, connectionString, dtp.Value.Date);
            mainRisk.Show();  
        }

        #region SQL
        public static DataTable SQLQuery(string SQL, string connectionString, Dates dates, bool returnDT)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCmd = new SqlCommand(SQL, sqlConnection))
                {
                    sqlCmd.Parameters.Add("@MaxDate", SqlDbType.DateTime).Value = dates.MaxDate;
                    sqlCmd.Parameters.Add("@EvalDate", SqlDbType.DateTime).Value = dates.EvalDate;
                    sqlCmd.Parameters.Add("@Today", SqlDbType.DateTime).Value = dates.Today;
                    sqlCmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dates.FromDate;
                    sqlCmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dates.ToDate;


                    sqlConnection.Open();
                    try
                    {
                        if (returnDT)
                        {
                            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                            dt.Load(sqlDataReader);
                        }
                        else
                        {
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message + "\n\n" + SQL, "GeneralQuery", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlConnection.Close();
                    }

                }
            }
            return dt;

        }
        #endregion

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingForm adding = new AddingForm("MainRisk", connectionString);
            adding.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            init(cboForening.Text);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //Ej Klar!!!
        {
            string MainRiskID = dgvRisks.CurrentCell.OwningColumn.HeaderText;
            int MainRiskIK;
            var result = MessageBox.Show($"Do you wish to Delete '{MainRiskID}'", $"Delete {MainRiskID}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                MainRiskIK = (int)dgvRisks.CurrentCell.OwningColumn.HeaderCell.Tag;

                string SQL =
                    $"UPDATE " +
                        $"[Documents].[MainRisk] " +
                    "SET " +
                        "[ToDate] = @Today " +
                    $"WHERE 1 = 1" +
                        $"AND [MainRiskIK] = {MainRiskIK} " +
                        $"AND [ToDate] = @MaxDate " +
                        
                    $";" +

                    $"UPDATE " +
                        $"[Documents].[MainRisk2SubRisk] " +
                    "SET " +
                        "[ToDate] = @Today " +
                    $"WHERE 1 = 1" +
                        $"AND [MainRiskIK] = {MainRiskIK} " +
                        $"AND [ToDate] = @MaxDate ";
                SQLQuery(SQL, connectionString, new Dates(this), false);
                MessageBox.Show("Deleted");
            }
            init(cboForening.Text);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)  //Done
        {

            string SQL = ""; ;
            var dates = new Dates(this);

            dgvRisks.CurrentCell = null;
            foreach (DataGridViewRow r in dgvRisks.Rows)
            {
                foreach (DataGridViewCheckBoxCell c in r.Cells)
                {
                    if (!SaveCheck(c))
                    {
                        Color color = c.Style.BackColor;

                        int MainRiskIK = (int)c.OwningColumn.HeaderCell.Tag;

                        if ((int)c.Value == 1)
                        {
                            SQL = 
                                $"DELETE " +
                                    $"[Documents].[Fund2MainRisk] " +
                                $"WHERE " +
                                    $"[FromDate] = @Today;" +

                                $"UPDATE " +
                                    $"[Documents].[Fund2MainRisk] " +
                                $"SET " +
                                    $"[ToDate] = @Today " +
                                $"WHERE " +
                                    $"[ToDate] = @MaxDate; " +
                               
                                $"INSERT INTO Documents.Fund2MainRisk " +
                                $"(" +
                                    $" [Fund_IK]," +
                                    $" [MainRiskIK]," +
                                    $" [Major]," +
                                    $" [FromDate]," +
                                    $" [ToDate]" +
                                $") " +
                                $"VALUES " +
                                $"(" +
                                    $" {(int)c.OwningRow.HeaderCell.Tag}," +
                                    $" {MainRiskIK}," +
                                    $" {Convert.ToInt32(c.Tag)}," +
                                    $" @Today," +
                                    $" @MaxDate" +
                                $")";
                        }
                        SQLQuery(SQL, connectionString, dates, false);
                    }
                }
            }
        }

        private bool SaveCheck(DataGridViewCheckBoxCell cell)
        {
            string SQL = "SELECT " +
                                "* " +
                            "FROM " +
                                "[Documents].[Fund2MainRisk] " +
                            "WHERE 1 = 1 " +
                                "AND [Fromdate] <= @EvalDate " +
                                "AND [Todate] > @EvalDate " +
                                $"AND [Fund_IK] = {(int)cell.OwningRow.HeaderCell.Tag} " +
                                $"AND [MainRiskIK] = {(int)cell.OwningColumn.HeaderCell.Tag} " +
                                $"AND [Major] = {Convert.ToInt32(cell.Tag)}";
            var dt = SQLQuery(SQL, connectionString, new Dates(this), true);
            if(dt == null || dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dgvRisks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainRiskForm mainRisk = new MainRiskForm(dgvRisks.CurrentCell, connectionString, dtp.Value.Date);
            try
            {
                mainRisk.Show();
            }
            catch (Exception)
            { }

        }

        private void cboForening_SelectedIndexChanged(object sender, EventArgs e)
        {
            init(cboForening.Text);
        }

        private void prospectusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateDocument(this);
        }

        private void makeMajorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRisks.CurrentCell.Tag == null || !(bool)dgvRisks.CurrentCell.Tag)
            {
                dgvRisks.CurrentCell.Tag = true;
                dgvRisks.CurrentCell.Style.BackColor = Color.Black;
            }
            else
            {
                dgvRisks.CurrentCell.Tag = false;
                dgvRisks.CurrentCell.Style.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void contextMenuDataGridView_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                makeMajorToolStripMenuItem.Checked = (bool)dgvRisks.CurrentCell.Tag;
            }
            catch (Exception)
            {   }

        }

        private void tableDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtraForm extraRisk = new ExtraForm(dgvRisks.CurrentCell, connectionString);
            try
            {
                extraRisk.Show();
            }
            catch (Exception)
            {
            }
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "DELETE ALL - Watch out!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                if(MessageBox.Show("Are you still sure?", "DELETE ALL - Watch out!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    string SQL =
                        "DROP TABLE [Documents].[Fund2MainRisk]; " +
                        "DROP TABLE [Documents].[MainRisk]; " +
                        "DROP TABLE [Documents].[MainRisk2SubRisk]; " +
                        "DROP TABLE [Documents].[SubRisk]; ";
                    SQLQuery(SQL, connectionString, new Dates(this), false);
                }
            }
        }

        private void deleteAboveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", $"DELETE [{toolStripComboBoxDelete.Text}] Watch out!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                if (MessageBox.Show("Are you still sure?", "Watch out!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    string SQL =
                        $"DROP TABLE [Documents].[{toolStripComboBoxDelete}]";
                    SQLQuery(SQL, connectionString, new Dates(this), false);
                }

            }
        }

        private void rebuildAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "rebuild ALL - Watch out!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                if (MessageBox.Show("Are you still sure?", "Create ALL - Watch out!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    string SQL =
                        " CREATE TABLE [Documents].[Fund2MainRisk]" +
                        "(" +
                            " [Fund2MainRiskIK] [int] IDENTITY(1,1) NOT NULL," +
                            " [Fund_IK] [int] NOT NULL," +
                            " [MainRiskIK] [int] NOT NULL," +
                            " [Major] [bit] NOT NULL," +
                            " [ToDate] [datetime] NOT NULL," +
                            " [FromDate] [datetime] NOT NULL" +
                        ")";
                    SQLQuery(SQL, connectionString, new Dates(this), false);

                    SQL =
                        "CREATE TABLE[Documents].[MainRisk]" +
                        "(" +
                            " [MainRiskIK] [int] IDENTITY(1,1) NOT NULL," +
                            " [MainRiskIndex] [int] NULL," +
                            " [MainRiskID] [nvarchar] (50) NOT NULL," +
                            " [MainRiskType] [nvarchar] (50) NULL," +
                            " [MainRiskText] [text] NULL," +
                            " [MainRiskReportingName] [nvarchar] (200) NULL," +
                            " [ToDate] [datetime] NOT NULL," +
                            " [FromDate] [datetime] NOT NULL" +
                        ")";
                    SQLQuery(SQL, connectionString, new Dates(this), false);

                    SQL =
                        "CREATE TABLE[Documents].[MainRisk2SubRisk]" +
                        "(" +
                            " [MainRisk2SubRiskIK] [int] IDENTITY(1,1) NOT NULL," +
                            " [MainRiskIK] [int] NOT NULL," +
                            " [SubRiskIK] [int] NOT NULL," +
                            " [ToDate] [datetime] NOT NULL," +
                            " [FromDate] [datetime] NOT NULL" +
                        ")";
                    SQLQuery(SQL, connectionString, new Dates(this), false);

                    SQL =
                        "CREATE TABLE[Documents].[SubRisk]" +
                        "(" +
                            " [SubRiskIK] [int] IDENTITY(1,1) NOT NULL," +
                            " [SubRiskIndex] [int] NULL," +
                            " [SubRiskID] [nvarchar] (50) NOT NULL," +
                            " [SubRiskType] [nvarchar] (50) NULL," +
                            " [SubRiskText] [text] NULL," +
                            " [SubRiskReportingName] [nvarchar] (200) NULL," +
                            " [ToDate] [datetime] NOT NULL," +
                            " [FromDate] [datetime] NOT NULL" +
                        ")";
                    SQLQuery(SQL, connectionString, new Dates(this), false);
                    ;
                }
            }
        }

        private void rebuildAboveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", $"Rebuild [{toolStripComboBoxRebuild.Text}] - Watch out!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                if (MessageBox.Show("Are you still sure?", "Create ALL - Watch out!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    string SQL;
                    switch (toolStripComboBoxRebuild.Text)
                    { 
                        case "Fund2MainRisk":
                            SQL = 
                            "CREATE TABLE [Documents].[Fund2MainRisk]" +
                            "(" +
                                " [Fund2MainRiskIK] [int] IDENTITY(1,1) NOT NULL," +
                                " [Fund_IK] [int] NOT NULL," +
                                " [MainRiskIK] [int] NOT NULL," +
                                " [Major] [bit] NOT NULL," +
                                " [ToDate] [datetime] NOT NULL," +
                                " [FromDate] [datetime] NOT NULL" +
                            ")";
                            SQLQuery(SQL, connectionString, new Dates(this), false);
                            break;
                        case "MainRisk":
                            SQL =
                            "CREATE TABLE[Documents].[MainRisk]" +
                            "(" +
                                " [MainRiskIK] [int] IDENTITY(1,1) NOT NULL," +
                                " [MainRiskIndex] [int] NULL," +
                                " [MainRiskID] [nvarchar] (50) NOT NULL," +
                                " [MainRiskType] [nvarchar] (50) NULL," +
                                " [MainRiskText] [text] NULL," +
                                " [MainRiskReportingName] [nvarchar] (200) NULL," +
                                " [ToDate] [datetime] NOT NULL," +
                                " [FromDate] [datetime] NOT NULL" +
                            ")";
                            SQLQuery(SQL, connectionString, new Dates(this), false);
                            break;
                        case "MainRisk2SubRisk":
                            SQL =
                            "CREATE TABLE[Documents].[MainRisk2SubRisk]" +
                            "(" +
                                " [MainRisk2SubRiskIK] [int] IDENTITY(1,1) NOT NULL," +
                                " [MainRiskIK] [int] NOT NULL," +
                                " [SubRiskIK] [int] NOT NULL," +
                                " [ToDate] [datetime] NOT NULL," +
                                " [FromDate] [datetime] NOT NULL" +
                            ")";
                            SQLQuery(SQL, connectionString, new Dates(this), false);
                            break;
                        case "SubRisk":
                            SQL =
                            "CREATE TABLE[Documents].[SubRisk]" +
                            "(" +
                                " [SubRiskIK] [int] IDENTITY(1,1) NOT NULL," +
                                " [SubRiskIndex] [int] NULL," +
                                " [SubRiskID] [nvarchar] (50) NOT NULL," +
                                " [SubRiskType] [nvarchar] (50) NULL," +
                                " [SubRiskText] [text] NULL," +
                                " [SubRiskReportingName] [nvarchar] (200) NULL," +
                                " [ToDate] [datetime] NOT NULL," +
                                " [FromDate] [datetime] NOT NULL" +
                            ")";
                            SQLQuery(SQL, connectionString, new Dates(this), false);

                            break;

                        default:
                            break;
                    }
                }
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            init(cboForening.Text);
        }
    }
}
