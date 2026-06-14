using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPdotnet.Data;


namespace ASPdotnet.Controllers
{

    [ApiController]
    [Route("api/access")]
    public class AccessController : ControllerBase
    {

        private readonly ApplicationDbContext _context;


        public AccessController(ApplicationDbContext context)
        {
            _context = context;
        }



        [HttpGet("user/{id}")]

        public async Task<IActionResult> GetUserPrivileges(int id)
        {

            var user = await _context.Users
                .Include(u => u.Role!)
                .ThenInclude(r => r.RolePrivileges!)
                .ThenInclude(rp => rp.Privilege)
                .FirstOrDefaultAsync(u => u.Id == id);



            if (user == null)
                return NotFound();



            return Ok(new
            {
                User = user.UserName,

                Role = user.Role!.RoleName,


                Privileges = user.Role.RolePrivileges
                .Select(x => x.Privilege!.PrivilegeName)

            });

        }

    }

}