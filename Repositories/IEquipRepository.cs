using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Repositories
{
    public interface IEquipRepository
    {
        BindingList<Equipment> GetBARBATI();
        void Add1(Equipment equipment); //nu returnam nimic pentru ca doar citim datele

        BindingList<Equipment> GetFEMEI();
        void Add2(Equipment equipment); //nu returnam nimic pentru ca doar citim datele

        BindingList<Equipment> GetCOPII();
        void Add3(Equipment equipment); //nu returnam nimic pentru ca doar citim datele
    }
}
