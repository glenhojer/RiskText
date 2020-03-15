using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskText
{
    public partial class SubRiskForm : Form
    {
        string connectionString;
        string subRiskID;
        string subRiskReportingName;
        int subRiskIndex;
        string subRiskText;
        string subRiskType;
        int subRiskIK;
        MainRiskForm form;
        DataGridViewCell dgvCell; 
        public DateTime subRiskTo;
        public DateTime subRiskFrom;
        public DateTime EvalDate;

        public SubRiskForm()
        {

            InitializeComponent();
            txtSubRisk.DeselectAll();
            if (Environment.UserName.ToLower() != RiskTextForm.userID)
            {
                saveToolStripMenuItem.Enabled = false;
            }

        }

        public SubRiskForm(DataGridViewCell _dgvCell, string _connectionString, MainRiskForm _form)
        {
            try
            {
                dgvCell = _dgvCell;
                form = _form;
                connectionString = _connectionString;
                InitializeComponent();

                if (Environment.UserName.ToLower() != RiskTextForm.userID)
                {
                    saveToolStripMenuItem.Enabled = false;
                }
                init();
                Dates dates = new Dates(form);
                this.lblFromDate.Text = dates.FromDate.ToShortDateString();
                lblToDate.Text = dates.ToDate.ToShortDateString();
                dtp.Value = dates.EvalDate;
            }
            catch (Exception)
            {
                return;
            }

        }

        public void init()
        {
            if (dgvCell == null)
            {
                this.Close();
                return;
            }
            subRiskID = dgvCell.OwningColumn.HeaderText;
            subRiskIK = (int)dgvCell.OwningColumn.HeaderCell.Tag;
            this.Text = "Sub risk - " + subRiskID;

            string SQL = $"SELECT " +
                            $"* " +
                        $"FROM " +
                            $"[Documents].[SubRisk] " +
                        $"WHERE 1=1 " +
                            $"AND [SubRiskIK] = {subRiskIK} " +
                            $"AND [FromDate] <= @EvalDate " +
                            $"AND [ToDate] > @EvalDate";

            using (var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(form), true))
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    this.Close();
                    return;
                }

                subRiskReportingName = dt.Rows[0]["SubRiskReportingName"].ToString();
                subRiskType = dt.Rows[0]["SubRiskType"].ToString();
                subRiskIndex = (int)dt.Rows[0]["SubRiskIndex"];
                subRiskText = dt.Rows[0]["SubRiskText"].ToString();
                subRiskTo = (DateTime)dt.Rows[0]["ToDate"];
                subRiskFrom = (DateTime)dt.Rows[0]["FromDate"];
            }

            txtSubRiskID.Text = dgvCell.OwningColumn.HeaderText;
            txtReportingName.Text = subRiskReportingName;
            txtSubRisk.Text = subRiskText;
            txtRiskType.Text = subRiskType;
            updSubRiskIndex.Value = subRiskIndex;
            lblToDate.Text = subRiskTo.ToShortDateString();
            lblFromDate.Text = subRiskFrom.ToShortDateString();
            txtSubRisk.DeselectAll();
            if (dtp.Value.Date != DateTime.Today)
            {
                lblOld.Visible = true;
            }
            else
            {
                lblOld.Visible = false;
            }

        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e) //Ej klar
        {
            if (!SaveCheck())
            {
                string SQL =
                        "DELETE " +
                            "[Documents].[SubRisk] " +
                        "WHERE 1 = 1 " +
                            "AND [FromDate] = @Today " +
                            $"AND [SubRiskIK] = {subRiskIK};" +

                        "UPDATE " +
                            "[Documents].[SubRisk] " +
                        "SET " +
                            "[ToDate] = @Today " +
                        "WHERE 1 = 1 " +
                            $"AND [SubRiskIK] = {subRiskIK} " +
                            "AND [ToDate] = @MaxDate" +
                        ";" +

                        "INSERT INTO " +
                            "[Documents].[SubRisk] " +
                            "( " +
                                "[SubRiskID], " +
                                "[SubRiskText], " +
                                "[SubRiskIndex], " +
                                "[SubRiskType], " +
                                "[SubRiskReportingName], " +
                                "[FromDate], " +
                                "[ToDate]" +
                            ") " +
                        "VALUES " +
                        "( " +
                            $"'{txtSubRiskID.Text}', " +
                            $"'{txtSubRisk.Text}', " +
                            $"{(int)updSubRiskIndex.Value}, " +
                            $"'{txtRiskType.Text}', " +
                            $"'{txtReportingName.Text}', " +
                            "@Today, " +
                            "@MaxDate " +
                        ")" +

                        ";" +

                        $"DELETE " +
                            $"[Documents].[MainRisk2SubRisk] " +
                        $"WHERE 1 = 1 " +
                            $"AND [FromDate] = @Today " +
                            $"AND [SubRiskIK] = {subRiskIK};" +

                        "UPDATE " +
                            "[Documents].[MainRisk2SubRisk] " +
                        "SET " +
                            "[ToDate] = @Today " +
                        "WHERE 1 = 1 " +
                            "AND [ToDate] = @MaxDate " +
                            $"AND [SubRiskIK] = {subRiskIK}" +

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
                            "(" +
                            "SELECT DISTINCT " +
                                "[SubRiskIK] " +
                            "FROM " +
                                "[Documents].[SubRisk] " +
                            "WHERE 1 = 1 " +
                                $"AND [SubRiskID] = '{txtSubRiskID.Text}' " +
                                "AND [ToDate] = @MaxDate" +
                            "), " +
                            $"{form.mainRiskIK}, " +
                            "@Today, " +
                            "@MaxDate " +
                        ")" +
                        ";";

                RiskTextForm.SQLQuery(SQL, connectionString, new Dates(this), false);
                MessageBox.Show("Saved");
                this.Close();
            }
        }

        private bool SaveCheck()
        {
            string SQL =
                "SELECT " +
                    "* " +
                "FROM " +
                    "[Documents].[SubRisk] " +
                "WHERE 1 = 1 " +
                    "AND [Fromdate] <= @EvalDate " +
                    "AND [Todate] > @EvalDate " +
                    $"AND [SubRiskIndex] = {updSubRiskIndex.Value} " +
                    $"AND [SubRiskID] = '{txtSubRiskID.Text}' " +
                    $"AND [SubRiskType] = '{txtRiskType.Text}' " +
                    $"AND [SubRiskText] like '{txtSubRisk.Text}' " +
                    $"AND [SubRiskReportingName] = '{txtSubRisk.Text}'";
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

        private void lblRiskType_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            init();

        }
    }
}
