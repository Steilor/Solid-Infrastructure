using SOLID.S.OrderService.Class;
using SOLID.S.OrderService.Interfaces;


namespace SOLID.S.OrderService
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IInvoiceService _invoiceService;
        private readonly ILoggerService _loggerService;
        private readonly INotification _notification;

        public OrderService(IOrderRepository orderRepository,
                            IInvoiceService invoiceService,
                            ILoggerService loggerService,
                            INotification notification)
        {
            _orderRepository = orderRepository;
            _invoiceService = invoiceService;
            _loggerService = loggerService;
            _notification = notification;
        }

        public void SaveOrder(Order order)
        {
            try
            {
                _orderRepository.InserOrder(order);
                var invoice = _invoiceService.CreateInvoice(order);
                _notification.EmailInvoice(order);
                _loggerService.Info("The Order has been complete");
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex.Message, ex);
            }

        }
    }
}
