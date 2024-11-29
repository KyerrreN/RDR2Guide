using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IStoryquestRepository
    {
        IEnumerable<Storyquest> GetAllStoryQuests(bool trackChanges);
        Storyquest GetStoryQuest(int id, bool trackChanges);
    }
}
