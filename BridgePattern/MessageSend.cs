using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class MessageSend
    {
        protected INotification _sender;
        protected string Sender { get; }
        protected string Recipient { get; }

        protected MessageSend(INotification sender, string senderName, string recipientName)
        {
            _sender = sender;
            Sender = senderName;
            Recipient = recipientName;
        }

        public abstract void Send(string message);
    }
}
