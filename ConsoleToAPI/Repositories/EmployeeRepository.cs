using ConsoleToAPI.ExtensionMethods;
using ConsoleToAPI.Models;

namespace ConsoleToAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<EmployeesModel> employess = new List<EmployeesModel>();
        public List<EmployeesModel> GetAll()
        {
            return employess;
        }

        public void insert(EmployeesModel employee)
        {
            if (employess.Count == 0) employee.id = 1;
            else employee.id = employess[employess.Count - 1].id + 1;
            employee.AddPhone();
            employess.Add(employee);
        }
    }
}
