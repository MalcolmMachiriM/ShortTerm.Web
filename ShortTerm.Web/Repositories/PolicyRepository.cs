using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Repositories
{
    public class PolicyRepository : GenericRepository<Policy>, IPolicyRepository
    {
        public PolicyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
