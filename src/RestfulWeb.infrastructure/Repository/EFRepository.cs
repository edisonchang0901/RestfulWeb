using Microsoft.EntityFrameworkCore;
using RestfulWeb.Domain.Interfaces;
using RestfulWeb.infrastructure.Models;
using User = RestfulWeb.Domain.Models.User;


namespace RestfulWeb.infrastructure.Repository
{
    public class EFRepository : IUserRepository
    {
        private readonly IDbContextFactory<AccountMainContext> _accountMainDbContext;
        public EFRepository(IDbContextFactory<AccountMainContext> accountMainDbContext) 
        {
            _accountMainDbContext = accountMainDbContext;

        }
        public string Name { get => nameof(EFRepository); }

        public async Task CreateUser(User user)
        {
            AccountMainContext ctx =  await _accountMainDbContext.CreateDbContextAsync();
            var userModel = new Models.User() 
            {
                UserId = user.UserId,
                UserName = user.UserName,
                UserEmail = user.UserEmail,
                UserPhone = user.UserPhone,
                Account = user.Account,
                Salt = user.Salt,
                Password = user.Password,
                CreateBy = user.CreatedBy,
                CreateDatetime = user.CreatedDateTime,
                UpdateBy = user.UpdatedBy,
                UpdateDatetime = user.UpdatedDateTime,
                IsEnabled = user.IsEnabled
            };
            ctx.Add(userModel);
            await ctx.SaveChangesAsync().ConfigureAwait(false);
        }


        public async Task DeleteUser(int id)
        {
            AccountMainContext ctx = await _accountMainDbContext.CreateDbContextAsync();
            var user = ctx.Users.FirstOrDefault(x => x.UserId == id);
            ctx.Users.Remove(user);
            await ctx.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<User> GetUser(int id)
        {
            AccountMainContext ctx = await _accountMainDbContext.CreateDbContextAsync();
            var result = ctx.Users.Where(x => x.UserId == id).FirstOrDefault();
            return new User()
            {
                UserId = result.UserId,
                UserName = result.UserName,
                UserEmail = result.UserEmail,
                UserPhone = result.UserPhone,
                Account = result.Account,
                Salt = result.Salt,
                Password = result.Password,
                CreatedBy = result.CreateBy,
                CreatedDateTime = result.CreateDatetime,
                UpdatedBy = result.UpdateBy,
                UpdatedDateTime = result.UpdateDatetime,
                IsEnabled = result.IsEnabled
            };
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            AccountMainContext ctx = await _accountMainDbContext.CreateDbContextAsync();
            var result = ctx.Users.ToList();
            return result.Select(x => new User() 
            {
                UserId = x.UserId,
                UserName = x.UserName,
                UserEmail = x.UserEmail,
                UserPhone = x.UserPhone,
                Account = x.Account,
                Salt = x.Salt,
                Password = x.Password,
                CreatedBy = x.CreateBy,
                CreatedDateTime = x.CreateDatetime,
                UpdatedBy = x.UpdateBy,
                UpdatedDateTime = x.UpdateDatetime,
                IsEnabled = x.IsEnabled
            });
        }

        public async Task UpdateUser(User user)
        {
            AccountMainContext ctx = await _accountMainDbContext.CreateDbContextAsync();
            var userModel = ctx.Users.FirstOrDefault(x => x.UserId == user.UserId);
            userModel.UserId = user.UserId;
            userModel.UserName = user.UserName;
            userModel.Password = user.Password;
            userModel.UserPhone = user.UserPhone;
            userModel.UserEmail = user.UserEmail;
            userModel.Account = user.Account;
            userModel.Salt =  user.Salt;
            userModel.CreateBy = user.CreatedBy;
            userModel.CreateDatetime = user.CreatedDateTime;
            userModel.UpdateBy = user.UpdatedBy;
            userModel.UpdateDatetime = user.UpdatedDateTime;
            userModel.IsEnabled = user.IsEnabled;
            await ctx.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
