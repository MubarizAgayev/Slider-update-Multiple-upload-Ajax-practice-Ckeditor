using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.Services.interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAll();
    }
}
