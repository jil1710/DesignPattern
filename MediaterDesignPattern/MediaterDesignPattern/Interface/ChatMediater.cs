﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaterDesignPattern.Interface
{
    interface ChatMediator
    {
        void SendMessage(string message, User sender);

        void JoinGroup(User user,string groupID);
    }
}
