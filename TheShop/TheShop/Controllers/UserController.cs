using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheShop.Models;
using TheShop.ViewModels;

namespace TheShop.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserController(IUserRepository userRepository, IRoleRepository roleRepository, SignInManager<IdentityUser> signInManager)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            if(string.IsNullOrEmpty(searchString)) 
                return View(_userRepository.GetUsers());
            else 
                return View(_userRepository.GetUsers(searchString));
        }
        public async Task<IActionResult> Edit(string id)
        {
            var user = _userRepository.GetUser(id);
            var roles = _roleRepository.GetRoles();
            var userRoles = await _signInManager.UserManager.GetRolesAsync(user);
            var roleItems = roles.Select(role =>
                 new SelectListItem(
                     role.Name,
                     role.Id,
                     userRoles.Any(ur => ur.Contains(role.Name)))).ToList();

            return View(new EditUserViewModel() { User = user, Roles = roleItems });
        }
        [HttpPost]
        public async Task<IActionResult> OnPostAsync(EditUserViewModel data)
        {
            var user = _userRepository.GetUser(data.User.Id);
            if (user == null)
            {
                return NotFound();
            }
            var userRolesInDb = await _signInManager.UserManager.GetRolesAsync(user);

            var rolesToAdd = new List<string>();
            var rolesToDelete = new List<string>();

            foreach (var role in data.Roles)
            {
                var assignedInDb = userRolesInDb.FirstOrDefault(ur => ur == role.Text);
                if (role.Selected)
                {
                    if (assignedInDb == null)
                    {
                        rolesToAdd.Add(role.Text);
                    }
                }
                else
                {
                    if (assignedInDb != null)
                    {
                        rolesToDelete.Add(role.Text);
                    }
                }
            }

            if (rolesToAdd.Any())
            {
                await _signInManager.UserManager.AddToRolesAsync(user, rolesToAdd);
            }

            if (rolesToDelete.Any())
            {
                await _signInManager.UserManager.RemoveFromRolesAsync(user, rolesToDelete);
            }

            user.FirstName = data.User.FirstName;
            user.LastName = data.User.LastName;
            user.Email = data.User.Email;

            _userRepository.UpdateUser(data.User);
            return RedirectToAction("Edit", new { id = user.Id });
        }
    }
}
