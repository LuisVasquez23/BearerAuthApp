using Microsoft.AspNetCore.Identity;

namespace BearerAuthApp.Models
{
    public class UserModel : IdentityUser
    {
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }
        public string? Address { get; set; }
    }
}
