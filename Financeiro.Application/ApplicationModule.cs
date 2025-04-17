using Financeiro.Domain.Repository;
using Financeiro.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Financeiro.Application
{
    public static class ApplicationModule
    {

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddApplicationServices();
            return services;
        }


        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IContasPagarRepository, ContasPagarRepository>();
            return services;
        }
    }
}
