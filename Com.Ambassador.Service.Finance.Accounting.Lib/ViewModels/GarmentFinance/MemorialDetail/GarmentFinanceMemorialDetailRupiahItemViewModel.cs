using Com.Ambassador.Service.Finance.Accounting.Lib.Utilities.BaseClass;
using Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.GarmentFinance.MemorialDetail
{
    public class GarmentFinanceMemorialDetailRupiahItemViewModel : BaseViewModel
    {
        public ChartOfAccountViewModel Account { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
