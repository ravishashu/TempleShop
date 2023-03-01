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

        //public IActionResult List()
        //{
        //    //ViewBag.CurrentCategory = "Cheese cakes";

        //    //return View(_pieRepository.AllProducts);

        //    ItemListViewModel piesListViewModel = new ItemListViewModel(_itemRepository.AllProducts, "Cheese cakes");
        //    return View(piesListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Product> pies;
            string? currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _itemRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All Products";
            }
            else
            {
                pies = _itemRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel(pies, currentCategory));
        }

        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();

            return View(item);
        }

        public IActionResult Search()
        {
            return View();
        }

    }
}
