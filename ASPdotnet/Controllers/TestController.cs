// Route Pramaters 
using Microsoft.AspNetCore.Mvc;

namespace ASPdotnet.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("TEST");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"ID = {id}");
        }
    }
}