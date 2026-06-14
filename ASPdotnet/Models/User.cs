namespace ASPdotnet.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        // Every user belongs to one role
        public int RoleId { get; set; }

        public Role? Role { get; set; }
    }
}