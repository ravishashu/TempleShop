using Microsoft.AspNetCore.Mvc;
using TheShop.Models;
using TheShop.ViewModels;

namespace TheShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _shopRepository;

        public HomeController(IProductRepository pieRepository)
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
