using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Entities
{
    class Sales
    {
        public Guid IdSale { get; set; }

        public string FullName { get; set; }

        public string equipDescription { get; set; }

        //le iau din checkOutPage
        public string PaymentMethod { get; set; }

        public double TotalValue { get; set; }


    }
}
