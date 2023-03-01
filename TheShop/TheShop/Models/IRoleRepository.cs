using Microsoft.AspNetCore.Identity;

namespace TheShop.Models
{
    public interface IRoleRepository
    {
        IList<IdentityRole> GetRoles();
    }
}