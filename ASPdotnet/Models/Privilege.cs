using ASPdotnet.Models;

namespace ASPdotnet.Models
{
    public class Privilege
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<RolePrivilege> RolePrivileges { get; set; } = new List<RolePrivilege>();
    }
}