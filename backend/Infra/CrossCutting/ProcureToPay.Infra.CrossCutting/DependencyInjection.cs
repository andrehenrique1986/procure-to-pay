using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProcureToPay.Domain.Interfaces.Repository;
using ProcureToPay.Infra.Data.Context;
using ProcureToPay.Infra.Data.Repositories;

namespace ProcureToPay.Infra.CrossCutting
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, 
                 IConfiguration configuration)
        {
            // 1. Obter Connection String
            var connectionString = configuration.GetConnectionString("ProcureToPayConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("A ConnectionString 'ProcureToPayConnection' não foi encontrada no appsettings.json.");
            }

            // 2. Configurar o DbContext com PostgreSQL
            services.AddDbContext<ProcureToPayContext>(options =>
                options.UseNpgsql(
                    connectionString,
                    b => b.MigrationsAssembly(typeof(ProcureToPayContext).Assembly.FullName)
                ));

            
          
            return services;
        }
    }
}