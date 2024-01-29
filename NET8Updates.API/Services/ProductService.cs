
using NET8Updates.API.Models;
using NET8Updates.API.Repositories;

namespace NET8Updates.API.Services
{
    public class ProductService(IProductRepository productRepository):IProductService
    {
        private readonly IProductRepository _productRepository = productRepository;
        

        public List<Product> GetProducts()
        {

            
            return _productRepository.GetProducts();
        }
    }
}
