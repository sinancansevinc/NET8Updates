using NET8Updates.API.Models;

namespace NET8Updates.API.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
