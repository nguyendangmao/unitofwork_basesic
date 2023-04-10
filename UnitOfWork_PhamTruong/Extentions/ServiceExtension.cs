using Microsoft.EntityFrameworkCore;
using UnitOfWork_PhamTruong.Entities;
using UnitOfWork_PhamTruong.Repository;
using UnitOfWork_PhamTruong.Service;

namespace UnitOfWork_PhamTruong.Extentions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<dbcontext>(options =>
            {
                options.UseMySQL(configuration.GetConnectionString("unitofwork"));
            });

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
