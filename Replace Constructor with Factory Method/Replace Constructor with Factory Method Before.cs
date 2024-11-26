using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Constructor_with_Factory_Method
{
    internal class Replace_Constructor_with_Factory_Method_Before
    {
        class Employee
        {
            Employee(int type)
            {
                this.type = type;
            }
            // ...
        }
    }
}
