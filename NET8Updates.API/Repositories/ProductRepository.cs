using NET8Updates.API.Models;

namespace NET8Updates.API.Repositories
{
    public class ProductRepository:IProductRepository
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id=1,
                    Name = "Product 1",
                    Price = 99.99m
                },
                new Product
                {
                    Id=2,
                    Name = "Product 2",
                    Price = 200.99m
                },
                new Product
                {
                    Id=3,
                    Name = "Product 3",
                    Price = 300.99m
                }
            };

            return products;


        }
    }
}
