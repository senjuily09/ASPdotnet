namespace ASPdotnet.Models
{
    public class Privilege
    {
        public int Id { get; set; }

        public string PrivilegeName { get; set; } = string.Empty;


        public ICollection<RolePrivilege>? RolePrivileges { get; set; }
    }
}