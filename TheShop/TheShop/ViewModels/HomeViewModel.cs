using TheShop.Models;

namespace TheShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<ShopItem> ShopItemOfTheWeek { get; }

        public HomeViewModel(IEnumerable<ShopItem> shopItemOfTheWeek)
        {
            ShopItemOfTheWeek = shopItemOfTheWeek;
        }
    }
}
