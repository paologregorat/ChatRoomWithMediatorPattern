using ChatRoomWithMediatorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomWithMediatorPattern.Concrete
{
    public class ChatUser : User
    {
        public ChatUser(string nickName)
        {
            this.NickName = nickName;
        }
        public override void Notify(string from, string msg)
        {
            Console.WriteLine("L'utente: " + this.NickName + " ha ricevuto il messaggio: " + msg + " dall'utente: " + from );
        }

        public override void Send(string msg, string user)
        {
            this._chat.SendMessage(NickName, msg, user);
        }
    }
}
