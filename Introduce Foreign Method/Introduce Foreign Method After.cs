using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Introduce_Foreign_Method
{
    internal class Introduce_Foreign_Method_After
    {
        class Report
        {
            // ...
            void sendReport()
            {
                Date newStart = nextDay(previousEnd);
                // ...
            }
            private static Date nextDay(Date arg)
            {
                return new Date(arg.getYear(), arg.getMonth(), arg.getDate() + 1);
            }
        }
    }
}
