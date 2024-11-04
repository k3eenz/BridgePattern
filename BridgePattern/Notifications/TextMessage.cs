using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Notifications
{
    public class TextMessage : MessageSend
    {
        public TextMessage(INotification sender, string senderName, string recipientName) : base(sender, senderName, recipientName) { }

        public override void Send(string message)
        {
            _sender.SendMessage(Sender, Recipient, $"Text message: {message}");
        }
    }
}
