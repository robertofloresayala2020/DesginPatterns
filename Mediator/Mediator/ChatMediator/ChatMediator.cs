using ChatMediator.Interface;
using ChatMediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMediator
{
    public class ChatMediator :IChatMediator
    {

        private List<User> users;

        public ChatMediator()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (User u in users)
            {
                // message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
