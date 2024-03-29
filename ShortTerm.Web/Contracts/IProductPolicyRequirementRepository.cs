﻿using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Contracts
{
    public interface IProductPolicyRequirementRepository : IGenericRepository<ProductPolicyRequirement>
    {
        Task<List<ProductPolicyRuquirementsListVM>> GetAllPolicyRules(int productId);
        
    }
}
