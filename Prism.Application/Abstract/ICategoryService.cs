using Prism.Domain.Entities;

namespace Prism.Application.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}