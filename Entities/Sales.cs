using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Entities
{
    class Sales
    {
        public Guid IdSale { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string PaymentMethod { get; set; }

        public double TotalValue { get; set; }


    }
}
