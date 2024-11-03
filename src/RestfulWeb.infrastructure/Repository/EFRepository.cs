using Microsoft.EntityFrameworkCore;
using RestfulWeb.Domain.Interfaces;
using RestfulWeb.infrastructure.Models;
using User = RestfulWeb.Domain.Models.User;


namespace RestfulWeb.infrastructure.Repository
{
    public class EFRepository : IUserRepository
    {
        private readonly IDbContextFactory<AccountMainContext> _accountMainDbContextFactory;
        public EFRepository(IDbContextFactory<AccountMainContext> accountMainDbContextFactory) 
        {
            _accountMainDbContextFactory = accountMainDbContextFactory;
        }

        public string Name { get => nameof(EFRepository); }

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
