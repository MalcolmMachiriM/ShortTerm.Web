using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Contracts
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<List<ClientListVM>> GetAllClients();
    }
}
