using Prism.Domain.Entities;

namespace Prism.Application.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}