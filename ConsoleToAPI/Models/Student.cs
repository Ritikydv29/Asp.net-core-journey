using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleToAPI.Models
{
    public class Student
    {

        [Key] public int Student_Id { get; set; }
        public string name { get; set; }
        public string Phone_No { get; set; }
        public string Address { get; set; }

        public int? Teacher_Id { get; set; }
        [JsonIgnore]
        public Teacher ? Teacher { get; set; }
        public List<Score>? Scores { get; set; }
    }
}
