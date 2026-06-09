using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Privilege>>> GetPrivileges()
        {
            return await _context.Privileges.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Privilege>> GetPrivilege(int id)
        {
            var privilege = await _context.Privileges.FindAsync(id);

            if (privilege == null)
                return NotFound();

            return privilege;
        }

        [HttpPost]
        public async Task<ActionResult<Privilege>> CreatePrivilege(Privilege privilege)
        {
            _context.Privileges.Add(privilege);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetPrivilege),
                new { id = privilege.Id },
                privilege);
        }
    }
}