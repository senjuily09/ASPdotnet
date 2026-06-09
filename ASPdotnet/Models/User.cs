using ASPdotnet.Models;

namespace ASPdotnet.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int RoleId { get; set; }

        public Role? Role { get; set; }
    }
}