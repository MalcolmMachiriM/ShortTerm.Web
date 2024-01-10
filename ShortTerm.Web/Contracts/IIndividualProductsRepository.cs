using ShortTerm.Web.Data;
using ShortTerm.Web.Models;
using ShortTerm.Web.Repositories;

namespace ShortTerm.Web.Contracts
{
    public interface IIndividualProductsRepository : IGenericRepository<IndividualProduct>
    {
        Task<List<IndividualProductVM>> GetSpecificProducts(int GroupId);
        Task<List<IndividualProductVM>> GetAllProducts();
    }
}
