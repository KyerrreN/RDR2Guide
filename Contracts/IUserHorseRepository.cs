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
        IEnumerable<UserHorse> GetUserFoundHorses(string userId, bool trackChanges);
        UserHorse GetFoundHorse(string userId, int horseId, bool trackChanges);
    }
}
