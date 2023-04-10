using UnitOfWork_PhamTruong.Entities;

namespace UnitOfWork_PhamTruong.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(dbcontext dbContext) : base(dbContext)
        {

        }
    }
}
