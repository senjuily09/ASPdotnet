namespace ASPdotnet.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string RoleName { get; set; } = string.Empty;


        // Users having this role
        public ICollection<User>? Users { get; set; }


        // Privileges of this role
        public ICollection<RolePrivilege>? RolePrivileges { get; set; }
    }
}