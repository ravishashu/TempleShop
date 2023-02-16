namespace TheShop.Models
{
    public class ShopingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public ShopItem ShopItem { get; set; } = default!;
        public int Amount { get; set; }
        public string? ShoppingCartId { get; set; }
    }
}
