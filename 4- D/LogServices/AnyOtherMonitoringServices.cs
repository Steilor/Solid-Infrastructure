using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4__D.LogServices
{
    public class AnyOtherMonitoringServices : IEventNotification
    {
        public void LogEvent(string message)
        {
            //Code to log any other event
        }
    }
}
