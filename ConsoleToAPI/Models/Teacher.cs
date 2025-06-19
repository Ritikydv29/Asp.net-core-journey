using System.ComponentModel.DataAnnotations;

namespace ConsoleToAPI.Models
{
    public class Teacher
    {

        [Key] public int Teacher_Id { get; set; }
        public string Name { get; set; }

        public List<Student>? Students { get; set; }
        public List<Score> ? Scores { get; set; }

    }
    public class TopStudentsPerTeacher {
        public string TeacherName { get; set; }
        public string StudentName { get; set; }

        public int AverageMarks {  get; set; }

    }


}
