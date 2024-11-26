using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Parameter_with_Explicit_Methods
{
    internal class Replace_Parameter_with_Explicit_Methods_Before
    {
        void setValue(String name, int value)
        {
            if (name.equals("height"))
            {
                height = value;
                return;
            }
            if (name.equals("width"))
            {
                width = value;
                return;
            }
            Assert.shouldNeverReachHere();
        }
    }
}
