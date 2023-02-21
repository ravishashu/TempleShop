using Microsoft.AspNetCore.Mvc;

namespace TheShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
