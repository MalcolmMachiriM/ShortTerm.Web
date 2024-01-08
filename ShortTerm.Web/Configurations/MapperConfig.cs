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
            CreateMap<Scheme, SchemeVM>().ReverseMap();
            CreateMap<ProductGroup, ProductGroupVM>().ReverseMap();
            CreateMap<ProductGroup, ProductGroupCreateVM>().ReverseMap();
            CreateMap<IndividualProduct, IndividualProductVM>().ReverseMap();
            CreateMap<Policy, PolicyListVM>().ReverseMap();
            CreateMap<Policy, PolicyCreateVM>().ReverseMap();
            CreateMap<IndividualProduct, IndividualProductCreateVM>().ReverseMap();
            
        }
    }
}
