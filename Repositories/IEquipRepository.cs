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
        BindingList<Equipment> GetBought();
        Equipment GetByIdF(Guid id);
        Equipment GetByIdB(Guid id);
        Equipment GetByIdC(Guid id);
        string GetDescriptionF(Guid id);
        string GetDescriptionB(Guid id);
        string GetDescriptionC(Guid id);

    }
}
