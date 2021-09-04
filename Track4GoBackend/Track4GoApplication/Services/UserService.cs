using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Track4GoApplication.Interface;
using Track4GoApplication.ViewModels;
using Track4GoDomain.Entities;
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

        public void Create(UserViewModel request)
        {
            var userEntity = _mapper.Map<UserViewModel, UserEntity>(request);
            _userRepository.Add(userEntity);
        }

        public void Delete(Guid Id_User)
        {
            _userRepository.Delete(Id_User);
        }

        public IEnumerable<UserViewModel> GetUser()
        {
            return _userRepository.GetUser().ProjectTo<UserViewModel>(_mapper.ConfigurationProvider);
        }

        public void Update(UserViewModel request)
        {
            var userEntity = _mapper.Map<UserViewModel, UserEntity>(request);
            _userRepository.Update(userEntity);
        }
    }
}
