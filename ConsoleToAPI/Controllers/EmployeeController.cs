using ConsoleToAPI.Models;
using ConsoleToAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController:ControllerBase
    {
        private readonly IEmployeeRepository _employee;
        public EmployeeController(IEmployeeRepository employee)
        {
            _employee = employee;
        }
        [HttpPost("")]
        public IActionResult insert(EmployeesModel employeee)
        {
            _employee.insert(employeee);
            return Ok(employeee);
        }

        [HttpGet("")]
        public IActionResult get()
        {

            return Ok(_employee.GetAll());
        }
    }
}
