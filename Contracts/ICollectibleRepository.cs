﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICollectibleRepository
    {
        IEnumerable<Collectible> GetAllCollectibles(bool trackChanges);
        Collectible GetCollectible(int id, bool trackChanges);
    }
}
