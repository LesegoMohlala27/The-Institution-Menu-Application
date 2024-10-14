using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Orders
    {
        internal Members Customer { get; }
        internal DateTime OrderDate { get; }

        internal Orders(Members customer)
        {
            Customer = customer;
            OrderDate = DateTime.Now;
        }
    }
}

