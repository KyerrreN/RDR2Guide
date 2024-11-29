using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMiscellaneousRepository
    {
        IEnumerable<Miscellaneous> GetAllMiscellaneous(bool trackChanges);
        Miscellaneous GetMiscellaneous(int id, bool trackChanges);
    }
}
