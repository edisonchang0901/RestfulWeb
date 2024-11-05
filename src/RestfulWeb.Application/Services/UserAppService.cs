using AutoMapper;
using RestfulWeb.Application.Interface;
using RestfulWeb.Application.ViewModels;
using RestfulWeb.Domain.Interfaces;
using RestfulWeb.Domain.Models;

namespace RestfulWeb.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserAppService(IMapper mapper,
                              IEnumerable<IUserRepository> userRepository) 
        {
            _mapper = mapper;
            _userRepository = userRepository.FirstOrDefault(x => x.Name == "EFRepository") ?? throw new ArgumentException("EFRepository not found");
        }


        public async Task CreateUser(UserViewModel model)
        {
            User user = _mapper.Map<User>(model);
            user.Register();
            user.RecordCreateTime();
            await _userRepository.CreateUser(user);
        }

        public async Task<UserViewModel> GetUserById(int id)
        {
            return _mapper.Map<UserViewModel>(await _userRepository.GetUser(id));
        }

        public async Task<IEnumerable<UserViewModel>> GetUserAll()
        {
            return _mapper.Map<IEnumerable<UserViewModel>>(await _userRepository.GetUsers());
        }

        public async Task UpdateUser(UserViewModel model) 
        {
            User user = _mapper.Map<User>(model);
            user.RecordUpdateTime();
            await _userRepository.UpdateUser(user);
        }

        public async Task DenyUser(int id) 
        {
            var user = await _userRepository.GetUser(id);
            if (user == null)
                throw new NullReferenceException($"{nameof(DenyUser)} can't find user { id }");         
            user.Deny();
            user.RecordUpdateTime();
            await _userRepository.UpdateUser(user);
        }

        public async Task DeleteUser(int id) 
        {
            var user = await _userRepository.GetUser(id);
            if (user == null)
                throw new NullReferenceException($"{nameof(DeleteUser)} can't find user {id}");
            await _userRepository.DeleteUser(id);
        }
    }
}
