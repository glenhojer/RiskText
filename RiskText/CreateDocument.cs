using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace RiskText
{
    class CreateDocument
    {
        RiskTextForm form;
        word.Application wordApp = new word.Application();
        word.Document wordDoc = new word.Document();
        public CreateDocument(RiskTextForm _form)
        {
            form = _form;
            wordApp.ShowAnimation = false;
            wordApp.Visible = true;
            wordDoc = wordApp.Documents.Add();
            if (form.cboForening.Text != "All")
            {
                tables(form);
            }
            texts();
        }

        private void texts()
        {
            string SQL;
            SQL =       "Select " +
                            "* " +
                        "FROM " +
                            "[Documents].[MainRisk] " +
                        "WHERE 1 = 1 " +
                            "AND [FromDate] <= @EvalDate " +
                            "AND [ToDate] > @EvalDate " + 
                        "ORDER BY " +
                            "[MainRiskIndex] ASC";
            using (var dtMain = RiskTextForm.SQLQuery(SQL, RiskTextForm.connectionString, new Dates(form), true))
            {
                foreach (DataRow rMain in dtMain.Rows)
                {
                    wordDoc.Paragraphs.SpaceAfter = 0;
                    var mainRiskHeader = wordDoc.Paragraphs.Add();
                    if (mainRiskHeader.Format.LeftIndent == 20)
                    {
                        mainRiskHeader.Format.LeftIndent = -20;
                    }
                    mainRiskHeader.Range.Underline = word.WdUnderline.wdUnderlineSingle;
                    mainRiskHeader.Range.Font.Name = "garamond";
                    mainRiskHeader.Range.Font.Size = 11;
                    mainRiskHeader.Range.Text = rMain["MainRiskReportingName"].ToString() + Environment.NewLine;
                    mainRiskHeader = null;

                    var mainRiskText = wordDoc.Paragraphs.Add();
                    mainRiskText.Range.Font.Name = "garamond";
                    mainRiskText.Range.Font.Size = 11;
                    mainRiskText.Range.Text = rMain["MainRiskText"] + Environment.NewLine;
                    mainRiskText.Format.LeftIndent = 20;

                    SQL =   "SELECT " +
                                "* " +
                            "FROM " +
                                "[Documents].[SubRisk] as [SR], " +
                                "[Documents].[MainRisk2SubRisk] as [MR2SR] " +
                            "WHERE 1=1 " +
                                "AND [SR].[SubRiskIK] = [MR2SR].[SubriskIK] " +
                                $"AND [MR2SR].[MainRiskIK] = {(int)rMain["MainRiskIK"]} " +
                                "AND [SR].[FromDate] <= @EvalDate " +
                                "AND [SR].[ToDate] > @EvalDate " +
                                "AND [MR2SR].[FromDate] <= @EvalDate " +
                                "AND [MR2SR].[ToDate] > @EvalDate " +

                            "ORDER BY " +
                                "[SubRiskIndex] ASC";
                    using (var dtSub = RiskTextForm.SQLQuery(SQL, RiskTextForm.connectionString, new Dates(form), true))
                    {
                        foreach (DataRow rSub in dtSub.Rows)
                        {

                            var subRiskHeader = wordDoc.Paragraphs.Add();
                            subRiskHeader.Range.Italic = 1;
                            subRiskHeader.Range.Font.Name = "garamond";
                            subRiskHeader.Range.Font.Size = 11;
                            subRiskHeader.Range.Text = Environment.NewLine + rSub["SubRiskReportingName"].ToString() + Environment.NewLine;
                            subRiskHeader.Format.LeftIndent = 20;
                            subRiskHeader = null;

                            var subRiskText = wordDoc.Paragraphs.Add();
                            subRiskText.Format.SpaceBeforeAuto = 0;
                            subRiskText.Format.SpaceBefore = 0;
                            subRiskText.Format.SpaceAfterAuto = 0;
                            subRiskText.Format.SpaceAfter = 10;

                            subRiskText.Range.Font.Name = "garamond";
                            subRiskText.Range.Font.Size = 11;
                            subRiskText.Range.Text = rSub["SubRiskText"] + Environment.NewLine;
                        }
                        mainRiskText.Format.LeftIndent = 0;
                        mainRiskText.Range.Text = mainRiskText.Range.Text;
                        mainRiskText = null;
                    }
                }
            }
        }

        private void tables(RiskTextForm form)
        {
            int fundCount = form.dgvRisks.Rows.Count + 1;
            int riskCount = form.dgvRisks.Columns.Count + 1;

            int textHeight;
            int textLength;
            var Table = wordDoc.Paragraphs.Add();
            wordDoc.Tables.Add(Table.Range, fundCount, riskCount);
            var wordTable = wordDoc.Tables[1];
            wordTable.Range.Font.Size = 10;
            wordTable.Range.Font.Name = "garamond";
            wordTable.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            wordTable.Range.Cells.VerticalAlignment = word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

            int i = 0;
            int maxHeight = 0;        

            foreach (DataGridViewColumn col in form.dgvRisks.Columns)
            {
                //wordTable.Cell(1, col.Index + 2).Range.Text = col.HeaderText;
                string SQL = $"SELECT" +
                                $" [MainRiskReportingName] " +
                            $"FROM " +
                                $"[Documents].[MainRisk]" +
                            $"WHERE 1=1 " +
                                $"AND MainRiskIK = {col.HeaderCell.Tag}" +
                                $"AND [FromDate] <= @EvalDate " +
                                $"AND [ToDate] > @EvalDate"
                                ;

                using(var dt = RiskTextForm.SQLQuery(SQL, RiskTextForm.connectionString, new Dates(form), true))
                {
                    wordTable.Cell(1, col.Index + 2).Range.Text = dt.Rows[0][0].ToString();
                }

                wordTable.Cell(1, col.Index + 2).Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
                wordTable.Cell(1, col.Index + 2).Range.Orientation = word.WdTextOrientation.wdTextOrientationUpward;
                wordTable.Cell(1, col.Index + 2).Range.Font.Bold = 1;

                textHeight = TextRenderer.MeasureText(wordTable.Cell(1, col.Index + 2).Range.Text, new System.Drawing.Font(wordTable.Range.Font.Name, 8)).Width;
                if (textHeight > maxHeight)
                {
                    maxHeight = textHeight;
                }
            }
            int maxWidth = 0;
            foreach (DataGridViewRow row in form.dgvRisks.Rows)
            {
                wordTable.Cell(row.Index + 2, 1).Range.Text = row.HeaderCell.Value.ToString();
                wordTable.Cell(row.Index + 2, 1).Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
                wordTable.Cell(row.Index + 2, 1).Range.Font.Bold = 1;

                textLength = TextRenderer.MeasureText(wordTable.Cell(row.Index + 2, 1).Range.Text, new System.Drawing.Font(wordTable.Range.Font.Name, 8)).Width;

                if (textLength > maxWidth)
                {
                    maxWidth = textLength;
                }

                foreach (DataGridViewColumn col in form.dgvRisks.Columns)
                {
                    switch (form.dgvRisks.Rows[row.Index].Cells[col.Index].Value.ToString())
                    {
                        case "1":
                            if ((bool)form.dgvRisks.Rows[row.Index].Cells[col.Index].Tag)
                            {
                                wordTable.Cell(row.Index + 2, col.Index + 2).Range.Text = "\u25CF";
                                //wordTable.Cell(row.Index + 2, col.Index + 2).Range.Bold = 1;
                            }
                            else
                            {
                                wordTable.Cell(row.Index + 2, col.Index + 2).Range.Text = "\u25CB";

                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            wordTable.Range.Cells.Borders.Enable = 1;
            wordTable.Rows[1].Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordTable.Rows[1].Cells.Height = maxHeight;
            wordTable.Range.Cells.Width = TextRenderer.MeasureText("xx", new System.Drawing.Font(wordTable.Range.Font.Name, 8)).Width;
            wordTable.Columns[1].Cells.Width = maxWidth;

            wordTable.Cell(1, 1).Range.Text = "Afdeling\n";
            wordTable.Cell(1, 1).Range.Bold = 1;
            wordTable.Cell(1, 1).Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            wordTable.Cell(1, 1).Range.Cells.VerticalAlignment = word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
        }
    }
}

