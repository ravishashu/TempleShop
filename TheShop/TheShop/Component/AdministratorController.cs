using Microsoft.AspNetCore.Mvc;

namespace TheShop.Component
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
