using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Track4GoDomain.Entities;

namespace Track4GoDomain.Interfaces
{
    public interface IUserRepository
    {
        public IQueryable<UserEntity> GetUser();
    }
}
