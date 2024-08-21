using Base_Backend.Model;

namespace Base_Backend.Repository
{
    public interface IProductRepository : IBaseRepository<ProductEntity>
    {
        public ProductEntity FindPrice();
    }
}
