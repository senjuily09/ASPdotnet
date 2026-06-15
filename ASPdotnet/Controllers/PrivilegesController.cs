using Microsoft.AspNetCore.Mvc;
using ASPdotnet.Data;
using ASPdotnet.Models;

namespace ASPdotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrivilegesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PrivilegesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Privilege privilege)
        {
            _context.Privileges.Add(privilege);
            _context.SaveChanges();
            return Ok(privilege);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Privileges.ToList());
        }
    }
}