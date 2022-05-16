using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Database
{
    class SalesDatabase
    {
        public static List<Sales> boughtE = new List<Sales>()
        {
            new Sales()
            {
                IdSale=Guid.NewGuid(),
                FullName="de test"

            }
        };
    }
}
