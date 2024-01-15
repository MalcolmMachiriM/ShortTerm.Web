using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Repositories
{
    public class ProductPolicyRequirementRepository : GenericRepository<ProductPolicyRequirement>, IProductPolicyRequirementRepository
    {
        private readonly ApplicationDbContext context;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;

        public ProductPolicyRequirementRepository(ApplicationDbContext context, AutoMapper.IConfigurationProvider configurationProvider) : base(context)
        {
            this.context = context;
            this.configurationProvider = configurationProvider;
        }

        public async Task<List<ProductPolicyRuquirementsListVM>> GetAllPolicyRules(int productId)
        {
            var policyRequirements = await context.ProductPolicyRequirements
                .Include(c=>c.IndividualProduct)
                .Include(d=>d.Requirement)
                .Include(d=>d.Requirement.RequirementType)
                .Where(q => q.IndividualProductID == productId)
                .ProjectTo<ProductPolicyRuquirementsListVM>(configurationProvider)
                .ToListAsync();
            return policyRequirements;
        }

        
    }
}
