using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Conditional_with_Polymorphism
{
    internal class Replace_Conditional_with_Polymorphism_Before
    {
        class Bird
        {
            // ...
            double getSpeed()
            {
                switch (type)
                {
                    case EUROPEAN:
                        return getBaseSpeed();
                    case AFRICAN:
                        return getBaseSpeed() - getLoadFactor() * numberOfCoconuts;
                    case NORWEGIAN_BLUE:
                        return (isNailed) ? 0 : getBaseSpeed(voltage);
                }
                throw new RuntimeException("Should be unreachable");
            }
        }
    }
}
