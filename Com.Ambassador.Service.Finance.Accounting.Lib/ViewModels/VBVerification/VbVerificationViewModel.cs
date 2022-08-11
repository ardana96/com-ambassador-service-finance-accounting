using Com.Ambassador.Service.Finance.Accounting.Lib.Utilities.BaseClass;
using Com.Ambassador.Service.Finance.Accounting.WebApi.Controllers.v1.RealizationVBNonPO;
using System;

namespace Com.Ambassador.Service.Finance.Accounting.Lib
{
    public class VbVerificationViewModel
    {
        public NumberVBData numberVB { get; set; }
        public string Reason { get; set; }
        public string Remark { get; set; }
        public DateTimeOffset? VerifyDate { get; set; }
        public bool isNotVeridied { get; set; }
        public bool isVerified { get; set; }
    }
}