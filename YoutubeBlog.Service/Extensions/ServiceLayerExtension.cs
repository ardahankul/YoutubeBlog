using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Service.Services.Concretes;

namespace YoutubeBlog.Service.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService,ArticleService>();

            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
