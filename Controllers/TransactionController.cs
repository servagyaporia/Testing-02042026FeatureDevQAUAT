using Microsoft.AspNetCore.Mvc;

namespace Retail_Web_DFA.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
