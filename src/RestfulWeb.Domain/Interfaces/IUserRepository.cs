using RestfulWeb.Domain.Models;

namespace RestfulWeb.Domain.Interfaces
{
    public interface IUserRepository
    {
        public string Name { get;}
        public Task CreateUser();
        public Task<User> GetUser(int id);
        public Task<IEnumerable<User>> GetUsers();
        public Task UpdateUser();
        public Task DeleteUser();
    }
}
