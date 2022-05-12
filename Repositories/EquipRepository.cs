using seminar9.Database;
using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Repositories
{

    public class EquipRepository : IEquipRepository
    {

        public void Add1(Equipment equipment)
        {
            BarbatiDatabase.Equipments.Add(equipment);
        }

        public BindingList<Equipment> GetBARBATI()
        {
            return BarbatiDatabase.Equipments;
        }



        public void Add2(Equipment equipment)
        {
            FemeiDatabase.Equipments.Add(equipment);
        }

        public BindingList<Equipment> GetFEMEI()
        {
            return FemeiDatabase.Equipments;
        }



        public void Add3(Equipment equipment)
        {
            CopiiDatabase.Equipments.Add(equipment);
        }

        public BindingList<Equipment> GetCOPII()
        {
            return CopiiDatabase.Equipments;
        }


    }
}
