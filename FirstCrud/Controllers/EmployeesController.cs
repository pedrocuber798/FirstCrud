using Microsoft.AspNetCore.Mvc;
using FirstCrud.Models;
using FirstCrud.Repositories;

namespace FirstCrud.Controllers {
    public class EmployeesController : Controller 
        {
        public IActionResult Index() 
            {
            return View(EmployeeRepository.AllEmlpoyees);
        }

        public IActionResult Create() 
            {
            return View();
        }
        // HTTP POST VERSION
        [HttpPost]
        public IActionResult Create(Employee employee) {
            EmployeeRepository.Create(employee);
            return View("Thanks", employee);
        }
    }
}
