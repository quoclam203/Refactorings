using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Push_Down_Field
{
    internal class Push_Down_Field_After
    {
        class SuperClass
        {
            // Lớp cha không có trường nữa
        }

        class ClassA : SuperClass
        {
            public int FieldA;  // Trường chỉ sử dụng trong ClassA

            public ClassA(int field)
            {
                FieldA = field;
            }

            public void DisplayFieldA()
            {
                Console.WriteLine($"ClassA Field: {FieldA}");
            }
        }

        class ClassB : SuperClass
        {
            public int FieldB;  // Trường chỉ sử dụng trong ClassB

            public ClassB(int field)
            {
                FieldB = field;
            }

            public void DisplayFieldB()
            {
                Console.WriteLine($"ClassB Field: {FieldB}");
            }
        }

        class ClassC : SuperClass
        {
            // ClassC không cần trường nào từ lớp cha
            public void SpecificMethodForC()
            {
                Console.WriteLine("ClassC specific method.");
            }
        }

        class Program
        {
            static void Main()
            {
                // Tạo đối tượng của các lớp con
                ClassA objA = new ClassA(10);
                ClassB objB = new ClassB(20);
                ClassC objC = new ClassC();

                // Gọi phương thức và trường của các lớp con
                objA.DisplayFieldA();  // Trường FieldA của ClassA
                objB.DisplayFieldB();  // Trường FieldB của ClassB

                // ClassC không có trường FieldA hay FieldB
                objC.SpecificMethodForC();
            }
        }
    }
}
