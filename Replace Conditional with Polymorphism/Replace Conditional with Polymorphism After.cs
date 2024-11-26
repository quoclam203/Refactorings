using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Conditional_with_Polymorphism
{
    internal class Replace_Conditional_with_Polymorphism_After
    {
        abstract class Bird
        {
            // ...
            abstract double getSpeed();
        }

        class European extends Bird
        {
  double getSpeed()
        {
            return getBaseSpeed();
        }
    }
    class African extends Bird
    {
  double getSpeed() {
            return getBaseSpeed() - getLoadFactor() * numberOfCoconuts;
        }
    }
    class NorwegianBlue extends Bird
    {
  double getSpeed() {
            return (isNailed) ? 0 : getBaseSpeed(voltage);
        }
    }

    // Somewhere in client code
    speed = bird.getSpeed();
    }
}
