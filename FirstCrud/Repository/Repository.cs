using FirstCrud.Models;

namespace FirstCrud.Repository {
    public class Repository 
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
