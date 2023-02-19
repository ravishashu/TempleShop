using TheShop.Models;

namespace TheShop.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Product> Items { get; }
        public string? CurrentCategory { get; }

        public ItemListViewModel(IEnumerable<Product> items, string? currentCategory)
        {
            Items = items;
            CurrentCategory = currentCategory;
        }
    }
}
