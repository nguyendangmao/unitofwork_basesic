using UnitOfWork_PhamTruong.Entities;
using UnitOfWork_PhamTruong.Migrations;

namespace UnitOfWork_PhamTruong.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly dbcontext _dbContext;
        public IProductRepository Products { get; }

        public UnitOfWork(dbcontext dbContext,
                            IProductRepository productRepository)
        {
            _dbContext = dbContext;
            Products = productRepository;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
     
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
