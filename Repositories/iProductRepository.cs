using Product.Entities;

namespace Product.Repositories
{

    public interface IProductRepository
    {
        IEnumerable<ProductEntity> GetProducts();
        ProductEntity GetProduct(Guid id);

    }
}