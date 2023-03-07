using Microsoft.AspNetCore.Identity;

namespace AuthenticationAPI_.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
