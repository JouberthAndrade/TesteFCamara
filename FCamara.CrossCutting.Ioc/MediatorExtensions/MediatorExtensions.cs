using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FCamara.CrossCutting.Ioc.MediatorExtensions
{
    public static class MediatorExtensions
    {

        public static void RegisterMediatorHandler(this IServiceCollection services, Assembly[] assemblies)
        {
            services.AddMediatR(assemblies);
        }
    }
}
