using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomWithMediatorPattern.Abstract
{
    public abstract class User
    {
        protected IChatMediator _chat;
        public string NickName { get; set; }
        public void SetChat(IChatMediator chat)
        {
            _chat = chat;
            Send("Entrato in chat", null);
        }

        public abstract void Notify(string from, string msg);
        public abstract void Send(string msg, string user);
    }
}
