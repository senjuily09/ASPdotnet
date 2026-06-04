using Microsoft.AspNetCore.Mvc;

namespace ASPdotnet.Controllers
{
    [ApiController]
    [Route("api/teachers")]
    public class TeachersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTeachers()
        {
            return Ok("Hello Teachers");
        }
    }
}