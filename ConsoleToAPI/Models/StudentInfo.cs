namespace ConsoleToAPI.Models
{
    public class StudentInfo
    {
        public string name { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }
        
    }
    public class AverageMarksByTeacher
    {
        public string name { get; set; }
 
        public int Marks { get; set; }

    }
    public class GetStudentScore
    {
        public string name { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }

    }

}
