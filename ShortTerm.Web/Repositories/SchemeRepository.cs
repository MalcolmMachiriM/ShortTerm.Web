using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Repositories
{
    public class SchemeRepository : GenericRepository<Scheme>, ISchemeRepository
    {
        private readonly ApplicationDbContext context;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;

        public SchemeRepository(ApplicationDbContext context,AutoMapper.IConfigurationProvider configurationProvider) : base(context)
        {
            this.context = context;
            this.configurationProvider = configurationProvider;
        }

        public async Task<List<SchemeListVM>> GetAllSchemeDetails()
        {
            var schemes =await  context.Schemes
                .Include(q => q.Clients)
                .ProjectTo<SchemeListVM>(configurationProvider)
                .ToListAsync();
            return schemes;
        }
    }
}
