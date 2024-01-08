using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Repositories
{
    public class ProductGroupRepository : GenericRepository<ProductGroup>, IProductGroupRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly ISchemeRepository schemeRepository;

        public ProductGroupRepository(ApplicationDbContext context, IMapper mapper, ISchemeRepository schemeRepository) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.schemeRepository = schemeRepository;
        }

        public async Task CreateGroup(ProductGroupCreateVM model)
        {
           var productGroup = mapper.Map<ProductGroup>(model);

            await AddAsync(productGroup);
        }

        //    public async Task<ProductGroupVM> SchemeDetails()
        //    {
        //        var id = 1;
        //        var groups = await context.ProductGroups
        //            .Include(q => q.Scheme)
        //            .FirstOrDefault(id);

        //        return  ;
        //    }
    }
}
