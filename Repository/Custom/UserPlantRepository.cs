﻿using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class UserPlantRepository : RepositoryBase<UserPlant>, IUserPlantRepository
    {
        public UserPlantRepository(RepositoryContext context) : base(context)
        {
        }

        public void CollectPlant(UserPlant plant)
        {
            Create(plant);
        }

        public void DeletePlant(UserPlant plant)
        {
            Delete(plant);
        }

        public UserPlant GetFoundPlant(string userId, int plantId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.PlantId.Equals(plantId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Plant)
                .SingleOrDefault();
        }

        public IEnumerable<UserPlant> GetUserFoundPlants(string userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Plant)
                .OrderBy(x => x.PlantId)
                .ToList();
        }
    }
}
