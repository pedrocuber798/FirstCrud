using Microsoft.AspNetCore.Mvc;

using FirstCrud.Repositories;
using FirstCrud.Models;

namespace FirstCrud.Controllers {
    public class EmployeesController : Controller 
        {
        public IActionResult Index() 
            {
            return View(EmployeeRepository.AllEmployees);
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
            Employee employee = EmployeeRepository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            return View(employee);
        }
        [HttpPost]
        public IActionResult Update(Employee employee, string empname) {
            EmployeeRepository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
            EmployeeRepository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
            EmployeeRepository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
            EmployeeRepository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Sex = employee.Sex;
            EmployeeRepository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(string empname) {
            Employee employee = EmployeeRepository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            EmployeeRepository.Delete(employee);
            return RedirectToAction("Index");
        }

}
}
