using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Without_DIP.Notification withoutDIPNotification = new Without_DIP.Notification();
            withoutDIPNotification.Send();
            Console.WriteLine();

            DIP.Email email1 = new DIP.Email()
            {
                ToAddress = "pruthvi@mail.com",
                Subject = "Test email",
                Content = "This is just test, to test email."
            };

            DIP.SMS sms1 = new DIP.SMS()
            {
                PhoneNumber = "XXX-XXX-6263",
                Message = "Test message"
            };

            List<DIP.IMessage> messages = new List<DIP.IMessage>();
            messages.Add(email1);
            messages.Add(sms1);

            DIP.Notification dipNotification = new DIP.Notification(messages);
            dipNotification.Send();

            Console.ReadLine();
        }
    }
}
