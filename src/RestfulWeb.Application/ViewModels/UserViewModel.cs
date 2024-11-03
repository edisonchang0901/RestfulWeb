using System.ComponentModel.DataAnnotations;

namespace RestfulWeb.Application.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "The UserID is Required")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "The Account is Required")]
        public string Account { get; set; }

        [Required(ErrorMessage = "The Password is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The UserName is Required")]
        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string UserPhone { get; set; }
    }
}
