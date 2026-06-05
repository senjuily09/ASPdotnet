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
            return Ok("erroe");
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

        [HttpGet("all")]
        public IActionResult GetAllStudents()
        {
            var students = new List<ASPdotnet.Models.Student>
            {
                new ASPdotnet.Models.Student
                {
                    Id = 1,
                    Name = "Alice",
                    Age = 20,
                    Department = "CSE"
                },

                new ASPdotnet.Models.Student
                {
                    Id = 2,
                    Name = "Bob",
                    Age = 22,
                    Department = "ECE"
                }
            };
            return Ok(students);

        }
    }
}