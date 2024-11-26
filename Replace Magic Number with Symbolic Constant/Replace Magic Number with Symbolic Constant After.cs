using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Magic_Number_with_Symbolic_Constant
{
    internal class Replace_Magic_Number_with_Symbolic_Constant_After
    {
        static final double GRAVITATIONAL_CONSTANT = 9.81;

        double potentialEnergy(double mass, double height)
        {
            return mass * height * GRAVITATIONAL_CONSTANT;
        }
    }
}
