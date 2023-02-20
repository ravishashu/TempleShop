using TheShop.Models;

namespace TheShop.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Items { get; }
        public string? CurrentCategory { get; }

        public ProductListViewModel(IEnumerable<Product> items, string? currentCategory)
        {
            Items = items;
            CurrentCategory = currentCategory;
        }
    }
}
