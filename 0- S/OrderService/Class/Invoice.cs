using SOLID.S.OrderService;
using SOLID.S.OrderService.Interfaces;


namespace SOLID.S.OrderService.Class
{
    public class Invoice : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            return new Invoice();
        }
    }
}
