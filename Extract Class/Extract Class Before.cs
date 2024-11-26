using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Class
{
    internal class Extract_Class_Before
    {
        class OrderProcessor
        {
            public void ProcessOrder(string orderDetails)
            {
                // Xử lý đơn hàng
                Console.WriteLine("Processing order: " + orderDetails);

                // Gửi email xác nhận
                SendEmailConfirmation(orderDetails);
            }

            private void SendEmailConfirmation(string orderDetails)
            {
                // Gửi email xác nhận đơn hàng
                Console.WriteLine("Sending email confirmation for order: " + orderDetails);
            }
        }

        class Program
        {
            static void Main()
            {
                OrderProcessor processor = new OrderProcessor();
                processor.ProcessOrder("Order #1234");
            }
        }
    }
}
