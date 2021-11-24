using System;
using System.Collections.Generic;
using System.Text;

namespace Solve.Principles.DependencyInjection
{
    public interface ICustomerDataAccess
    {
        string GetCustomerNameById(int id);
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public string GetCustomerNameById(int id)
        {
            return "okakakak";
        }
    }
    /// <summary>
    ///  diff IEnumerable vs IQueryable
    ///  IEnumerable custs = from cust in db.Custs select cust // lamda
    ///  IQueryable qcusts = from cust in db.Custs select cust // expression
    ///  var filter = custs.Where(x => x.name == "sunny").tolist();
    ///  var qfilter = qcusts.Where(x => x.name == "sunny").tolist();
    ///  (select * from custs) // 1M
    ///     where name == "sunny"
    ///     (select * from custs where name == "sunny") // 
    /// </summary>
    public static class DatabaseAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccess()
        {
            return new CustomerDataAccess();
        }
    }

    public class CustomerBusinessLogic
    {
        ICustomerDataAccess customerDataAccess;

        public CustomerBusinessLogic()
        {

        }

        public string GetCustomerNameById(int id)
        {
            return customerDataAccess.GetCustomerNameById(id);
        }
    }
}
