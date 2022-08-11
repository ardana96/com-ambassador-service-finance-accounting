using Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.VBStatusReport;
using iTextSharp.text;
using System.Collections.Generic;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.BusinessLogic.Interfaces.VBStatusReport
{
    public class ReportViewModel
    {
        public List<VBStatusReportViewModel> VBStatusReport { get; set; }
        public List<VBStatusByCurrencyReportViewModel> VBStatusByCurrencyReport { get; set; }
    }
}