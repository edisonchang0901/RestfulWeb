using Dapper;
using RestfulWeb.Domain.Interfaces;
using RestfulWeb.Domain.Models;

namespace RestfulWeb.infrastructure.Repository
{
    public class DapperRepository : IUserRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public DapperRepository(IDbConnectionFactory dbConnectionFactory) 
        {
            _dbConnectionFactory = dbConnectionFactory;
        }
        public string Name { get => nameof(DapperRepository); }

        public async Task CreateUser(User user)
        {
            throw new NotImplementedException();
        }


        public async Task DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            string sql = "SELECT * FROM [AccountMain].[dbo].[User]";
            return await connection.QueryAsync<User>(sql).ConfigureAwait(false);
        }

        public async Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
