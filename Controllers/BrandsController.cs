using Microsoft.AspNetCore.Mvc;

namespace Retail_Web_DFA.Controllers
{
    public class BrandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
