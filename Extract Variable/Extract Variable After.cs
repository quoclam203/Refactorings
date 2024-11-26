using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Variable
{
    internal class Extract_Variable_After
    {
        void renderBanner()
        {
            final boolean isMacOs = platform.toUpperCase().indexOf("MAC") > -1;
            final boolean isIE = browser.toUpperCase().indexOf("IE") > -1;
            final boolean wasResized = resize > 0;

            if (isMacOs && isIE && wasInitialized() && wasResized)
            {
                // do something
            }
        }
    }
}
