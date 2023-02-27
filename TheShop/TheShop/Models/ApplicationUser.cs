using Microsoft.AspNetCore.Identity;

namespace TheShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FistName { get; set;}
        public string LastName { get; set;}
    }
}
