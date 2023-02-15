namespace TheShop.Models
{
    public interface IShopItemRepository
    {
        IEnumerable<ShopItem> AllShopItems { get; }
        IEnumerable<ShopItem> ItemsOfTheWeek { get; }
        ShopItem? GetItemById(int ItemId);
        IEnumerable<ShopItem> SearchItems(string searchQuery);
    }
}