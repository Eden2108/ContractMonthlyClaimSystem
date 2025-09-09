using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TrackClaim()
        {
            // Later, you’ll pull actual claims from DB
            return View();
        }

    }
}
