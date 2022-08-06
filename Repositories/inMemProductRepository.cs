using Microsoft.AspNetCore.Mvc;
using Product.Dtos;
using Product.Entities;

namespace Product.Repositories
{
    public class inMemProductRepository : IProductRepository
    {
        private readonly List<ProductEntity> products = new(){
         new ProductEntity{Id=Guid.NewGuid(),Title="T-Shirt",Description="Black Man T-shirt styleing",Price=199,CreatedDate=DateTimeOffset.UtcNow},
         new ProductEntity{Id=Guid.NewGuid(),Title="Shirt",Description="Red Man Shirt",Price=599,CreatedDate=DateTimeOffset.UtcNow},
         new ProductEntity{Id=Guid.NewGuid(),Title="Genas",Description="Black Man and Woman Geans pant",Price=899,CreatedDate=DateTimeOffset.UtcNow},
        };


        public IEnumerable<ProductEntity> GetProducts()
        {
            return products;
        }


        public ProductEntity GetProduct(Guid id)
        {
            var productItem = products.Where(item => item.Id == id).SingleOrDefault();

            return productItem!;
        }
    }
}