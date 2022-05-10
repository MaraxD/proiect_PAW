using seminar9.Database;
using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Repositories
{
    public class PlaneRepository : IPlaneRepository
    {

        public void Add(Plane plane)
        {
            plane.Id = Guid.NewGuid();
            FakeDatabase.Planes.Add(plane);
        }

        public List<Plane> GetALL()
        {
            return FakeDatabase.Planes;
        }
    }
}
