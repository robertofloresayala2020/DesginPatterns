using ChatMediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMediator.Interface
{
    public interface IChatMediator
    {
         void SendMessage(string message,User  user);

        void AddUser(User user);    
    }
}
