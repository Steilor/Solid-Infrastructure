namespace SOLID.S.OrderService
{
    public class Order
    {
        private readonly List<Order> _orders;
        public Order(List<Order> orders)
        {
            _orders = orders;

        }

    }
}
