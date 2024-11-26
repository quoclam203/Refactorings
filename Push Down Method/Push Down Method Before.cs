using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Push_Down_Method
{
    internal class Push_Down_Method_Before
    {
        class SuperClass
        {
            // Lớp cha có một hành vi chung nhưng không phải mọi lớp con đều cần hành vi này
            public void DisplayMessage()
            {
                Console.WriteLine("SuperClass behavior.");
            }
        }

        class ClassA : SuperClass
        {
            public void SpecificMethodForA()
            {
                Console.WriteLine("ClassA specific method.");
            }
        }

        class ClassB : SuperClass
        {
            public void SpecificMethodForB()
            {
                Console.WriteLine("ClassB specific method.");
            }
        }

        class ClassC : SuperClass
        {
            // ClassC có thể không cần hành vi từ SuperClass
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

                // Gọi hành vi từ lớp cha chỉ cho một số lớp con
                objA.DisplayMessage();  // Hành vi này có thể áp dụng cho ClassA
                objB.DisplayMessage();  // Hành vi này có thể áp dụng cho ClassB

                // ClassC có thể không sử dụng hành vi DisplayMessage() từ SuperClass
                objC.AnotherSpecificMethod();
            }
        }
    }
}
