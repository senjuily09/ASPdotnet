using Microsoft.AspNetCore.Mvc;
using ASPdotnet.Data;
using ASPdotnet.Models;
using ASPdotnet.DTO;

namespace ASPdotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccessController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccessController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("assign-privilege")]
        public IActionResult AssignPrivilege(AssignPrivilegesDto dto)
        {
            var rp = new RolePrivilege
            {
                RoleId = dto.RoleId,
                PrivilegeId = dto.PrivilegeId
            };

            _context.RolePrivileges.Add(rp);
            _context.SaveChanges();

            return Ok(rp);
        }
    }
}