using Microsoft.AspNetCore.Identity;

namespace TheShop.Models
{
    public class RoleRepository : IRoleRepository
    {
        private readonly TheShopDBContext _context;

        public RoleRepository(TheShopDBContext context)
        {
            _context = context;
        }

        public IList<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}