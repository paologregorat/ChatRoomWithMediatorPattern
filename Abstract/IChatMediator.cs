using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomWithMediatorPattern.Abstract
{
    public interface IChatMediator
    {
        public void Register(User user);
        public void SendMessage(string from, string message, string toUser);
    }
}
