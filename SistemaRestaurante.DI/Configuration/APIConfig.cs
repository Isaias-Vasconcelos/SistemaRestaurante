using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaRestaurante.Data.Database;
using SistemaRestaurante.Data.Repositories;
using SistemaRestaurante.Domain.Interfaces;
using SistemaRestaurante.Domain.Interfaces.Generic;

namespace SistemaRestaurante.DI.Configuration
{
    public static class APIConfig
    {
        static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationContext>(opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            return services;
        }

        static IServiceCollection AddReposisitories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>))
                .AddScoped<IPedidoRepository, PedidoRepository>()
                .AddScoped<IRestauranteRepository, RestauranteRepository>();

            return services;
        }
    }
}
