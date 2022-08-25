using Microsoft.AspNetCore.Mvc;
using FirstCrud.Models;
using FirstCrud.Repositories;

namespace FirstCrud.Controllers {
    public class EmployeesController : Controller 
        {
        public IActionResult Index() 
            {
            return View(EmployeeRepository.AllEmplpoyees);
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
        [HttpGet]
        public IActionResult Update(string empname) {
            Employee employee = EmployeeRepository.AllEmplpoyees.Where(e => e.Name == empname).FirstOrDefault();
            return View(employee);
        }
        [HttpPost]
        public IActionResult Update(Employee employee, string empname) {
            EmployeeRepository.AllEmplpoyees.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
            EmployeeRepository.AllEmplpoyees.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
            EmployeeRepository.AllEmplpoyees.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
            EmployeeRepository.AllEmplpoyees.Where(e => e.Name == empname).FirstOrDefault().Sex = employee.Sex;
            EmployeeRepository.AllEmplpoyees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;

            return RedirectToAction("Index");
        }

    }
}
