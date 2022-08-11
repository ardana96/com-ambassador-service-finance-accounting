using Com.Ambassador.Service.Finance.Accounting.Lib.Models.GarmentFinance.BankCashReceiptDetail;
using Com.Ambassador.Service.Finance.Accounting.Lib.Utilities.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.BusinessLogic.Interfaces.GarmentFinance.BankCashReceiptDetail
{
    public interface IBankCashReceiptDetailService : IBaseService<BankCashReceiptDetailModel>
    {
        double GetAmountByInvoiceId(int invoiceId);
    }
}
