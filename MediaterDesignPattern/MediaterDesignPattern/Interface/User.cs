using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaterDesignPattern.Interface
{
    interface User
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
    }
}
