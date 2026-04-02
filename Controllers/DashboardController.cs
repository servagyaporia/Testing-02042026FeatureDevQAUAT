using Microsoft.AspNetCore.Mvc;

namespace Retail_Web_DFA.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
