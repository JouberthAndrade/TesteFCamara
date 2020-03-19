using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace FCamara.CrossCutting.Ioc
{
    public static class DependecyContextProject
    {
        public static void Configure(this IServiceCollection services, IConfiguration configuration, IList<Profile> profiles)
        {
            services.AddSingleton(ctx =>
            {
                var mapper = AutoMapperConfig.RegisterMappings(profiles);
                mapper.CompileMappings();
                return mapper.CreateMapper();
            });
        }
    }
}
