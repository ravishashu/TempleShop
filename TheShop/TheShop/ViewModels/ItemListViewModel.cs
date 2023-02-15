using TheShop.Models;

namespace TheShop.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<ShopItem> Items { get; }
        public string? CurrentCategory { get; }

        public ItemListViewModel(IEnumerable<ShopItem> items, string? currentCategory)
        {
            Items = items;
            CurrentCategory = currentCategory;
        }
    }
}
