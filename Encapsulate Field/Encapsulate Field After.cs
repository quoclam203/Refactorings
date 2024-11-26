using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate_Field
{
    internal class Encapsulate_Field_After
    {
        class Person
        {
            private String name;

            public String getName()
            {
                return name;
            }
            public void setName(String arg)
            {
                name = arg;
            }
        }
    }
}
