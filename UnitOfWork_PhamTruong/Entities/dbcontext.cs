using Microsoft.EntityFrameworkCore;

namespace UnitOfWork_PhamTruong.Entities
{
    public class dbcontext:DbContext
    {
        public  dbcontext(DbContextOptions<dbcontext> contextOptions) : base(contextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
           
        }

        public DbSet<Product>? Products { get; set; }
    }
}
