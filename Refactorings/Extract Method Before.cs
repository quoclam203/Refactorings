﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Refactorings
{
    internal class Extract_Method
    {
        void printOwing()
        {
            printBanner();

            // Print details.
            System.out.println("name: " + name);
            System.out.println("amount: " + getOutstanding());
        }

    }
}
