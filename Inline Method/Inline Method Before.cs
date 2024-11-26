using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inline_Method
{
    internal class Inline_Method
    {
        class PizzaDelivery
        {
            // ...
            int getRating()
            {
                return moreThanFiveLateDeliveries() ? 2 : 1;
            }
            boolean moreThanFiveLateDeliveries()
            {
                return numberOfLateDeliveries > 5;
            }
        }
    }
}
