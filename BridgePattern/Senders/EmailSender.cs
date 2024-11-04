using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Senders
{
    public class EmailSender : INotification
    {
        public void SendMessage(string sender, string recipient, string messageText)
        {
            Console.WriteLine($"[Email]: {messageText}\n" +
                $"Отправитель: {sender}\n" +
                $"Получатель: {recipient} \n\n");
        }
    }
}
