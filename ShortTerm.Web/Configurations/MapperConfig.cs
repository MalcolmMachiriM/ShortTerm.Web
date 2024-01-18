using AutoMapper;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Client, ClientListVM>().ReverseMap();
            CreateMap<Client, ClientCreateVM>().ReverseMap();
            CreateMap<Scheme, SchemeCreateVM>().ReverseMap();
            CreateMap<Scheme, SchemeListVM>().ReverseMap();
            CreateMap<ProductGroup, ProductGroupVM>().ReverseMap();
            CreateMap<ProductGroup, ProductGroupCreateVM>().ReverseMap();
            CreateMap<IndividualProduct, IndividualProductVM>().ReverseMap();
            CreateMap<Policy, PolicyListVM>().ReverseMap();
            CreateMap<Policy, PolicyCreateVM>().ReverseMap();
            CreateMap<IndividualProduct, IndividualProductCreateVM>().ReverseMap();
            CreateMap<PolicyRulesVM, ProductPolicyRequirement>().ReverseMap();
            CreateMap<ProductPolicyRequirement, ProductPolicyRequirementCreateVM>().ReverseMap();
            CreateMap<ProductPolicyRequirement, ProductPolicyRuquirementsListVM>().ReverseMap();
            CreateMap<Reassurer, ReasurerCreateVM>().ReverseMap();
            CreateMap<UnderWriting, UnderWritingVM>().ReverseMap();
            CreateMap<Policy, UnderWritingVM>().ReverseMap();
            CreateMap<Client, ClientDetailsVM>().ReverseMap();
            CreateMap<Client, InstitutionalClientCreateVM>().ReverseMap();
            CreateMap<UnderWriting, UnderwritingListVM>().ReverseMap();

        }
    }
}
