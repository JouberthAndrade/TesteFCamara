using FCamara.Domain.Core.Interfaces.Repositorys;
using FCamara.Infra.Repositorys;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FCamara.CrossCutting.Ioc.DependecyContext.ContaCorrente
{
    internal static class ContaCorrenteDependecyContext
    {
        public static void ContaCorrenteConfigure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepositoryContaCorrente), typeof(ContaCorrenteRepository));

        }
    }
}
