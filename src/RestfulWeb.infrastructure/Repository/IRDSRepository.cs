using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulWeb.infrastructure.Repository
{
    public interface IRDSRepository
    {
        public Task CreateUser();
        public Task GetUser(string id);
        public Task GetUsers(List<string> id);
        public Task UpdateUser();
        public Task DeleteUser();  
    }
}
