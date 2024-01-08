using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Repositories
{
    public class SchemeRepository : GenericRepository<Scheme>, ISchemeRepository
    {
        public SchemeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
