using FCamara.CrossCutting.Ioc.MediatorExtensions;
using FCamara.Domain.Core.Interfaces.Services;
using FCamara.Domain.Service.Services;
using FCamara.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace FCamara.CrossCutting.Ioc
{
    public static class IocExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Solução para não precisar injetar cada commandHanler
            AppDomain.CurrentDomain.Load(new AssemblyName("FCamara.Application"));
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

            services.RegisterMediatorHandler(assemblies);

            services.AddTransient<IServiceContaCorrente, ServiceContaCorrente>();

        }
        public static void RegisterRepositoryDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<MyDBContext>(options =>
                options.EnableDetailedErrors(true)
                .UseSqlServer(connectionString, x => x.EnableRetryOnFailure()
                                                      .MaxBatchSize(500)
                                                      .UseRelationalNulls(true)), 128);


        }
    }
}
