using System.ComponentModel.DataAnnotations;

namespace Admin_Record_Management_System.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your email")]
        public required string email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public required string password { get; set; }
    }
}
