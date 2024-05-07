using SOLID.S.OrderService;

namespace SOLID.S.OrderService.Interfaces
{
    public interface IOrderRepository
    {
        public bool InserOrder(Order order);
    }
}
