using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace UnitOfWork_PhamTruong.Entities
{
    //public class seedataProduct
    //{
    //}
    public static class seedataProduct 
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product() { Id=1,Name="abc",Price=123},
                 new Product() { Id = 2, Name = "tr", Price = 123 },
                   new Product() { Id = 3, Name = "dsd", Price = 123 },
                     new Product() { Id = 4, Name = "sds", Price = 123 },
                        new Product() { Id = 5, Name = "ds", Price = 123 }
           );
        }
    }

}
