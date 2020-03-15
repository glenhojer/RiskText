using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskText
{
    public class Dates
    {
        public DateTime FromDate;
        public DateTime ToDate;
        public DateTime MaxDate = DateTime.MaxValue;
        public DateTime Today = DateTime.Today;
        public DateTime EvalDate;
        public Dates(MainRiskForm form)
        {
            EvalDate = form.dtp.Value.Date;
            FromDate = DateTime.Parse(form.lblFromDate.Text);
            ToDate = DateTime.Parse(form.lblToDate.Text);
        }
        public Dates(SubRiskForm form)
        {
            EvalDate = form.dtp.Value.Date;
            FromDate = DateTime.Parse(form.lblFromDate.Text);
            ToDate = DateTime.Parse(form.lblToDate.Text);
        }
        public Dates(RiskTextForm form)
        {
            EvalDate = form.dtp.Value.Date;
            FromDate = DateTime.Parse(form.lblFromDate.Text);
            ToDate = DateTime.Parse(form.lblToDate.Text);
        }
        public Dates()
        {
            EvalDate = DateTime.Today;
            FromDate = DateTime.MaxValue;
            ToDate = DateTime.Today;
        }
    }
}
