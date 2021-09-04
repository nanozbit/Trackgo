using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Track4GoApplication.ViewModels;
using Track4GoDomain.Entities;

namespace Track4GoApplication.Mappings
{
    public class UserViewModelToDomainProfile :Profile 
    {
        public UserViewModelToDomainProfile()
        {
            CreateMap<UserViewModel, UserEntity>();
        }
    }
}
