using API.Entities;
using API.Repositories;
using API.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;

        public GroupsController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupDTO>>> GetGroups()
        {
            try
            {
                var groups = await _groupRepository.GetAllGroups();

                if (groups == null)
                {
                    return NotFound();
                }

                var groupDTOs = new List<GroupDTO>();

                foreach (var group in groups)
                {
                    GroupDTO newGroup = new GroupDTO
                    {
                        Name = group.Name,
                        DateCreated = group.DateCreated
                    };

                    groupDTOs.Add(newGroup);
                }

                return Ok(groupDTOs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
