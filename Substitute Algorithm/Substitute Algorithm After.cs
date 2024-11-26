using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Substitute_Algorithm
{
    internal class Substitute_Algorithm_After
    {
        String foundPerson(String[] people)
        {
            List candidates =
              Arrays.asList(new String[] { "Don", "John", "Kent" });
            for (int i = 0; i < people.length; i++)
            {
                if (candidates.contains(people[i]))
                {
                    return people[i];
                }
            }
            return "";
        }
    }
}
