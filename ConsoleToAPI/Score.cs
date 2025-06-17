using System.Text.Json.Serialization;

namespace ConsoleToAPI
{
    public class Score
    {
        public DateOnly date { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }
        public int? id { get; set; }

        public int? Teacher_Id { get; set; }

        public int? Student_Id { get; set; }

        [JsonIgnore]
        public Student? Student { get; set; }
        [JsonIgnore]
        public Teacher? Teacher { get; set; }


    }
}
