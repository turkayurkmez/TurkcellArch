using shop.Entities;

namespace shop.DataAccess.Repositories
{
    public interface IProductRepository
    {
        IList<Product> Get();
    }
}