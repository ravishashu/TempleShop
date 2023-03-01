namespace TheShop.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly TheShopDBContext _context;

        public UserRepository(TheShopDBContext context)
        {
            _context = context;
        }

        public ICollection<ApplicationUser> GetUsers()
        {
            return _context.ApplicationUser.ToList();
        }

        public ApplicationUser GetUser(string id)
        {
            return _context.ApplicationUser.FirstOrDefault(u => u.Id == id);
        }

        public ApplicationUser UpdateUser(ApplicationUser user)
        {
            var dbUser = _context.ApplicationUser.FirstOrDefault(u => u.Id == user.Id);
            if (dbUser == null)
                return null;

            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Email = user.Email;

            _context.Update(dbUser);
            _context.SaveChanges();

            return user;
        }

        public ICollection<ApplicationUser> GetUsers(string searchString)
        {

            return _context.ApplicationUser.Where(r =>
            r.FirstName.Contains(searchString) ||
             r.LastName.Contains(searchString) ||
             r.Email.Contains(searchString)
                ).ToList();

        }
    }
}
