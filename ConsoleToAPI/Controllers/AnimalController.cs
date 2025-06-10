using ConsoleToAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalController:ControllerBase
    {
        List<AnimalModel> animal = new List<AnimalModel>();
        [Route("get")]
        public List<AnimalModel> Get() {
            return new List<AnimalModel>
            {
                new AnimalModel(){Name="pablo",type="Dog"},
                 new AnimalModel(){Name="Lucy",type="Cat"}
            };
        }
        [HttpPost("post")]
        public IActionResult Upload(List<AnimalModel>list)
        {
            Console.WriteLine("Successfull Upload");
            return Ok(new
            {
                message = "Successful Upload",
                countmember=list.Count,
                list
            }); 
        }
    }
}
