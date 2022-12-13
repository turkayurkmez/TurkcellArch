using shop.Entities;

namespace shop.DataAccess.Repositories
{
    public class FakeProductRepository : IProductRepository
    {

        public IList<Product> Get()
        {
            return new List<Product>()
            {
                new Product{ Id=1, Description="Test Desc", Name="Test", Price=1},
                new Product{ Id=2, Description="Test Desc", Name="Test", Price=1},
                new Product{ Id=3, Description="Test Desc", Name="Test", Price=1},
                new Product{ Id=4, Description="Test Desc", Name="Test", Price=1},
            };

        }
    }
}
