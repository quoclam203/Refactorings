using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pull_Up_Field
{
    internal class Pull_Up_Field_After
    {
        class SuperClass
        {
            public int Field;  // Trường chung trong lớp cha

            public SuperClass(int field)
            {
                Field = field;  // Khởi tạo trường trong lớp cha
            }
        }

        class ClassA : SuperClass
        {
            // Không cần khai báo lại Field, vì đã kế thừa từ SuperClass
            public ClassA(int field) : base(field) { }
        }

        class ClassB : SuperClass
        {
            // Không cần khai báo lại Field, vì đã kế thừa từ SuperClass
            public ClassB(int field) : base(field) { }
        }

        class Program
        {
            static void Main()
            {
                // Tạo đối tượng từ ClassA và ClassB
                ClassA objA = new ClassA(10);
                ClassB objB = new ClassB(20);

                // In giá trị của trường từ cả hai lớp con
                Console.WriteLine($"Giá trị trường trong ClassA: {objA.Field}");
                Console.WriteLine($"Giá trị trường trong ClassB: {objB.Field}");
            }
        }
    }
}
