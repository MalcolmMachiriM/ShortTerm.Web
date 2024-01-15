using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Repositories
{
    public class PolicyRepository : GenericRepository<Policy>, IPolicyRepository
    {
        private readonly ApplicationDbContext context;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;

        public PolicyRepository(ApplicationDbContext context,AutoMapper.IConfigurationProvider configurationProvider) : base(context)
        {
            this.context = context;
            this.configurationProvider = configurationProvider;
        }

        public Task<List<PolicyListVM>> GetAll()
        {
            var policies = context.Policies
                .Include(q=>q.ProductGroup)
                .Include(q=>q.IndividualProduct)
                .Include(q=>q.PaymentFrequency)
                .Include(q=>q.PaymentMethod)
                .Include(p => p.Client)
                .ProjectTo< PolicyListVM>(configurationProvider)
                .ToListAsync();
                return policies;
        }
    }
}
