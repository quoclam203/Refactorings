using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Temp_with_Query
{
    internal class Replace_Temp_with_Query_After
    {
        double calculateTotal()
        {
            if (basePrice() > 1000)
            {
                return basePrice() * 0.95;
            }
            else
            {
                return basePrice() * 0.98;
            }
        }
        double basePrice()
        {
            return quantity * itemPrice;
        }
    }
}
