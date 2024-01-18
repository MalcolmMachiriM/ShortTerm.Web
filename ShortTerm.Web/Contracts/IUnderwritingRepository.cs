using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Contracts
{
    public interface IUnderwritingRepository : IGenericRepository<UnderWriting>
    {
        Task <UnderWritingVM> GetDetails(int id);
        Task <List<UnderwritingListVM>> GetAll();
    }
}
