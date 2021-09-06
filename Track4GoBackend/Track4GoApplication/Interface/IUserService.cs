using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Track4GoApplication.ViewModels;

namespace Track4GoApplication.Interface
{
    public interface IUserService
    {
        public IEnumerable<UserViewModel> GetUser();
        public void Create(UserViewModel userViewModel);
        public void Update(UserViewModel userViewModel);
        public void Delete(Guid id);
    }
}
