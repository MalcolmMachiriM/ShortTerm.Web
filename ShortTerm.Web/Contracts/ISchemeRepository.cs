using ShortTerm.Web.Data;
using ShortTerm.Web.Models;
using ShortTerm.Web.Repositories;

namespace ShortTerm.Web.Contracts
{
    public interface ISchemeRepository : IGenericRepository<Scheme>
    {
        Task<List<SchemeListVM>> GetAllSchemeDetails();
    }
}
