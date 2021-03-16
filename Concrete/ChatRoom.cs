using ChatRoomWithMediatorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomWithMediatorPattern.Concrete
{
    public class ChatRoom : IChatMediator
    {
        private List<User> _users;
        public ChatRoom()
        {
            _users = new List<User>();
        }
        public void Register(User user)
        {
            if (!_users.Contains(user))
            {
                _users.Add(user);
                user.SetChat(this);
            }
        }

        public void SendMessage(string from, string message, string toUser)
        {
            User user = FindUser(toUser);
            if (user == null)
            {
                BroadcastMessage(from, message);
            } else
            {
                user.Notify(from, message);
            }
        }

        private User FindUser(string nick)
        {
            foreach (var user in _users)
            {
                if (user.NickName == nick)
                {
                    return user;
                }
            }
            return null;
        }

        private void BroadcastMessage(string from,string msg)
        {
            foreach (var user in _users)
            {
                if (user.NickName != from)
                {
                    user.Notify(from, msg);
                }
            }
        }
    }
}
