using Microsoft.AspNetCore.Identity;

namespace demo2.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add additional properties if needed
        public string FullName { get; set; }
    }
}
