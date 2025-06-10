using ConsoleToAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController:ControllerBase
    {
        [Route("get")]
        public IEnumerable< EmployeesModel>GetAll()
        {
            return new List<EmployeesModel>{ 
                new EmployeesModel() { id = 10, name = "Ritik", RollNo = 119 },
                 new EmployeesModel() { id = 11, name = "Jay", RollNo = 120}};
        }
    }
}
