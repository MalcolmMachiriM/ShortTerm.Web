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

        public async Task ChangeStatus(int id, int approved)
        {
            var client = await GetAsync(id);
            client.Status = approved;
            
            await UpdateAsync(client);
        }

        public async Task<List<ClientListVM>> GetAllClients()
        {
            var clients = await context.Clients.Include(q=>q.Gender)
                .Include(c => c.MaritalStatus)
                .ProjectTo<ClientListVM>(configurationProvider)
                .Where(q=> q.Status == 0)
                .ToListAsync();

            return (clients);
        }
        public async Task<List<ClientListVM>> GetApprovedClients()
        {
            var clients = await context.Clients.Include(q=>q.Gender)
                .Include(c => c.MaritalStatus)
                .ProjectTo<ClientListVM>(configurationProvider)
                .Where(q=> q.Status != 0)
                .ToListAsync();

            return (clients);
        }
    }
}
