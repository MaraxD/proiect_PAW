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

        public Equipment GetByIdF(Guid id) {
            foreach (var ticket in FemeiDatabase.Equipments)
            {
                if (ticket.Id == id)
                    return ticket;
            }
            return null;
        }

        public Equipment GetByIdB(Guid id)
        {
            foreach (var ticket in BarbatiDatabase.Equipments)
            {
                if (ticket.Id == id)
                    return ticket;
            }
            return null;
        }

        public Equipment GetByIdC(Guid id)
        {
            foreach (var ticket in CopiiDatabase.Equipments)
            {
                if (ticket.Id == id)
                    return ticket;
            }
            return null;
        }

        public static BindingList<Equipment> boughtE = new BindingList<Equipment>();

        public BindingList<Equipment> GetBought()
        {
            return boughtE;

    }


}
}
