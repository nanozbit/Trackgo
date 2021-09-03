using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Collections.Generic;
using Track4GoApplication.Interface;
using Track4GoApplication.ViewModels;
using Track4GoDomain.Interfaces;

namespace Track4GoApplication.Services
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        private IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IEnumerable<UserViewModel> GetUser()
        {
            return _userRepository.GetUser().ProjectTo<UserViewModel>(_mapper.ConfigurationProvider);
        }
    
    }
}
