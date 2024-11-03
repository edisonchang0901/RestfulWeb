using RestfulWeb.Application.ViewModels;

namespace RestfulWeb.Application.Interface
{
    public interface IUserAppService
    {
        public Task<UserViewModel> GetUserById(int id);

        public Task<IEnumerable<UserViewModel>> GetUserAll();

        public Task CreateUser(UserViewModel model);

    }
}
