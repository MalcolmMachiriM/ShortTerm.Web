using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        private readonly ApplicationDbContext context;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;

        public ClientRepository(ApplicationDbContext context,AutoMapper.IConfigurationProvider configurationProvider) : base(context)
        {
            this.context = context;
            this.configurationProvider = configurationProvider;
        }

        public async Task<List<ClientListVM>> GetAllClients()
        {
            var clients = await context.Clients.Include(q=>q.Gender)
                .Include(c => c.MaritalStatus)
                .ProjectTo<ClientListVM>(configurationProvider)
                .ToListAsync();

            return (clients);
        }
    }
}
