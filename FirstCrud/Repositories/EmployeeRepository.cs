using FirstCrud.Models;

namespace FirstCrud.Repositories {
    public static class EmployeeRepository 
    {
        private static List<Employee> allEmployees = new List<Employee>();

        public static IEnumerable<Employee> AllEmployees
        {
            get { return allEmployees; }
        }


        public static void Create(Employee employee) 
        {
            allEmployees.Add(employee);
        }

        public static void Delete(Employee employee) 
        {
            allEmployees.Remove(employee);
        }
    }
}
