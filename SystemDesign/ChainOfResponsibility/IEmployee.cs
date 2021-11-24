using System.Collections.Generic;
using System.Text;

namespace Solve.ChainOfResponsibility
{
    public interface IEmployee
    {
        void AcceptTask(int taskId);
    }
}
