namespace Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.Memo
{
    public class SalesInvoice
    {
        public int? Id { get; set; }
        public string SalesInvoiceNo { get; set; }

        public Buyer Buyer { get; set; }
    }
}