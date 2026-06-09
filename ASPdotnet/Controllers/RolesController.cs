using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPdotnet.Data;
using ASPdotnet.Models;
using ASPdotnet.DTOs;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> GetRole(int id)
        {
            var role = await _context.Roles.FindAsync(id);

            if (role == null)
                return NotFound();

            return role;
        }

        [HttpPost]
        public async Task<ActionResult<Role>> CreateRole(Role role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetRole),
                new { id = role.Id },
                role);
        }
        [HttpPost("{roleId}/privileges")]
        public async Task<IActionResult> AssignPrivileges(
    int roleId,
    AssignPrivilegesDto dto)
        {
            var role = await _context.Roles.FindAsync(roleId);

            if (role == null)
                return NotFound("Role not found");

            var existingMappings = _context.RolePrivileges
                .Where(rp => rp.RoleId == roleId);

            _context.RolePrivileges.RemoveRange(existingMappings);

            foreach (var privilegeId in dto.PrivilegeIds)
            {
                _context.RolePrivileges.Add(new RolePrivilege
                {
                    RoleId = roleId,
                    PrivilegeId = privilegeId
                });
            }

            await _context.SaveChangesAsync();

            return Ok("Privileges assigned successfully");
        }

        [HttpGet("{roleId}/privileges")]
        public async Task<IActionResult> GetRolePrivileges(int roleId)
        {
            var privileges = await _context.RolePrivileges
                .Where(rp => rp.RoleId == roleId)
                .Include(rp => rp.Privilege)
                .Select(rp => rp.Privilege)
                .ToListAsync();

            return Ok(privileges);
        }

    }
}