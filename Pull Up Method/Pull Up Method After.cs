using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pull_Up_Method
{
    internal class Pull_Up_Method_After
    {
        class SuperClass
        {
            public int Field;  // Trường chung trong lớp cha

            public SuperClass(int field)
            {
                Field = field;  // Khởi tạo trường trong lớp cha
            }

            // Phương thức giống nhau trong cả hai lớp con
            public void DisplayField()
            {
                Console.WriteLine($"Giá trị trường: {Field}");
            }

            // Phương thức giống nhau trong cả hai lớp con
            public void ProcessField()
            {
                Console.WriteLine($"Processing field value: {Field}");
            }
        }

        class ClassA : SuperClass
        {
            public ClassA(int field) : base(field) { }
        }

        class ClassB : SuperClass
        {
            public ClassB(int field) : base(field) { }
        }

        class Program
        {
            static void Main()
            {
                // Tạo đối tượng từ ClassA và ClassB
                ClassA objA = new ClassA(10);
                ClassB objB = new ClassB(20);

                // Gọi các phương thức giống nhau từ lớp cha
                objA.DisplayField();
                objA.ProcessField();

                objB.DisplayField();
                objB.ProcessField();
            }
        }
    }
}
