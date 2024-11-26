using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Error_Code_with_Exception
{
    internal class Replace_Error_Code_with_Exception_After
    {
        void withdraw(int amount) throws BalanceException
        {
  if (amount > _balance) {
    throw new BalanceException();
    }
    balance -= amount;
}
    }
}
