using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Nested_Conditional_with_Guard_Clauses
{
    internal class Replace_Nested_Conditional_with_Guard_Clauses_After
    {
        public double getPayAmount()
        {
            if (isDead)
            {
                return deadAmount();
            }
            if (isSeparated)
            {
                return separatedAmount();
            }
            if (isRetired)
            {
                return retiredAmount();
            }
            return normalPayAmount();
        }
    }
}
