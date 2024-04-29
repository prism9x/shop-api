using Prism.Domain.Entities;

namespace Prism.Application.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}