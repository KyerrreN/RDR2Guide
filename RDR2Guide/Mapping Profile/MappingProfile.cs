using AutoMapper;
using Entities.Models;
using Shared.DTO;

namespace RDR2Guide.Mapping_Profile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Animal, AnimalDto>();
        }
    }
}
