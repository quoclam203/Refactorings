using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Nested_Conditional_with_Guard_Clauses
{
    internal class Replace_Nested_Conditional_with_Guard_Clauses_Before
    {
        public double getPayAmount()
        {
            double result;
            if (isDead)
            {
                result = deadAmount();
            }
            else
            {
                if (isSeparated)
                {
                    result = separatedAmount();
                }
                else
                {
                    if (isRetired)
                    {
                        result = retiredAmount();
                    }
                    else
                    {
                        result = normalPayAmount();
                    }
                }
            }
            return result;
        }
    }
}
