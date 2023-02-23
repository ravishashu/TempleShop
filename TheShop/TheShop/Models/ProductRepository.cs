using Microsoft.EntityFrameworkCore;

namespace TheShop.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly TheShopDBContext _dbContext;
        public ProductRepository(TheShopDBContext theShopDBContext)
        {
            _dbContext = theShopDBContext;
        }

        public IEnumerable<Product> AllProducts => _dbContext.Products.Include(c=>c.Category);

        public IEnumerable<Product> ItemsOfTheWeek => _dbContext.Products.Include(c => c.Category).Where(p=>p.IsItemOfTheWeek==true);

        public Product? GetItemById(int ItemId) => _dbContext.Products.SingleOrDefault(p=>p.ProductId==ItemId);
        

        public IEnumerable<Product> SearchProducts(string searchQuery)
        {
            return _dbContext.Products.Where(p => p.Name.Contains(searchQuery));
        }
    }
}