using SOLID._3__I.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3__I
{
    public class Principle
    {
      public void OrderRice(RiceOrderService riceOrderService)
      {
            riceOrderService.OrderRice(5);
      }
    }
}
