using System.Linq;
using System.Threading.Tasks;
using Track4GoDomain.Entities;

namespace Track4GoDomain.Interfaces
{
    public interface IUserRepository
    {
        public IQueryable<UserEntity> GetUser();

        public void Add(UserEntity userEntity);

        public void Update(UserEntity userEntity);
    }
}
