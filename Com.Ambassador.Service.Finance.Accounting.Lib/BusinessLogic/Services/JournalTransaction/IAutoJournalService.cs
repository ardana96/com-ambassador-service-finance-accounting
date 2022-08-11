using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Com.Ambassador.Service.Finance.Accounting.Lib.Models.DailyBankTransaction;
using Com.Ambassador.Service.Finance.Accounting.Lib.Models.OthersExpenditureProofDocument;
using Com.Ambassador.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote;
using Com.Ambassador.Service.Finance.Accounting.Lib.Services.HttpClientService;
using Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;
using Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.OthersExpenditureProofDocumentViewModels;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.BusinessLogic.Services.JournalTransaction
{
    public interface IAutoJournalService
    {
        Task<int> AutoJournalFromOthersExpenditureProof(OthersExpenditureProofDocumentCreateUpdateViewModel viewModel, string documentNo);
        Task<int> AutoJournalFromOthersExpenditureProof(OthersExpenditureProofDocumentModel model, List<OthersExpenditureProofDocumentItemModel> items);
        Task<int> AutoJournalReverseFromOthersExpenditureProof(string documentNo);
        Task<int> AutoJournalVBNonPOClearence(List<int> vbRealizationIds);
        Task<int> AutoJournalVBNonPOClearence(List<int> vbRealizationIds, AccountBankViewModel bank, string referenceNo);
        //Task<int> AutoJournalInklaring(List<int> vbRequestIds);
        Task<int> AutoJournalInklaring(List<int> vbRequestIds, AccountBankViewModel bank);
        string DocumentNoGenerator(AccountBankViewModel bank);
        Task<int> AutoJournalFromDailyBankTransaction(DailyBankTransactionModel model, AccountBank accountBank, AccountBank accountBankDestination);
        Task<int> AutoJournalFromDisposition(PaymentDispositionNoteModel model, string Username, string UserAgent);
    }
}