using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebAPIController : ControllerBase
    {
        [HttpGet]
        public string GetHello()
        {
            return "Hello The World";
        }


        [HttpGet("{id}")]
        public string GetHelloWorld(int id)
        {
            //return "Hello The World....." + id.ToString();

            return $"Hello The World...{id}";
        }
        [HttpGet("{a}/{b}")]
        public string GetCompute(int a,int b)
        {
            int result = a+b;
            return result.ToString();
        }
    }
}
