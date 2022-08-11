using Com.Ambassador.Service.Finance.Accounting.Lib.Utilities.BaseClass;
using Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.GarmentFinance.BankCashReceiptDetail
{
    public class BankCashReceiptDetailOtherItemViewModel : BaseViewModel
    {
        public ChartOfAccountViewModel Account { get; set; }
        public CurrencyViewModel Currency { get; set; }
        public decimal Amount { get; set; }
        public string TypeAmount { get; set; }
        public string Remarks { get; set; }
    }
}
