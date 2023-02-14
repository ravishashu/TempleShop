namespace TheShop.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> AllItems { get; }
        IEnumerable<Item> ItemsOfTheWeek { get; }
        Item? GetItemById(int ItemId);
        IEnumerable<Item> SearchItems(string searchQuery);
    }
}