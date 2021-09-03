using System;
using System.Collections.Generic;
using System.Text;
using Track4GoApplication.ViewModels;

namespace Track4GoApplication.Interface
{
    public interface IUserService
    {
        public IEnumerable<UserViewModel> GetUser();
    }
}
