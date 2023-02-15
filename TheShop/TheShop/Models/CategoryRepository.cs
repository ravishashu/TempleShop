namespace TheShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TheShopDBContext _dbContext;
        public CategoryRepository(TheShopDBContext theShopDBContext)
        {
            _dbContext = theShopDBContext;
        }
                
        public IEnumerable<Category> AllCategories =>  _dbContext.Categories.OrderBy(p=>p.CategoryName);
    }
}