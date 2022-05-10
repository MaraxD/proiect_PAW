using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Database
{
    public static class FakeDatabase
    {
        public static List<Plane> Planes = new List<Plane>()
        {
            new Plane()
            {
                Id=Guid.NewGuid(),
                Name="AN-225",
                Type="Cargo",
                Seats=4
            },
            new Plane()
            {
                Id=Guid.NewGuid(),
                Name="Airbus A380",
                Type="Passangers",
                Seats=400
            }
        };

    }
}
