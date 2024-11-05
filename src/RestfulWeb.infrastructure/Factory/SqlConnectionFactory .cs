using Microsoft.Data.SqlClient;
using RestfulWeb.Domain.Interfaces;
using RestfulWeb.Domain.Profiles;
using System.Data;

namespace RestfulWeb.infrastructure.Factory
{
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(ProfileInstance.RDS_ConnectionStrings);
        }
    }
}
