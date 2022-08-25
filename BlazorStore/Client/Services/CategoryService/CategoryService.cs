using BlazorStore.Shared;
using System.Net.Http.Json;

namespace BlazorStore.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;

        public CategoryService(HttpClient client)
        {
            _client = client;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var result = await _client.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");

            if (result != null && result.Data != null)
            {
                Categories = result.Data;
            }
        }
    }
}
