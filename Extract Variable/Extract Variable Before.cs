using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Variable
{
    internal class Extract_Variable_Before
    {
        void renderBanner()
        {
            if ((platform.toUpperCase().indexOf("MAC") > -1) &&
                 (browser.toUpperCase().indexOf("IE") > -1) &&
                  wasInitialized() && resize > 0)
            {
                // do something
            }
        }
    }
}
