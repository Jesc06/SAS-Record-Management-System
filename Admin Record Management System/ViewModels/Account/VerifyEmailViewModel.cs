using System.ComponentModel.DataAnnotations;

namespace Admin_Record_Management_System.ViewModels.Account
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Please input your email address")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
