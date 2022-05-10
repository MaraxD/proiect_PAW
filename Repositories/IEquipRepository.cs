using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Repositories
{
    public interface IEquipRepository
    {
        List<Equipment> GetALL();
        void Add(Equipment plane); //nu returnam nimic pentru ca doar citim datele
    }
}
