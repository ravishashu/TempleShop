using TheShop.Models;

namespace TheShop.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Items { get; }
        public string? CurrentCategory { get; }

        public ItemListViewModel(IEnumerable<Item> items, string? currentCategory)
        {
            Items = items;
            CurrentCategory = currentCategory;
        }
    }
}
