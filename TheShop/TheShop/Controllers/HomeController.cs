using Microsoft.AspNetCore.Mvc;
using TheShop.Models;
using TheShop.ViewModels;

namespace TheShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShopItemRepository _shopRepository;

        public HomeController(IShopItemRepository pieRepository)
        {
            _shopRepository = pieRepository;
        }

        public ViewResult Index()
        {
            var piesOfTheWeek = _shopRepository.ItemsOfTheWeek;

            var homeViewModel = new HomeViewModel(piesOfTheWeek);

            return View(homeViewModel);
        }
    }
}
