using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Method_with_Method_Object
{
    internal class Replace_Method_with_Method_Object_After
    {

        class Order
        {
            // ...
            public double price()
            {
                return new PriceCalculator(this).compute();
            }
        }

        class PriceCalculator
        {
            private double primaryBasePrice;
            private double secondaryBasePrice;
            private double tertiaryBasePrice;

            public PriceCalculator(Order order)
            {
                // Copy relevant information from the
                // order object.
            }

            public double compute()
            {
                // Perform long computation.
            }

        }
    }
}
