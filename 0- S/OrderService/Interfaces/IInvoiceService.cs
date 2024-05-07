using SOLID.S.OrderService;
using SOLID.S.OrderService.Class;


namespace SOLID.S.OrderService.Interfaces
{
    public interface IInvoiceService
    {
        Invoice CreateInvoice(Order order);
    }
}
