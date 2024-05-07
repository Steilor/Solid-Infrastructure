using SOLID.S.OrderService;


namespace SOLID.O.ReportingService.Interfaces
{
    public interface IReportGenerator
    {
        void GenerateReport(List<Order> orders);
    }
}
