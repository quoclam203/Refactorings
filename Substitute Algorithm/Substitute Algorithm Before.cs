using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitute_Algorithm
{
    internal class Substitute_Algorithm_Before
    {
        String foundPerson(String[] people)
        {
            for (int i = 0; i < people.length; i++)
            {
                if (people[i].equals("Don"))
                {
                    return "Don";
                }
                if (people[i].equals("John"))
                {
                    return "John";
                }
                if (people[i].equals("Kent"))
                {
                    return "Kent";
                }
            }
            return "";
        }

    }
}
