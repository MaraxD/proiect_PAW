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

        public Equipment GetByIdF(Guid id)
        {
            foreach (var equip in FemeiDatabase.Equipments)
            {
                if (equip.Id == id)
                    return equip;
            }
            return null;
        }

        public Equipment GetByIdB(Guid id)
        {
            foreach (var equip in BarbatiDatabase.Equipments)
            {
                if (equip.Id == id)
                    return equip;
            }
            return null;
        }

        public Equipment GetByIdC(Guid id)
        {
            foreach (var equip in CopiiDatabase.Equipments)
            {
                if (equip.Id == id)
                    return equip;
            }
            return null;
        }

        public static BindingList<Equipment> boughtE = new BindingList<Equipment>();

        public BindingList<Equipment> GetBought()
        {
            return boughtE;
        }

        

        //verificare: din ce tabela a fost selectat un rand pentru editare
        public string GetDescriptionF(Guid id)
        {
            foreach (var equip in FemeiDatabase.Equipments)
            {
                if (equip.Id == id)
                    return equip.Category;
            }
            return null;
        }

        public string GetDescriptionB(Guid id)
        {
            foreach (var equip in BarbatiDatabase.Equipments)
            {
                if (equip.Id == id)
                    return equip.Category;
            }
            return null;
        }

        public string GetDescriptionC(Guid id)
        {
            foreach (var equip in CopiiDatabase.Equipments)
            {
                if (equip.Id == id)
                    return equip.Category;
            }
            return null;
        }
    }
}
