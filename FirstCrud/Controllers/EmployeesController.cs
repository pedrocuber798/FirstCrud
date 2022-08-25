using Microsoft.AspNetCore.Mvc;
using FirstCrud.Models;
using FirstCrud.Repositories;

namespace FirstCrud.Controllers {
    public class EmployeesController : Controller 
        {
        public IActionResult Index() 
            {
            return View();
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
