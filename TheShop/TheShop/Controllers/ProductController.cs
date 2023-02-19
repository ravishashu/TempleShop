using Microsoft.AspNetCore.Mvc;
using TheShop.Models;
using TheShop.ViewModels;

namespace TheShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Cheese cakes";

            //return View(_pieRepository.AllPies);

            ItemListViewModel piesListViewModel = new ItemListViewModel(_itemRepository.AllProducts, "Cheese cakes");
            return View(piesListViewModel);
        }

        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();

            return View(item);
        }
    }
}
