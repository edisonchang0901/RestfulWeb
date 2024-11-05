using RestfulWeb.Domain.Interfaces;
using RestfulWeb.Domain.Models;

namespace RestfulWeb.infrastructure.Repository
{
    public class DapperRepository : IUserRepository
    {
        public string Name { get => nameof(DapperRepository); }

        public Task CreateUser(User user)
        {
            throw new NotImplementedException();
        }


        public Task DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
