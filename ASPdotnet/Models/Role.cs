using ASPdotnet.Models;

namespace ASPdotnet.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<User> Users { get; set; } = new List<User>();

        public ICollection<RolePrivilege> RolePrivileges { get; set; } = new List<RolePrivilege>();
    }
}