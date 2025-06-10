using Microsoft.AspNetCore.Mvc;

namespace ConsoleToAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TestController:ControllerBase
    {
        //[Route("api/Get")]
        //[Route("Get")]
    
        public string Get()
        {
            return "Hello This is Testing from Get";
        }
        //[Route("api/Get-All")]
      
        public string GetAll()
        {
            return "Hello This is from GETALL";
        }
        //[Route("api/id/{id}")]
        public string GetbyId(int id)
        {
            return "Hello from id "+id;
        }

        [Route("api")]
        public string GetUserinfo(int id,int Roll)
        {
            return "Hello from GetUserInfo";
        }
    }
}
