namespace TheShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
