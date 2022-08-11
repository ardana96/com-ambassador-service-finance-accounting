using Com.Ambassador.Service.Finance.Accounting.Lib.Utilities.BaseClass;
using Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.MasterCOA;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.GarmentFinance.Memorial
{
    public class GarmentFinanceMemorialItemViewModel : BaseViewModel
    {
        public virtual int MemorialId { get; set; }
        public COAViewModel COA { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
    }
}
