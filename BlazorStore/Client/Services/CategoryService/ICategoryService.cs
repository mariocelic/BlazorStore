using BlazorStore.Shared;

namespace BlazorStore.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetCategories();
    }
}
