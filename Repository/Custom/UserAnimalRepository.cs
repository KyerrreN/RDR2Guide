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
    public class UserAnimalRepository : RepositoryBase<UserAnimal>, IUserAnimalRepository
    {
        public UserAnimalRepository(RepositoryContext context) : base(context)
        {
        }

        public UserAnimal GetFoundAnimal(int userId, int animalId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.AnimalId.Equals(animalId), trackChanges)
                .Include(x => x.Animal)
                .Include(x => x.User)
                .SingleOrDefault();
        }

        public IEnumerable<UserAnimal> GetUserFoundAnimals(int userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.Animal)
                .Include(x => x.User)
                .OrderBy(x => x.AnimalId)
                .ToList();
        }
    }
}