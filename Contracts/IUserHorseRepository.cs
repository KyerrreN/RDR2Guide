using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserHorseRepository
    {
        IEnumerable<UserHorse> GetUserFoundHorses(int userId, bool trackChanges);
        UserHorse GetFoundHorse(int userId, int horseId, bool principalTrackChanges, bool dependentTrackChanges);
    }
}
