using System;
using System.Collections.Concurrent;

namespace SystemDesign.ChainOfResponsibility
{
    public class Employee2 : BaseEmployee, IEmployee
    {
        protected ConcurrentQueue<int> _batch;
        protected int Threshold = 100;

        public Employee2(IEmployee nextEmployee) : base(nextEmployee)
        {
            _batch = new ConcurrentQueue<int>();
        }

        protected override void ConsumeBehaviour(int task)
        {
            _batch.Enqueue(task);
            if (_batch.Count >= Threshold)
            {
                // dequeue all and process
            }
        }

        public void AcceptTask(int taskId)
        {
            if (taskId >= 10 && taskId <= 50)
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
