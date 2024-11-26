using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Error_Code_with_Exception
{
    internal class Replace_Error_Code_with_Exception_Before
    {
        int withdraw(int amount)
        {
            if (amount > _balance)
            {
                return -1;
            }
            else
            {
                balance -= amount;
                return 0;
            }
        }
    }
}
