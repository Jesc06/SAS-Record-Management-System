using System.ComponentModel.DataAnnotations;

namespace Admin_Record_Management_System.ViewModels.Account
{
    public class RegisterStudentAccountViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is reaquired")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is reaquired")]
        public string password { get; set; }
    }
}
