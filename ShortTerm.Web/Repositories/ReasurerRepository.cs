using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Repositories
{
    public class ReasurerRepository : GenericRepository<Reassurer>, IReasurerRepository
    {
        public ReasurerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
