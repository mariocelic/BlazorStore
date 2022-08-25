using BlazorStore.Shared;

namespace BlazorStore.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
