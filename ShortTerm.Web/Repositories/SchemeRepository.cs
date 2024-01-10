using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Repositories
{
    public class SchemeRepository : GenericRepository<Scheme>, ISchemeRepository
    {
        private readonly ApplicationDbContext context;

        public SchemeRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public Task<List<SchemeVM>> GetAllSchemeDetails()
        {
            //var schemes = context.Schemes.Include(q => q.Clients);
            return null;
        }
    }
}
