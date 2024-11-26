using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Class
{
    internal class Extract_Class_After
    {
        class OrderProcessor
        {
            public int OrderId { get; set; }
            public string CustomerEmail { get; set; }
            public double OrderAmount { get; set; }

            public OrderProcessor(int orderId, string customerEmail, double orderAmount)
            {
                OrderId = orderId;
                CustomerEmail = customerEmail;
                OrderAmount = orderAmount;
            }

            // Xử lý đơn hàng
            public void ProcessOrder()
            {
                Console.WriteLine($"Processing Order ID: {OrderId}");
                // Giả sử thực hiện các bước xử lý đơn hàng như tính toán, lưu trữ v.v.
            }

            // Gửi email xác nhận
            public void SendEmailConfirmation()
            {
                Console.WriteLine($"Sending email to {CustomerEmail} for Order ID: {OrderId}");
            }
        }

        class Program
        {
            static void Main()
            {
                OrderProcessor processor = new OrderProcessor(1234, "customer@example.com", 150.75);

                // Xử lý đơn hàng
                processor.ProcessOrder();

                // Gửi email xác nhận
                processor.SendEmailConfirmation();
            }
        }
        Giải thích:
Lớp OrderProcessor: Lớp này đảm nhận cả hai chức năng: xử lý đơn hàng và gửi email xác nhận.
Khi mã này phức tạp hoặc cần thay đổi, việc thay đổi một trong các chức năng có thể ảnh hưởng đến phần còn lại của mã.
Mã C# sau khi tách chức năng:
Chúng ta sẽ tạo một lớp mới EmailSender để chỉ chịu trách nhiệm gửi email, và giữ lại lớp OrderProcessor chỉ chịu trách nhiệm xử lý đơn hàng.

csharp
Sao chép mã
using System;

class OrderProcessor
    {
        public int OrderId { get; set; }
        public double OrderAmount { get; set; }
        private EmailSender emailSender;

        public OrderProcessor(int orderId, double orderAmount, EmailSender emailSender)
        {
            OrderId = orderId;
            OrderAmount = orderAmount;
            this.emailSender = emailSender;
        }

        // Xử lý đơn hàng
        public void ProcessOrder()
        {
            Console.WriteLine($"Processing Order ID: {OrderId}");
            // Giả sử thực hiện các bước xử lý đơn hàng như tính toán, lưu trữ v.v.
        }

        // Gửi email xác nhận
        public void SendEmailConfirmation()
        {
            emailSender.SendEmail(OrderId); // Gọi phương thức từ EmailSender để gửi email
        }
    }

    class EmailSender
    {
        public void SendEmail(int orderId)
        {
            // Gửi email xác nhận
            Console.WriteLine($"Sending email for Order ID: {orderId}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Tạo đối tượng EmailSender
            EmailSender emailSender = new EmailSender();

            // Tạo đối tượng OrderProcessor và truyền vào EmailSender
            OrderProcessor processor = new OrderProcessor(1234, 150.75, emailSender);

            // Xử lý đơn hàng
            processor.ProcessOrder();

            // Gửi email xác nhận
            processor.SendEmailConfirmation();
        }
    }
}
}
