using Com.Ambassador.Service.Finance.Accounting.Lib.Utilities.BaseClass;
using Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.GarmentFinance.BankCashReceiptDetailLocal
{
    public class GarmentFinanceBankCashReceiptDetailLocalOtherItemViewModel : BaseViewModel
    {
        public ChartOfAccountViewModel Account { get; set; }
        public CurrencyViewModel Currency { get; set; }
        public decimal Amount { get; set; }
        public string TypeAmount { get; set; }
        public string Remarks { get; set; }
    }
}