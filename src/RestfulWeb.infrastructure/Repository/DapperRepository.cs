using RestfulWeb.Domain.Interfaces;
using RestfulWeb.Domain.Models;

namespace RestfulWeb.infrastructure.Repository
{
    public class DapperRepository : IUserRepository
    {
        public string Name { get => nameof(DapperRepository); }

        public Task CreateUser()
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser()
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

        public Task UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
