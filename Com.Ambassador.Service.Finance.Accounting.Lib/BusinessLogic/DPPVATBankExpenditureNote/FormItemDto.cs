namespace Com.Ambassador.Service.Finance.Accounting.Lib.BusinessLogic.DPPVATBankExpenditureNote
{
    public class FormItemDto
    {
        public bool Select { get; set; }
        public InternalNoteDto InternalNote { get; set; }
        public double OutstandingAmount { get; set; }
    }
}