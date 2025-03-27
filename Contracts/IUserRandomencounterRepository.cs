using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserRandomencounterRepository
    {
        IEnumerable<UserRandomencounter> GetUserFoundRandomEncounter(string userId, bool trackChanges);
        UserRandomencounter GetFoundRandomEncounter(string userId, int randomEncounterId, bool trackChanges);
    }
}
