using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class ProgrammeCoordinatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
