using RestfulWeb.Domain.Common;

namespace RestfulWeb.Domain.Models
{
    public class User : EntityAudit
    {
        public User() { }

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

   

        public void RecordCreateTime() 
        {
            this.CreatedDateTime = DateTime.Now;
            this.CreatedBy = 1;
        }

        public void Register() 
        {
            byte[] salt = Util.GenerateSalt();
            this.Salt = Convert.ToBase64String(salt);
            this.Password = Util.HashSHA512(this.Password, salt);
            this.IsEnabled = true;
        }

        public void Deny() 
        {
            this.IsEnabled = false;
        }

        public void RecordUpdateTime() 
        {
            this.UpdatedDateTime = DateTime.Now;
            this.UpdatedBy = 1;
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
