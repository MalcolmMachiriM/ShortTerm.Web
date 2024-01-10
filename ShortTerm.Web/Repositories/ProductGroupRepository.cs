using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly AutoMapper.IConfigurationProvider configurationProvider;

        public ProductGroupRepository(ApplicationDbContext context, IMapper mapper, ISchemeRepository schemeRepository, AutoMapper.IConfigurationProvider configurationProvider) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.schemeRepository = schemeRepository;
            this.configurationProvider = configurationProvider;
        }

        public async Task CreateGroup(ProductGroupCreateVM model)
        {
           var productGroup = mapper.Map<ProductGroup>(model);

            await AddAsync(productGroup);
        }

        public async Task<List<ProductGroupVM>> GetAll()
        {
            var productGroups = await context.ProductGroups
                                .Include(q => q.Scheme)
                                .ProjectTo<ProductGroupVM>(configurationProvider)
                                .ToListAsync();
            return productGroups;
        }

        public async Task<List<ProductGroupVM>> GetAllGroups(int Id)
        {

            // very buggy
              var products = await context.ProductGroups
                .Include(q => q.Scheme)
                .ProjectTo<ProductGroupVM>(configurationProvider)
                .Where(q => q.Scheme.Id == Id)
                .ToListAsync();
            return products;

            
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
