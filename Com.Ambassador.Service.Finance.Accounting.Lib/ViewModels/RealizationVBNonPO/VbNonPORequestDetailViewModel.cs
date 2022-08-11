using Com.Ambassador.Service.Finance.Accounting.Lib;
using System;

namespace Com.Ambassador.Service.Finance.Accounting.WebApi.Controllers.v1.RealizationVBNonPO
{
    public class VbNonPORequestDetailViewModel
    {
        public DateTimeOffset? DateDetail { get; set; }
        public string Remark { get; set; }
        public decimal? Amount { get; set; }
        public bool? isGetPPn { get; set; }
        public bool? isGetPPh { get; set; }
        public IncomeTaxNew IncomeTax { get; set; }
        public string IncomeTaxBy { get; set; }
        public double? Total { get; set; }
    }
}