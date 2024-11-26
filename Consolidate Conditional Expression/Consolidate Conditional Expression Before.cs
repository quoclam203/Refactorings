using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidate_Conditional_Expression
{
    internal class Consolidate_Conditional_Expression_Before
    {
        double disabilityAmount()
        {
            if (seniority < 2)
            {
                return 0;
            }
            if (monthsDisabled > 12)
            {
                return 0;
            }
            if (isPartTime)
            {
                return 0;
            }
            // Compute the disability amount.
            // ...
        }
    }
}
