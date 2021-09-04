using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Track4GoApplication.Mappings
{
    public class MappingConfiguration
    {
       public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
           {
               cfg.AddProfile( new UserDomainToApplicationProfile());
               cfg.AddProfile(new UserViewModelToDomainProfile());
           });
        }
    }
}
