using ConsoleToAPI.Models;

namespace ConsoleToAPI.Repositories
{
    public interface IEmployeeRepository
    {
        List<EmployeesModel>GetAll();
        void insert(EmployeesModel employee);

    }
}
