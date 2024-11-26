using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pull_Up_Method
{
    internal class Pull_Up_Method_Before
    {
        class SuperClass
        {
            public int Field;  // Trường chung trong lớp cha

            public SuperClass(int field)
            {
                Field = field;  // Khởi tạo trường trong lớp cha
            }

            // Phương thức chung cho các lớp con
            public void DisplayField()
            {
                Console.WriteLine($"Giá trị trường: {Field}");
            }
        }

        class ClassA : SuperClass
        {
            public ClassA(int field) : base(field) { }

            // Có thể thêm các phương thức riêng cho ClassA nếu cần
        }

        class ClassB : SuperClass
        {
            public ClassB(int field) : base(field) { }

            // Có thể thêm các phương thức riêng cho ClassB nếu cần
        }

        class Program
        {
            static void Main()
            {
                // Tạo đối tượng từ ClassA và ClassB
                ClassA objA = new ClassA(10);
                ClassB objB = new ClassB(20);

                // Gọi phương thức DisplayField từ lớp cha
                objA.DisplayField();
                objB.DisplayField();
            }
        }
    }
}
