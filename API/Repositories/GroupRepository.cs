using API.Data;
using API.Entities;
using API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly AnimalManagementContext _context;

        public GroupRepository(AnimalManagementContext context) {
            _context = context;
        }
        public async Task<IEnumerable<Grouping>> GetAllGroups()
        {
            var groups = await _context.Groupings.ToListAsync();
            return groups;
        }
    }
}
