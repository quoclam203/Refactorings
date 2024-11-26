using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Constructor_with_Factory_Method
{
    internal class Replace_Constructor_with_Factory_Method_After
    {
        class Employee
        {
            static Employee create(int type)
            {
                employee = new Employee(type);
                // do some heavy lifting.
                return employee;
            }
            // ...
        }
    }
}
