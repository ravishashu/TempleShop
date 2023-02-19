namespace TheShop.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> ItemsOfTheWeek { get; }
        Product? GetItemById(int ItemId);
        IEnumerable<Product> SearchItems(string searchQuery);
    }
}