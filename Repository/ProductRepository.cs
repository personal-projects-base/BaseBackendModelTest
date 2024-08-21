using Base_Backend.Config.Database;
using Base_Backend.Model;

namespace Base_Backend.Repository
{
    public class ProductRepository : BaseRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(ApiDbContext context) : base(context)
        {
            _context = context;
        }

        public ProductEntity FindPrice()
        {
            var priduct = _context.ProductContext.Where(item => item.Preco == Convert.ToDecimal("2.98")).First();
            return priduct;
        }
    }
}
