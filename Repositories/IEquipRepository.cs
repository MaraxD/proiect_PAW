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
        List<Equipment> GetBARBATI();
        void Add1(Equipment equipment); //nu returnam nimic pentru ca doar citim datele

        List<Equipment> GetFEMEI();
        void Add2(Equipment equipment); //nu returnam nimic pentru ca doar citim datele

        List<Equipment> GetCOPII();
        void Add3(Equipment equipment); //nu returnam nimic pentru ca doar citim datele
    }
}
