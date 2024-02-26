using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Repositories
{
    public class PremiumPaymentRepository : GenericRepository<PremiumPayment>, IPremiumPaymentRepository
    {
        public PremiumPaymentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
