using System;
using System.Collections.Generic;
using System.Text;

namespace Solve.ChatMessasing
{
    public class User : BaseUser, IUser
    {
        public bool Receive(string message, int fromUserId)
        {
            return true;
        }

        public bool Send(string message, int toUserId)
        {
            return true;
        }
    }
}
