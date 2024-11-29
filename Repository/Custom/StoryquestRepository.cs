using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class StoryquestRepository : RepositoryBase<Storyquest>, IStoryquestRepository
    {
        public StoryquestRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Storyquest> GetAllStoryQuests(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(x => x.Id)
                .ToList();
        }

        public Storyquest GetStoryQuest(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
