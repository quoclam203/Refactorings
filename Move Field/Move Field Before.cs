using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Field
{
    internal class Move_Field_Before
    {
        class ClassA
        {
            // Lớp ClassA không còn trường FieldA nữa
            // Trường này được di chuyển vào ClassB vì nó được sử dụng nhiều hơn ở đó
        }

        class ClassB
        {
            // Trường FieldA được di chuyển vào ClassB
            public int FieldA;

            public ClassB(int value)
            {
                FieldA = value; // Khởi tạo trường FieldA trong ClassB
            }

            public void UseFieldInClassB()
            {
                // Dùng FieldA trong ClassB
                Console.WriteLine($"Using FieldA in ClassB: {FieldA}");
            }
        }

        class Program
        {
            static void Main()
            {
                // Tạo đối tượng ClassB, trong đó ClassB chứa và sử dụng FieldA
                ClassB objB = new ClassB(10);

                // Gọi phương thức trong ClassB sử dụng FieldA từ ClassB
                objB.UseFieldInClassB();
            }
        }
    }
}
