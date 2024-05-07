using SOLID.S.OrderService;
using SOLID.S.OrderService.Interfaces;


namespace SOLID.S.OrderService.Class
{
    public class NotificationService : INotification
    {
        public bool EmailInvoice(Order order)
        {
            return true;
        }
    }
}
