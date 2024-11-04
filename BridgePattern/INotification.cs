using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface INotification
    {
        void SendMessage(string sender, string recipient, string messageText);
    }
}
