using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Preserve_Whole_Object
{
    internal class Preserve_Whole_Object_Before
    {
        int low = daysTempRange.getLow();
        int high = daysTempRange.getHigh();
        boolean withinPlan = plan.withinRange(low, high);
    }
}
