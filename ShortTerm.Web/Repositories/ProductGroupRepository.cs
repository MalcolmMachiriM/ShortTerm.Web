using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Repositories
{
    public class ProductGroupRepository : GenericRepository<ProductGroup>, IProductGroupRepository
    {
        public ProductGroupRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
