using FirstCrud.Models;

namespace FirstCrud.Repositories {
    public static class EmployeeRepository 
    {
        private static List<Employee> allEmployees = new List<Employee>();

        private static IEnumerable<Employee> AllEmlpoyees 
        {
            get { return allEmployees; }
        }

        public static void Create(Employee employee) 
        {
            allEmployees.Add(employee);
        }
    }
}
