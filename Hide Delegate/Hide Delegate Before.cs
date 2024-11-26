using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_Delegate
{
    internal class Hide_Delegate_Before
    {
        class B
        {
            public void DoSomething()
            {
                Console.WriteLine("B is doing something.");
            }
        }

        class A
        {
            private B b = new B();

            // Phương thức trả về đối tượng B
            public B GetB()
            {
                return b;
            }

            // Phương thức gọi phương thức của B
            public void PerformAction()
            {
                b.DoSomething();  // A gọi phương thức của B
            }
        }

        class Program
        {
            static void Main()
            {
                A a = new A();
                a.PerformAction();  // A thực hiện hành động gọi phương thức của B

                // Khách hàng (client) có thể nhận đối tượng B và gọi phương thức của B
                B b = a.GetB();
                b.DoSomething();  // Khách hàng gọi phương thức của B trực tiếp
            }
        }
    }
}
