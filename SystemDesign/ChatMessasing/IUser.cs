using System;
using System.Collections.Generic;
using System.Text;

namespace Solve.ChatMessasing
{
    public interface IUser
    {
        bool Send(string message, int toUserId);
        bool Receive(string message, int fromUserId);
    }
}
