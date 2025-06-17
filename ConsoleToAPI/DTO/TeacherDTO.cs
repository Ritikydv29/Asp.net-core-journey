using System.ComponentModel.DataAnnotations;

namespace ConsoleToAPI.DTO
{
    public class TeacherDTO
    {
        public int Teacher_Id { get; set; }
        public string Name { get; set; }
        public List<StudentDTO> Students { get; set; }
    }

}

