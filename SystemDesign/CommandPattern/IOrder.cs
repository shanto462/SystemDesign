using System;
using System.Collections.Generic;
using System.Text;

namespace SystemDesign.CommandPattern
{
    public interface IOrder // command
    {
        void Execute();
    }

    public class BurgerOrder : IOrder
    {
        public void Execute()
        {
            Console.WriteLine("ordering pizza");
        }
    }

    public class CokeOrder : IOrder
    {
        public void Execute()
        {
            Console.WriteLine("ordering coke");
        }
    }

    public class Khadok
    {
        private IOrder order;

        public Khadok(IOrder order)
        {
            this.order = order;
        }

        public void Order()
        {
            this.order.Execute();
        }
    }

    public class DbContext
    {
        private IOrder _onStart;
        private IOrder _orEnd;

        private IOrder _order;

        public DbContext(IOrder order)
        {
            this._order = order;
        }

        public void Update()
        {
            _onStart.Execute();
            try
            {
                _order.Execute();
            }
            catch (Exception) { }
            finally
            {
                _orEnd.Execute();
            }
        }
    }
}
