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


        public Task CreateUser(UserViewModel model)
        {
            var result = _mapper.Map<User>(model);
            throw new NotImplementedException();
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

        }
    }
}
