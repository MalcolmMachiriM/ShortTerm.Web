using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Repositories
{
    public class UnderwritingRepository : GenericRepository<UnderWriting>, IUnderwritingRepository
    {
        private readonly ApplicationDbContext context;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;
        private readonly IMapper mapper;

        public UnderwritingRepository(ApplicationDbContext context,AutoMapper.IConfigurationProvider configurationProvider,IMapper mapper) : base(context)
        {
            this.context = context;
            this.configurationProvider = configurationProvider;
            this.mapper = mapper;
        }

        public Task<List<UnderwritingListVM>> GetAll()
        {
            var model = context.UnderWritings.Include(q=>q.Policy)
                .Include(q=>q.Client)
                .Include(q=>q.StateOfProperty)
                .Include(q=>q.LocationOfProperty)
                .Include(q=>q.SecurityOfPropertyScore)
                .Include(q=>q.PrimaryUseOfPropertyScore)
                .ProjectTo<UnderwritingListVM>(configurationProvider)
                .ToListAsync();
            return model;
        }

        public Task<List<UnderwritingListVM>> GetAll(int Id)
        {
            var model = context.UnderWritings.Include(q => q.Policy)
               .Include(q => q.Client)
               .Include(q => q.StateOfProperty)
               .Include(q => q.LocationOfProperty)
               .Include(q => q.SecurityOfPropertyScore)
               .Include(q => q.PrimaryUseOfPropertyScore)
               .ProjectTo<UnderwritingListVM>(configurationProvider)
               .Where(q => q.PolicyId == Id)
               .ToListAsync();
            return model;
        }

        public  Task<UnderWritingVM> GetDetails(int id)
        {
            var policy =  context.Policies.Include(q=>q.Client)
                .Where(q=>q.Id == id) ;

            var model = mapper.Map<UnderWritingVM>(policy);

            return null;
        }
    }
}
