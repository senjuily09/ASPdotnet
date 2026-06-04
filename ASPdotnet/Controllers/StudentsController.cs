using Microsoft.AspNetCore.Mvc;

namespace ASPdotnot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok("Hello Students");
        }
    }
}