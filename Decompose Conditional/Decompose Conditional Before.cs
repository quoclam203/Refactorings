using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decompose_Conditional
{
    internal class Decompose_Conditional_Before
    {
        if (date.before(SUMMER_START) || date.after(SUMMER_END)) {
        charge = quantity* winterRate + winterServiceCharge;
}
            else {
         charge = quantity* summerRate;
        }
    }
}
