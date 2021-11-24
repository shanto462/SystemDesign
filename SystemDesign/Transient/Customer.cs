using System;
using System.Collections.Generic;
using System.Text;

namespace Solve.Transient
{
    public class Work
    {

    }
    // Work work => singleton
    public class Customer
    {
        // transient
        private Work work = new Work();

        public void Ok()
        {
            // scoped
            Work work = new Work();
        }
    }
}
