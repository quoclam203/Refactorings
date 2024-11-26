using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Self_Encapsulate_Field
{
    internal class Self_Encapsulate_Field_Before
    {
        class Range
        {
            private int low, high;
            boolean includes(int arg)
            {
                return arg >= low && arg <= high;
            }
        }

    }
}
