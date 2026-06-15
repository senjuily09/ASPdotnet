namespace ASPdotnet.Models
{
    public class RolePrivilege
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PrivilegeId { get; set; }
    }
}