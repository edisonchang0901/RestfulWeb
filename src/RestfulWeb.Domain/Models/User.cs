namespace RestfulWeb.Domain.Models
{
    public class User : EntityAudit
    {
        public User(int userId,
                    string account,
                    string password,
                    string userName,
                    string userEmail,
                    string userPhone) 
        {
            this.UserId = userId;
            this.Account = account;
            this.Password = password;
            this.UserName = userName;
            this.UserEmail = userEmail;
            this.UserPhone = userPhone;
        }

        /// <summary>
        /// 更新使用者資訊
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <param name="userName"></param>
        /// <param name="userEmail"></param>
        /// <param name="userPhone"></param>
        public void Update(string account,
                           string password,
                           string userName,
                           string userEmail,
                           string userPhone) 
        {
            this.Account = account;
            this.Password = password;
            this.UserName = userName;
            this.UserEmail = userEmail;
            this.UserPhone = userPhone;
        }


        public int UserId { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public int? RoleId { get; set; }
        public bool IsEnabled { get; set; }
    }
}
