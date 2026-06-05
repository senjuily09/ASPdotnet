using Microsoft.AspNetCore.Mvc;
using ASPdotnet.Models;

namespace ASPdotnet.Controllers
{
    [ApiController]
    [Route("api/practice")]
    public class PracticeController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            return Ok(student);
        }
    }
}