using shop.DTOs.Responses;

namespace shop.Services
{
    public interface IProductService
    {
        IList<ProductDisplayResponse> GetProducts();
    }
}