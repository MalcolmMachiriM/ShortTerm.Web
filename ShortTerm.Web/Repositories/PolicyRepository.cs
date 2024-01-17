using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;
using AutoMapper;

namespace ShortTerm.Web.Repositories
{
    public class PolicyRepository : GenericRepository<Policy>, IPolicyRepository
    {
        private readonly ApplicationDbContext context;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;
        private readonly IIndividualProductsRepository individualProductsRepository;
        private readonly IMapper mapper;

        public PolicyRepository(ApplicationDbContext context,AutoMapper.IConfigurationProvider configurationProvider,IIndividualProductsRepository individualProductsRepository,IMapper mapper) : base(context)
        {
            this.context = context;
            this.configurationProvider = configurationProvider;
            this.individualProductsRepository = individualProductsRepository;
            this.mapper = mapper;
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

        public async Task ChangeApprovalStatus(int PolicyId, bool approved)
        {

            var policy = await GetAsync(PolicyId);
            TimeSpan timeDifference = DateTime.Now - policy.DateCreated;
            bool isProcessTimeElapsed = policy.IndividualProduct.ProcessTime <= timeDifference.TotalDays / 30;
            if (approved && isProcessTimeElapsed)
            {
                policy.Approved = true;

            }
            else
            {
                return;
            }
            policy.Approved = approved;
            await UpdateAsync(policy);

            
        }

        
    }
}
