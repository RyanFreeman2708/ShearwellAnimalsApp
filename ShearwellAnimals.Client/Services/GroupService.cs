using Models.DTOs;
using ShearwellAnimals.Client.Services.Contracts;
using System.Net.Http.Json;

namespace ShearwellAnimals.Client.Services
{
    public class GroupService : IGroupService
    {
        private readonly HttpClient _httpClient;
        public GroupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GroupDTO>> GetGroups()
        {
            var response = await _httpClient.GetAsync($"/api/Groups");

            return await response.Content.ReadFromJsonAsync<IEnumerable<GroupDTO>>();
        }
    }
}
