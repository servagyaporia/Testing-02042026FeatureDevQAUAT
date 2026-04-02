using Microsoft.AspNetCore.Mvc;
using Retail_Web_DFA.Models;
using Retail_Web_DFA.Service;

namespace Retail_Web_DFA.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentService _service;

        public DepartmentController(DepartmentService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetDepartments());
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Department department)
        {
            _service.CreateDepartment(department);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_service.GetDepartment(id));
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            _service.UpdateDepartment(department);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _service.DeleteDepartment(id);
            return RedirectToAction("Index");
        }
    }
}
