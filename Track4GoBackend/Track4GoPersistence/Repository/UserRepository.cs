using System;
using System.Linq;
using Track4GoDomain.Entities;
using Track4GoDomain.Interfaces;
using Track4GoPersistence.Context;

namespace Track4GoPersistence.Repository
{
    public class UserRepository : IUserRepository
    {
        private UserContext _userContext;
        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public void Add(UserEntity userEntity)
        {
           _userContext.Add(userEntity);
           _userContext.SaveChanges();
        }

        public void Delete(Guid Id_User)
        {
            var userID = new UserEntity { Id_User = Id_User };
            _userContext.Remove(userID);
            _userContext.SaveChanges();
        }

        public IQueryable<UserEntity> GetUser()
        {
            return _userContext.Tbl_User;
        }

        public void Update(UserEntity userEntity)
        {
            _userContext.Update(userEntity);
            _userContext.SaveChanges();
        }
    }
}
