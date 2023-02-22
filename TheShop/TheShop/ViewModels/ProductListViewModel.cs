using TheShop.Models;

namespace TheShop.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Product { get; }
        public string? CurrentCategory { get; }

        public ProductListViewModel(IEnumerable<Product> Product, string? currentCategory)
        {
            this.Product = Product;
            CurrentCategory = currentCategory;
        }
    }
}
