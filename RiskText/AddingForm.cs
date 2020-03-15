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
    public partial class AddingForm : Form
    {
        string parent;
        string connectionString;

        
        public AddingForm(string _parent, string _connectionString)
        {
            parent = _parent;
            connectionString = _connectionString;
            InitializeComponent();
            txtParent.Enabled = true;
            if (parent == "MainRisk")
            {
                grpRisk.Text = "Main Risk";
                txtParent.Text = "Main";
                this.Text = "Main Risk - Add";
            }
            else
            {
                grpRisk.Text = "Sub Risk";
                txtParent.Text = parent;
                txtParent.Enabled = false;
                this.Text = parent + " - Add";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string SQL;
            int SubRiskIK;
            int MainRiskIK;

            if (parent == "MainRisk")
            {
                SQL =   $"SELECT " +
                            $"* " +
                        $"FROM " +
                            $"[Documents].[MainRisk] " +
                        $"WHERE 1 = 1 " +
                            $"AND [MainRiskID] = '{txtRiskName.Text}' " +
                            $"AND [ToDate] = @MaxDate";

                var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(), true);

                if(dt == null || dt.Rows.Count == 0)
                {
                    SQL =   "INSERT INTO " +
                                "[Documents].[MainRisk] " +
                                "(" +
                                    "[MainRiskID], " +
                                    "[MainRiskIndex], " +
                                    "[MainRiskText], " +
                                    "[MainRiskType], " +
                                    "[MainRiskReportingName], " +
                                    "[FromDate], " +
                                    "[ToDate]" +
                                ") " +
                            $"VALUES " +
                                $"(" +
                                    $"'{txtRiskName.Text}', " +
                                    $"{(int)updIndex.Value}, " +
                                    $"'{txtText.Text}', " +
                                    $"'{txtRiskType.Text}', " +
                                    $"'{txtReportingName.Text}', " +
                                    $"@Today, " +
                                    $"@MaxDate" +
                                $")";
                }
                else
                {
                    MessageBox.Show("Already exits ... Not saved");
                    return;
                }
            }
            else
            {
                SQL =   $"SELECT " +
                            $"* " +
                        $"FROM " +
                            $"[Documents].[SubRisk] " +
                        $"WHERE 1 = 1" +
                            $"AND [SubRiskID] = '{txtRiskName.Text}' " +
                            $"AND [ToDate] = @MaxDate";

                var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(), true);

                if (dt == null || dt.Rows.Count == 0)
                {
                    SQL =   "INSERT INTO " +
                                "[Documents].[SubRisk] " +
                                "(" +
                                    "[SubRiskID], " +
                                    "[SubRiskIndex], " +
                                    "[SubRiskType], " +
                                    "[SubRiskText], " +
                                    "[SubRiskReportingName], " +
                                    "[FromDate], " +
                                    "[ToDate]" +
                                ") " +
                            $"VALUES " +
                                $"(" +
                                    $"'{txtRiskName.Text}', " +
                                    $" {(int)updIndex.Value}, " +
                                    $"'{txtRiskType.Text}', " +
                                    $"'{txtText.Text}', " +
                                    $"'{txtReportingName.Text}', " +
                                    $"@Today, " +
                                    $"@MaxDate " +
                                 $")";
                }
                else
                {
                    MessageBox.Show("Already exits ... Not saved");
                    return;
                }
            }
            RiskTextForm.SQLQuery(SQL, connectionString, new Dates(), false);

            if(parent != "MainRisk")
            {
                SQL = $"Select " +
                            $"[SubRiskIK] " +
                        $"FROM " +
                            $"[Documents].[SubRisk] " +
                        $"WHERE 1=1 " +
                            $"AND [SubRiskID] = '{txtRiskName.Text}' " +
                            $"AND [ToDate] = @MaxDate";
                using (var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(), true))
                {
                    SubRiskIK = (int)dt.Rows[0][0];
                }

                SQL =   $"Select " +
                            $"[MainRiskIK] " +
                        $"FROM " +
                            $"[Documents].[MainRisk] " +
                        $"WHERE 1=1 " +
                            $"AND [MainRiskID] = '{txtParent.Text}' " +
                            $"AND [ToDate] = @MaxDate";
                using (var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(), true))
                {
                    MainRiskIK = (int)dt.Rows[0][0];
                }

                SQL = "INSERT INTO " +
                        "[Documents].[MainRisk2SubRisk] " +
                        "(" +
                            "[MainRiskIK], " +
                            "[SubRiskIK], " +
                            "[FromDate], " +
                            "[ToDate]" +
                        ") " +
                    "VALUES " +
                        "(" +
                            $"'{MainRiskIK}', " +
                            $"'{SubRiskIK}', " +
                            $"@Today, " +
                            $"@MaxDate" +
                        ")";
                RiskTextForm.SQLQuery(SQL, connectionString, new Dates(), false);

            }
            MessageBox.Show("Saved");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
