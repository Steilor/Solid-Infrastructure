﻿using SOLID.O.ReportingService.Interfaces;
using SOLID.S.OrderService;

namespace SOLID.O.ReportingService.Class
{
    public class ReportGeneratorExcel : IReportGenerator
    {
        public void GenerateReport(List<Order> orders)
        {
            //Create Excel Report
        }
    }
}
