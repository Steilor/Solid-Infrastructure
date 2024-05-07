using SOLID.S.OrderService;

namespace SOLID.S.OrderService.Interfaces
{
    public interface INotification
    {
        bool EmailInvoice(Order order);

    }
}
