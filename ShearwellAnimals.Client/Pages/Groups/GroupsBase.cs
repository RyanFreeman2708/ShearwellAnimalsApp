using Microsoft.AspNetCore.Components;
using Models.DTOs;
using ShearwellAnimals.Client.Services.Contracts;

namespace ShearwellAnimals.Client.Pages.Groups
{
    public class GroupsBase : ComponentBase
    {
        [Inject]
        IGroupService GroupService { get; set; }
        public IEnumerable<GroupDTO> Groups { get; set; } = Enumerable.Empty<GroupDTO>();
        protected override async Task OnInitializedAsync()
        {
            Groups = await GroupService.GetGroups();
        }
    }
}
