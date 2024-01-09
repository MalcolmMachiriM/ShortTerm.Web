using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Contracts
{
    public interface IProductGroupRepository : IGenericRepository<ProductGroup>
    {
        Task CreateGroup(ProductGroupCreateVM model);
        //Task<ProductGroupVM> SchemeDetails();
        Task<List<ProductGroupVM>> GetAllGroups(int Id);
    }
}
