namespace DIP
{
    using System.Collections.Generic;
    public class Notification
    {
        private List<IMessage> _messaes;
        public Notification(List<IMessage> messages)
        {
            this._messaes = messages;
        }

        public void Send()
        {
            foreach (var message in _messaes)
            {
                message.SendMessage();
            }
        }
    }
}
