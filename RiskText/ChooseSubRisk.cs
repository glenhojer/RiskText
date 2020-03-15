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
    public partial class ChooseSubRisk : Form
    {
        string connectionString;
        MainRiskForm form;

        public ChooseSubRisk(string _connectionString, MainRiskForm _form)
        {
            connectionString = _connectionString;
            form = _form;
            InitializeComponent();
            string SQL =    "Select " +
                                "* " +
                            "FROM " +
                                "[Documents].[SubRisk] " +
                            "WHERE 1=1" +
                                "AND [ToDate] > @EvalDate " +
                                "AND [FromDate] <= @EvalDate";
            using(var dt = RiskTextForm.SQLQuery(SQL, connectionString, new Dates(form), true))
            {
                foreach(DataRow row in dt.Rows)
                {
                    int rowIndex = dgvSubrisks.Rows.Add();
                    dgvSubrisks.Rows[rowIndex].Cells["SubRiskID"].Value = row["SubRiskID"].ToString();
                    dgvSubrisks.Rows[rowIndex].Cells["SubRiskIK"].Value = row["SubRiskIK"].ToString();
                    dgvSubrisks.Rows[rowIndex].Cells["SubRiskType"].Value = row["SubRiskType"].ToString();

                }
            }
        }

        private void dgvSubrisks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dgvSubrisks.CurrentCell.OwningRow.Index;
            int MIK = form.mainRiskIK;
            int SIK = int.Parse(dgvSubrisks.Rows[i].Cells["SubRiskIK"].Value.ToString());

            string SQL;
            SQL = $"INSERT INTO " +
                    $"Documents.MainRisk2SubRisk " +
                    $"( " +
                        $"[MainRiskIK], " +
                        $"[SubRiskIK], " +
                        $"[FromDate], " +
                        $"[ToDate] " +
                    $") " +
                    $"VALUES " +
                    $"( " +
                        $"{MIK}, " +
                        $"{SIK}, " +
                        $"@Today, " +
                        $"@MaxDate " +
                    $")";
            RiskTextForm.SQLQuery(SQL, connectionString, new Dates(form), true);
            this.Close();
        }
    }
}
