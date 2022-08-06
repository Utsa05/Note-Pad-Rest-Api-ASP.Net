using Product.Dtos;
using Product.Entities;

namespace Product
{
    public static class Extension
    {
        public static ProductDto AsDto(this ProductEntity product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price,
                Status = product.Status,
                CreatedDate = product.CreatedDate
            };
        }

    }
}