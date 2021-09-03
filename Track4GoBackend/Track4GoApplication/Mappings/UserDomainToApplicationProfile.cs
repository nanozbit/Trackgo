using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Track4GoApplication.ViewModels;
using Track4GoDomain.Entities;

namespace Track4GoApplication.Mappings
{
    public class UserDomainToApplicationProfile :Profile
    {
        public UserDomainToApplicationProfile()
        {
            CreateMap<UserEntity, UserViewModel>();
        }
    }
}
