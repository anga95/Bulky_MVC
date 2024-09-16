using Bulky.Models;

namespace Bylky.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
