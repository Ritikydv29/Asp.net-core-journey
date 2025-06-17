using ConsoleToAPI.Data;
using ConsoleToAPI.ExtensionMethods;
using ConsoleToAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsoleToAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly StudentContext _studentContext;
        public EmployeeRepository(StudentContext studentcontext) {
            _studentContext = studentcontext;
        }
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
        public async Task<Student> insertAsync(Student student)
        {
            _studentContext.Student.Add(student);
            await _studentContext.SaveChangesAsync();
            return student;
        }
        public async Task<List<Student>> GetAllAsync()
        {
            var records = await _studentContext.Student.ToListAsync();
            return records;
        }
        public async Task<Teacher> insertTeacherAsync(Teacher teacher)
        {

           
            await _studentContext.Teacher.AddAsync(teacher);
            await _studentContext.SaveChangesAsync();
            return teacher;

        }
        public async Task<List<Teacher>> GetAllTeacherAsync()
        {
            var records=await _studentContext.Teacher
        .Include(t => t.Students)                 
        .ThenInclude(s => s.Scores)              
        .ToListAsync(); 
            return records;
        }
        public async Task<Teacher> GetTeacherAsync([FromRoute]int id)
        {
            return await _studentContext.Teacher
                .Include(t => t.Students)
                .ThenInclude(s => s.Scores)
                .FirstOrDefaultAsync(t => t.Teacher_Id == id);

        }
        public async Task<Score> insertScoreAsync(Score score)
        {
           
            await _studentContext.Scores.AddAsync(score);
            await _studentContext.SaveChangesAsync();
            return score;

       
        }
        public async Task<Student> insertStudentAsync(Student student)
        {
            await _studentContext.Student.AddAsync(student);
            await _studentContext.SaveChangesAsync();
            return student;

        }
       

    }
}
