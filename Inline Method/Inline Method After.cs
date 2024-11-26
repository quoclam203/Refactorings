using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inline_Method
{
    internal class Inline_Method_After
    {
        class PizzaDelivery
        {
            // ...
            int getRating()
            {
                return numberOfLateDeliveries > 5 ? 2 : 1;
            }
        }
    }
}
