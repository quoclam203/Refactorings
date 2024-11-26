using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Bidirectional_Association_to_Unidirectional
{
    internal class Change_Bidirectional_Association_to_Unidirectional_Before
    {
        class B
        {
            // Lớp B không sử dụng các tính năng của lớp A
            public void DoSomethingB()
            {
                Console.WriteLine("B is doing something.");
            }

            public A AReference { get; set; }  // Mối quan hệ hai chiều với lớp A
        }

        class A
        {
            public B BReference { get; set; }  // Mối quan hệ hai chiều với lớp B

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
                b.AReference = a;  // B tham chiếu đến A (nhưng B không sử dụng A)

                // A và B có thể gọi phương thức của mình mà không cần phụ thuộc vào nhau
                a.DoSomethingA();
                b.DoSomethingB();
            }
        }
    }
}
