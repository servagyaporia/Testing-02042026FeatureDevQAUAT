using Microsoft.AspNetCore.Mvc;
using Retail_Web_DFA.Service;
using Retail_Web_DFA.ViewModel;

namespace Retail_Web_DFA.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _service;

        public AccountController(AccountService service)
        {
            _service = service;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            var user = _service.Login(model.Username, model.Password);

            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View();
        }
    }
}
