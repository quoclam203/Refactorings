using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Parameter_with_Method_Call
{
    internal class Replace_Parameter_with_Method_Call_Before
    {
        int basePrice = quantity * itemPrice;
        double seasonDiscount = this.getSeasonalDiscount();
        double fees = this.getFees();
        double finalPrice = discountedPrice(basePrice, seasonDiscount, fees);

    }
}
