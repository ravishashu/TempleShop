using Microsoft.AspNetCore.Mvc;
using TheShop.Models;
using TheShop.ViewModels;

namespace TheShop.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IItemRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Cheese cakes";

            //return View(_pieRepository.AllPies);

            ItemListViewModel piesListViewModel = new ItemListViewModel(_itemRepository.AllItems, "Cheese cakes");
            return View(piesListViewModel);
        }
    }
}
