using RestfulWeb.Application.ViewModels;

namespace RestfulWeb.Application.Interface
{
    public interface IUserAppService
    {
        public Task<UserViewModel> GetUserById(int id);

        public Task<IEnumerable<UserViewModel>> GetUserAll();

        public Task CreateUser(UserViewModel model);

        public Task DenyUser(int id);

        public Task UpdateUser(UserViewModel model);

        public Task DeleteUser(int id);

    }
}
