using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class UserHorseRepository : RepositoryBase<UserHorse>, IUserHorseRepository
    {
        public UserHorseRepository(RepositoryContext context) : base(context)
        {
        }

        public UserHorse GetFoundHorse(string userId, int horseId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.HorseId.Equals(horseId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Horse)
                .SingleOrDefault();
        }

        public IEnumerable<UserHorse> GetUserFoundHorses(string userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Horse)
                .OrderBy(x => x.HorseId)
                .ToList();
        }
    }
}
