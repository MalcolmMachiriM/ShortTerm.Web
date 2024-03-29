﻿using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Contracts
{
    public interface IPolicyRepository : IGenericRepository<Policy>
    {
        public Task<List<PolicyListVM>> GetAll();
        public Task<Policy> GetPolicies(int PolicyId);
        public Task ChangeApprovalStatus(int PolicyId, bool approved);

    }
}
