using MediaterDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaterDesignPattern
{
    class ChatRoom : ChatMediator
    {
        public static List<User> Users = new List<User>();  
        public void JoinGroup(User user, string groupID)
        {
           Users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach(User user in Users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}
