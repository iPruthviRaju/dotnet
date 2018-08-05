using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_DIP
{
    public class Notification
    {
        private Email _email;
        private SMS _sms;
        public Notification()
        {
            _email = new Email()
            {
                ToAddress = "pruthvi@mail.com",
                Subject = "Test email",
                Content = "This is just test, to test email."
            };

            _sms = new SMS()
            {
                PhoneNumber = "XXX-XXX-6263",
                Message = "Test message"
            };
        }
        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}
