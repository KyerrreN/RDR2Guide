using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ISidequestRepository
    {
        IEnumerable<Sidequest> GetAllSidequests(bool trackChanges);
        Sidequest GetSidequest(int id, bool trackChanges);
    }
}
