using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAnimalService> _animalService;


        public ServiceManager(IRepositoryManager repositoryManager,
                              IMapper mapper)
        {
            _animalService = new Lazy<IAnimalService>(() => new AnimalService(repositoryManager, mapper));
        }



        public IAnimalService AnimalService => _animalService.Value;
    }
}
