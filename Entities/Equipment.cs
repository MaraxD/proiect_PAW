using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Entities
{
    public class Equipment //modificatorul de acces default este internal
    {
        
        //camp->variab privata
        //proprietate->incapsulare a unui camp

        public Guid Id { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string Color { get; set; }

       
    }
}
