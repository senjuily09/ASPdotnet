using Microsoft.AspNetCore.Mvc;

namespace ASPdotnet.Controllers
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
        [HttpPost]
        public IActionResult AddStudent()
        {
            return Ok("Student Added");
        }
        [HttpPut]
        public IActionResult UpdateStudent()
        {
            return Ok("Student Updated");
        }
        [HttpDelete]
        public IActionResult DeleteStudent()
        {
            return Ok("Student Deleted");
        }
    }
}