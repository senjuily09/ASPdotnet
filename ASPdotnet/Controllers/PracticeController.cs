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
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            return Ok($"Student {id} updated to {student.Name}");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok($"Student {id} deleted");
        }
    }
} 