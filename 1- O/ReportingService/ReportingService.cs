using SOLID.O.ReportingService.Interfaces;
using SOLID.S.OrderService;


namespace SOLID.O.ReportingService
{
    public class ReportingService
    {
        private readonly IReportGenerator _reportGenerator;

        public ReportingService(IReportGenerator reportGenerator)
        {
            _reportGenerator = reportGenerator;
        }

        public void GenerateReport(List<Order> orders)
        {
            _reportGenerator.GenerateReport(orders);
        }

    }
}
