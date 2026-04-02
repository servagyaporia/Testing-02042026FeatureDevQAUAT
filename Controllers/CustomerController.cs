using Microsoft.AspNetCore.Mvc;

namespace Retail_Web_DFA.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
