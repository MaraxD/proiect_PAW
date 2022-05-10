using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Entities
{
    public class Plane //modificatorul de acces default este internal
    {
        //camp->variab privata
        //proprietate->incapsulare a unui camp
        public Guid Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public int Seats { get; set; }

    }
}
