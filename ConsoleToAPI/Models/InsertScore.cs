namespace ConsoleToAPI.Models
{
    public class InsertScore
    {
        public DateOnly date { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }

        public int Teacher_Id { get; set; }

        public int Student_Id { get; set; }
    }
}
