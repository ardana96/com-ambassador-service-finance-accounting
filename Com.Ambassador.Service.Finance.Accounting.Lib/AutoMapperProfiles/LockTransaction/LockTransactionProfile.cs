using AutoMapper;
using Com.Ambassador.Service.Finance.Accounting.Lib.Models.LockTransaction;
using Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.LockTransaction;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.AutoMapperProfiles.LockTransaction
{
    public class LockTransactionProfile : Profile
    {
        public LockTransactionProfile()
        {
            CreateMap<LockTransactionModel, LockTransactionViewModel>()
                .ReverseMap();
        }
    }
}
