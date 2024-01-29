using NET8Updates.API.Models;

namespace NET8Updates.API.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
    }
}
