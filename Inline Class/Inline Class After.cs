using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inline_Class
{
    internal class Inline_Class_After
    {
        class EmptyClass
        {
            // Lớp này không có phương thức hay thuộc tính
        }

        class MainClass
        {
            public void ProcessData(string data)
            {
                Console.WriteLine($"Processing data: {data}");
            }
        }

        class Program
        {
            static void Main()
            {
                // Tạo đối tượng của EmptyClass (mặc dù nó không làm gì cả)
                EmptyClass emptyObject = new EmptyClass();

                // Tạo đối tượng của MainClass và sử dụng chức năng của nó
                MainClass mainObject = new MainClass();
                mainObject.ProcessData("Sample Data");
            }
        }
    }
}
