using AutoMapper;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Repositories
{
    public class ProductGroupRepository : GenericRepository<ProductGroup>, IProductGroupRepository
    {
        private readonly IMapper mapper;

        public ProductGroupRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }

        public async Task CreateGroup(ProductGroupCreateVM model)
        {
           var productGroup = mapper.Map<ProductGroup>(model);

            await AddAsync(productGroup);
        }
    }
}
