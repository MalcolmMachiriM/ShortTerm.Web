using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Repositories
{
    public class PolicyReassurancesRepository : GenericRepository<PolicyReassurance>, IPolicyReassurancesRepository
    {
        public PolicyReassurancesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
