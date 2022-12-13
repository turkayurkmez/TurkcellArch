using shop.DataAccess.Repositories;
using shop.DTOs.Responses;

namespace shop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public IList<ProductDisplayResponse> GetProducts()
        {

            var dtoResponse = _productRepository.Get().Select(p => new ProductDisplayResponse
            {
                Id = p.Id,
                Price = p.Price,
                Description = p.Description,
                Name = p.Name
            }).ToList();

            return dtoResponse;
        }
    }
}
