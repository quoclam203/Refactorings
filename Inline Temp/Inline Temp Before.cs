using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inline_Temp
{
    internal class Inline_Temp_Before
    {
        boolean hasDiscount(Order order)
        {
            double basePrice = order.basePrice();
            return basePrice > 1000;
        }
    }
}
