namespace ConsoleToAPI.DTO
{
    public class StudentDTO
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }
        public List<ScoreDTO> Scores { get; set; }
    }
}
