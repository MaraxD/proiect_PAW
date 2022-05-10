using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Repositories
{
    public interface IPlaneRepository
    {
        List<Plane> GetALL();
        void Add(Plane plane); //nu returnam nimic pentru ca doar citim datele
    }
}
