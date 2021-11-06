using System.Collections.Generic;
using System.Text;

namespace SystemDesign.ChainOfResponsibility
{
    public interface IEmployee
    {
        void AcceptTask(int taskId);
    }
}
