using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inline_Class
{
    internal class Inline_Class_Before
    {
        class EmptyClass
        {
            // Lớp này không có bất kỳ chức năng hoặc thuộc tính nào
        }

        class Program
        {
            static void Main()
            {
                // Tạo đối tượng của lớp trống
                EmptyClass emptyObject = new EmptyClass();

                // Không có phương thức hoặc thuộc tính nào để sử dụng từ lớp này
                Console.WriteLine("No functionality in EmptyClass.");
            }
        }
    }
}
