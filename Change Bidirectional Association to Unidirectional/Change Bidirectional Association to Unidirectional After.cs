using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Bidirectional_Association_to_Unidirectional
{
    internal class Change_Bidirectional_Association_to_Unidirectional_After
    {
        class B
        {
            public void DoSomethingB()
            {
                Console.WriteLine("B is doing something.");
            }
        }

        class A
        {
            public B BReference { get; set; }  // Mối quan hệ một chiều với lớp B

            public void DoSomethingA()
            {
                Console.WriteLine("A is doing something.");
            }
        }

        class Program
        {
            static void Main()
            {
                A a = new A();
                B b = new B();

                a.BReference = b;  // A tham chiếu đến B

                a.DoSomethingA();
                b.DoSomethingB();
            }
        }
    }
}
