using ConsoleToAPI.Data;
using ConsoleToAPI.DTO;
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

        [HttpPost("teacher")]
        public async Task<IActionResult> AddTeacher([FromBody]Teacher teacher)
        {
   
            await _employee.insertTeacherAsync(teacher);
            return Created("",teacher);

        }
        [HttpGet("teachers")]
        public async Task<ActionResult<List<Teacher>>> GetTeachers()
        {
            var records=await _employee.GetAllTeacherAsync();

            return Ok(records);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherDTO>> GetTeacherbyId([FromRoute]int id)
        {
            var teacher = await _employee.GetTeacherAsync(id);
            if (teacher == null) return NotFound("No Record Found");
            var teacherDTO = new TeacherDTO
            {
                Teacher_Id = teacher.Teacher_Id,
                Name = teacher.Name,
                Students = teacher.Students?.Select(s => new StudentDTO
                {
                    Student_Id = s.Student_Id,
                    Name = s.name,
                    Scores = s.Scores?.Select(sc => new ScoreDTO
                    {
                        id = sc.id,
                        date = sc.date,
                        Marks = sc.Marks
                    }).ToList()
                }).ToList()
            };

          
       
            return Ok(teacherDTO);

        }
        [HttpPost("score")]
        public async Task<ActionResult<Score>> insertScoreAsync([FromBody]Score score)
        {

            await _employee.insertScoreAsync(score);
          
            return Ok(score);


        }

        [HttpPost("student")]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {

            await _employee.insertStudentAsync(student);
            return Created("", student);

        }
    }
}
