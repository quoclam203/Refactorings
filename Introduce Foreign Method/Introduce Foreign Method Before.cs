using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Introduce_Foreign_Method
{
    internal class Introduce_Foreign_Method_Before
    {
        class Report
        {
            // ...
            void sendReport()
            {
                Date nextDay = new Date(previousEnd.getYear(),
                  previousEnd.getMonth(), previousEnd.getDate() + 1);
                // ...
            }
        }
    }
}
