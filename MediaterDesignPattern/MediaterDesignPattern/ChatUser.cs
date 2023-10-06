using MediaterDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediaterDesignPattern
{
    class ChatUser : User
    {
        private string name;
        private ChatMediator mediator;
        public ChatUser(string name, ChatMediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
        }
    
        public void SendMessage(string message)
        {
            Console.Write(name + " sends: " + message);
            mediator.SendMessage(message, this);
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine(name + " receives: " + message);
        }
    }
}   
