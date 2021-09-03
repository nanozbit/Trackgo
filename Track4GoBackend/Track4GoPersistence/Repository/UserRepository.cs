using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Track4GoDomain.Entities;
using Track4GoDomain.Interfaces;
using Track4GoPersistence.Context;

namespace Track4GoPersistence.Repository
{
    public class UserRepository: IUserRepository
    {
        private UserContext _userContext;
    public UserRepository(UserContext userContext)
    {
        _userContext = userContext;
    }
    public IQueryable<UserEntity> GetUser()
    {
        return _userContext.Tbl_User;
    }
}
}
