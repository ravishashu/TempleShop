using Microsoft.AspNetCore.Mvc;
using TheShop.Models;
using TheShop.ViewModels;

namespace TheShop.Controllers
{
    public class ItemController : Controller
    {
        private readonly IShopItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IShopItemRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Cheese cakes";

            //return View(_pieRepository.AllPies);

            ItemListViewModel piesListViewModel = new ItemListViewModel(_itemRepository.AllShopItems, "Cheese cakes");
            return View(piesListViewModel);
        }
    }
}
