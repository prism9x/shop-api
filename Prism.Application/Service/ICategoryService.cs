using Prism.Domain.Entities;

namespace Prism.Application.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}