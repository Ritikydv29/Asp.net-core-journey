using Microsoft.AspNetCore.Mvc;

namespace ConsoleToAPI.Models
{
    public class EmployeesModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public  string Phone_No { get; set; }
        public string Address { get; set; }

        public int Teacher_Id {  get; set; }

        public Teacher Teacher { get; set; }
    }
}
