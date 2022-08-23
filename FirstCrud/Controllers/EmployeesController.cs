using Microsoft.AspNetCore.Mvc;

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
    }
}
