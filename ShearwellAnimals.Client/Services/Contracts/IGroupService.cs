using Models.DTOs;

namespace ShearwellAnimals.Client.Services.Contracts
{
    public interface IGroupService
    {
        Task<IEnumerable<GroupDTO>> GetGroups();
    }
}
