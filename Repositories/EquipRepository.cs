using seminar9.Database;
using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Repositories
{
    public class EquipRepository : IEquipRepository
    {

        public void Add(Equipment equipment)
        {

            BarbatiDatabase.Equipments.Add(equipment);
            /*CopiiDatabase.Equipments.Add(equipment);
            FemeiDatabase.Equipments.Add(equipment);*/
        }

        public List<Equipment> GetALL()
        {
            return BarbatiDatabase.Equipments;
            /*return CopiiDatabase.Equipments;
            return FemeiDatabase.Equipments;*/
        }

    }
}
