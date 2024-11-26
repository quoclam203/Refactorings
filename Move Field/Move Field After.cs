using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Field
{
    internal class Move_Field_After
    {
        class OldClass
        {
            // Trường cũ trong OldClass
            public int OldField;

            public OldClass(int value)
            {
                OldField = value;
            }

            public void DisplayOldField()
            {
                Console.WriteLine($"OldField in OldClass: {OldField}");
            }
        }

        class Program
        {
            static void Main()
            {
                OldClass obj = new OldClass(10);

                // Sử dụng trường cũ
                obj.DisplayOldField();
            }
        }
    }
}
