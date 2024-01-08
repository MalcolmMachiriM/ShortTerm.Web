using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Repositories
{
    public class IndividualProductsRepository : GenericRepository<IndividualProduct>, IIndividualProductsRepository
    {
        public IndividualProductsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
