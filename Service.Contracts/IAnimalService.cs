using Shared.DTO;

namespace Service.Contracts
{
    public interface IAnimalService
    {
        BaseDto<AnimalDto> GetAll(bool trackChanges);
        AnimalDto GetOne(int id, bool trackChanges);
    }
}
