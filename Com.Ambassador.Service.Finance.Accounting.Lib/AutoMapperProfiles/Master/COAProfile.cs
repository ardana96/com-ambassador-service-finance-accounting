using AutoMapper;
using Com.Ambassador.Service.Finance.Accounting.Lib.Models.MasterCOA;
using Com.Ambassador.Service.Finance.Accounting.Lib.ViewModels.MasterCOA;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.AutoMapperProfiles.Master
{
    public class COAProfile : Profile
    {
        public COAProfile()
        {
            CreateMap<COAModel, COAViewModel>().ReverseMap();
        }
    }
}
