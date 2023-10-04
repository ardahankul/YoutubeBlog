using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repositories.Abstracts;
using YoutubeBlog.Data.Repositories.Concretes;
using YoutubeBlog.Data.UnitOfWorks;

namespace YoutubeBlog.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config) {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));   //this is for dependency injection to IRepository
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
