using Financeiro.Api.Repository;
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
            services.AddScoped<IPagamentosRepository, PagamentosRepository>();
            //builder.Services.AddScoped<IContasReceber, ContasReceberRepository>();
            //builder.Services.AddScoped<IPagamentos, PagamentosRepository>();
            //builder.Services.AddScoped<ICategorias, CategoriasRepository>();
            //builder.Services.AddScoped<ICartaoCredito, CartaoCreditoRepository>();
            //builder.Services.AddScoped<IReceitas, ReceitasRepository>();

            return services;
        }

        //public static class DependencyInjection
        //{
        //    public static IServiceCollection AppDependencyInjection(IServiceCollection services)
        //    {
        //        services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
        //        return services;
        //    }
        //}
    }
}
