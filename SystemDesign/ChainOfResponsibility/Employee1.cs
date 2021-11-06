using System;
using System.Threading;

namespace SystemDesign.ChainOfResponsibility
{
    public class Employee1 : BaseEmployee, IEmployee
    {
        public Employee1(IEmployee nextEmployee) : base(nextEmployee)
        {

        }

        protected override void ConsumeBehaviour(int task)
        {
            Thread.Sleep(task);
            Console.WriteLine("working on " + task + " " + GetType().Name);
        }

        public void AcceptTask(int taskId)
        {
            if (taskId >= 50 && taskId <= 100)
            {
                AddToList(taskId);
            }
            else
            {
                NextEmployee(taskId);
            }
        }
    }
}
