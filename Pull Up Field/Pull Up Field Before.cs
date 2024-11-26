using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pull_Up_Field
{
    internal class Pull_Up_Field_Before
    {
        class ClassA
        {
            public int Field;  // Trường chung

            public ClassA(int field)
            {
                Field = field;  // Khởi tạo trường
            }
        }

        class ClassB
        {
            public int Field;  // Trường chung

            public ClassB(int field)
            {
                Field = field;  // Khởi tạo trường
            }
        }

        class Program
        {
            static void Main()
            {
                // Tạo đối tượng từ ClassA và ClassB
                ClassA objA = new ClassA(10);
                ClassB objB = new ClassB(20);

                // In giá trị của trường từ cả hai lớp
                Console.WriteLine($"Giá trị trường trong ClassA: {objA.Field}");
                Console.WriteLine($"Giá trị trường trong ClassB: {objB.Field}");
            }
        }
    }
}
