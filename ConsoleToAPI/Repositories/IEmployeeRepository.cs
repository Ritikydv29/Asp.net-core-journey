using ConsoleToAPI.DTO;
using ConsoleToAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToAPI.Repositories
{
    public interface IEmployeeRepository
    {
        List<EmployeesModel>GetAll();
        void insert(EmployeesModel employee);
        Task<Student> insertAsync(Student student);
        Task<Teacher> insertTeacherAsync(Teacher teacher);
        Task<Student> insertStudentAsync(Student student);
        Task<Score> insertScoreAsync(Score score);
        Task<List<Student>> GetAllAsync();
        Task<List<TeacherInfo>> GetAllTeacherAsync();
        Task<Teacher>GetTeacherAsync(int id);

        Task<List<StudentInfo>> GetAllStudentDataAsync(int flag);
        Task<List<AverageMarksByTeacher>> GetAverageAsync(int flag);
        Task<int> insertScorebyProcedureAsync(Score score);
        Task<List<GetStudentScore>> GetStudentScoreAsync(int id);
        Task<List<TopStudentsPerTeacher>> TopStudentsPerTeacherAsync();

        Task<List<GetAllStudents>> GetAllStudents();
    }  
}
