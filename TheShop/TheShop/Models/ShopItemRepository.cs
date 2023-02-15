using Microsoft.EntityFrameworkCore;

namespace TheShop.Models
{
    public class ShopItemRepository : IShopItemRepository
    {
        private readonly TheShopDBContext _dbContext;
        public ShopItemRepository(TheShopDBContext theShopDBContext)
        {
            _dbContext = theShopDBContext;
        }

        public IEnumerable<ShopItem> AllShopItems => _dbContext.ShopItems.Include(c=>c.Category);

        public IEnumerable<ShopItem> ItemsOfTheWeek => _dbContext.ShopItems.Include(c => c.Category).Where(p=>p.IsItemOfTheWeek==true);

        public ShopItem? GetItemById(int ItemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShopItem> SearchItems(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}