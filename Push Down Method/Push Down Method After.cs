using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Push_Down_Method
{
    internal class Push_Down_Method_After
    {
        class SuperClass
        {
            // Không còn hành vi chung ở lớp cha nữa
        }

        class ClassA : SuperClass
        {
            // Chỉ ClassA có hành vi này
            public void DisplayMessage()
            {
                Console.WriteLine("ClassA behavior.");
            }

            public void SpecificMethodForA()
            {
                Console.WriteLine("ClassA specific method.");
            }
        }

        class ClassB : SuperClass
        {
            // Chỉ ClassB có hành vi này
            public void DisplayMessage()
            {
                Console.WriteLine("ClassB behavior.");
            }

            public void SpecificMethodForB()
            {
                Console.WriteLine("ClassB specific method.");
            }
        }

        class ClassC : SuperClass
        {
            // ClassC không có hành vi DisplayMessage
            public void AnotherSpecificMethod()
            {
                Console.WriteLine("ClassC specific method.");
            }
        }

        class Program
        {
            static void Main()
            {
                // Tạo đối tượng của các lớp con
                ClassA objA = new ClassA();
                ClassB objB = new ClassB();
                ClassC objC = new ClassC();

                // Gọi hành vi riêng của từng lớp con
                objA.DisplayMessage();  // Hành vi chỉ có trong ClassA
                objB.DisplayMessage();  // Hành vi chỉ có trong ClassB

                // ClassC không có hành vi DisplayMessage
                objC.AnotherSpecificMethod();
            }
        }
    }
}
