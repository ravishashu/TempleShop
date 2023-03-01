namespace TheShop.Models
{
    public interface IUserRepository
    {
        ICollection<ApplicationUser> GetUsers();

        ICollection<ApplicationUser> GetUsers(string searchString);

        ApplicationUser GetUser(string id);

        ApplicationUser UpdateUser(ApplicationUser user);
    }
}
