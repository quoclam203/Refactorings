using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_Delegate
{
    internal class Hide_Delegate_After
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

            // Phương thức gọi phương thức của B (lớp A phụ thuộc vào B)
            public void PerformAction()
            {
                Console.WriteLine("A is delegating the task to B.");
                b.DoSomething();  // A gọi phương thức của B
            }
        }

        class Program
        {
            static void Main()
            {
                A a = new A();
                a.PerformAction();  // Khách hàng gọi phương thức của A, A gọi B
            }
        }
    }
}
