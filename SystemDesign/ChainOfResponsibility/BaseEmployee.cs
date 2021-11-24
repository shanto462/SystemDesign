using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Solve.ChainOfResponsibility
{
    public abstract class BaseEmployee
    {
        protected readonly IEmployee _nextEmployee;
        protected readonly BlockingCollection<int> _pump;
        protected readonly Task _pumper;

        public BaseEmployee(IEmployee nextEmployee)
        {
            this._nextEmployee = nextEmployee;
            this._pump = new BlockingCollection<int>();
            this._pumper = Task.Run(() =>
            {

                foreach (var task in _pump.GetConsumingEnumerable())
                {
                    ConsumeBehaviour(task);
                }


            });
        }

        protected abstract void ConsumeBehaviour(int task);


        protected void AddToList(int taskId)
        {
            _pump.Add(taskId);
        }

        protected void NextEmployee(int taskId)
        {
            if (_nextEmployee != null)
                _nextEmployee.AcceptTask(taskId);
            else
                Console.WriteLine("employee not found");
        }
    }
}
