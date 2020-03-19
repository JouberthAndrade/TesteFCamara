using AutoMapper;
using FCamara.CrossCutting.Ioc.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace FCamara.CrossCutting.Ioc
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings(IList<Profile> profiles)
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ContaDomainToDto());
                
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            });

        }
    }
}
