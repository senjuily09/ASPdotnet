using Microsoft.AspNetCore.Mvc;
using ASPdotnet.Data;
using ASPdotnet.Models;

namespace ASPdotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RolesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return Ok(role);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Roles.ToList());
        }
    }
}