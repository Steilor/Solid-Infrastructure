using SOLID.O.ReportingService;
using SOLID.O.ReportingService.Class;
using SOLID.O.ReportingService.Interfaces;
using SOLID.S.OrderService;

namespace SOLID
{
    internal class Program
    {
        static void Main()
        {
           List<Order> orders = new List<Order>(); //Get Orders from data source
           

            ReportingService service = new ReportingService(new ReportGeneratorXML()); //Send implementation
            service.GenerateReport(orders);

        }
    }
}
