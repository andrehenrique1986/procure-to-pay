using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProcureToPay.Infra.Data.Context;





namespace ProcureToPay.Infra.CrossCutting
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure (
            this IServiceCollection service,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ProcureToPayConnection");

            service.AddDbContext<ProcureToPayContext>(options =>
                options.UseNpgsql(connectionString));
            return service;
        }
    }
}

        


