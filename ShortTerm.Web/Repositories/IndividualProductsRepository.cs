using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Repositories
{
    public class IndividualProductsRepository : GenericRepository<IndividualProduct>, IIndividualProductsRepository
    {
        private readonly ApplicationDbContext context;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;

        public IndividualProductsRepository(ApplicationDbContext context, AutoMapper.IConfigurationProvider configurationProvider) : base(context)
        {
            this.context = context;
            this.configurationProvider = configurationProvider;
        }
        public async Task<List<IndividualProductVM>> GetAllProducts()
        {
            var prods = await context.IndividualProducts.Include(q => q.ProductGroup)
                .ProjectTo<IndividualProductVM>(configurationProvider).ToListAsync();
            return prods;
        }

        public async Task<List<IndividualProductVM>> GetSpecificProducts(int GroupId)
        {
            var prods = await context.IndividualProducts
            .Include(q => q.ProductGroup)
                .ProjectTo<IndividualProductVM>(configurationProvider)
                .Where(q => q.ProductGroup.Id == GroupId)
                .ToListAsync();
            return prods;
        }
    }
}
