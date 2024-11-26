using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inline_Temp
{
    internal class Inline_Temp_After
    {
        boolean hasDiscount(Order order)
        {
            return order.basePrice() > 1000;
        }
    }
}
