using TheShop.Models;

namespace TheShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductOfTheWeek { get; }

        public HomeViewModel(IEnumerable<Product> productOfTheWeek)
        {
            ProductOfTheWeek = productOfTheWeek;
        }
    }
}
