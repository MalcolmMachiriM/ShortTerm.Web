using Microsoft.AspNetCore.Mvc;
using ShortTerm.Web.Contracts;

namespace ShortTerm.Web.Controllers
{
    public class PremiumPaymentController : Controller
    {
        private readonly IPremiumPaymentRepository premiumPaymentRepository;

        public PremiumPaymentController(IPremiumPaymentRepository premiumPaymentRepository)
        {
            this.premiumPaymentRepository = premiumPaymentRepository;
        }
        public async Task< IActionResult> Index()
        {
            var premiums =  await premiumPaymentRepository.GetAllAsync();
            return View(premiums);
        }
    }
}
