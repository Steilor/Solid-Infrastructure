using SOLID.S.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4__D
{    
    public class OrderService
    {
        private readonly IEventNotification _eventNotification;

        public OrderService(IEventNotification eventNotification)
        {
            _eventNotification = eventNotification;
        }
        public void GenerateOrder(Order order)
        {
            //TODO: codigo crear orden

            // Send notification to datadog
            _eventNotification.LogEvent("The Order was succesfully created");
        }
    }

    /*public class DataDogService
    {
        public void LogEvent(string message)
        {
            //Code to event on DataDog
        }
    }*/
}
