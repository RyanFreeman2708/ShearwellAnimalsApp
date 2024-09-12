using API.Entities;

namespace API.Repositories.Contracts
{
    public interface IGroupRepository
    {
        Task<IEnumerable<Grouping>> GetAllGroups();
    }
}
