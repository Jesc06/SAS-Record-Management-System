using System.ComponentModel.DataAnnotations;

namespace Admin_Record_Management_System.ViewModels.Account
{
    public class RegisterStudentAccountViewModel
    {

        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "MiddleName is required")]
        public string MiddleName { get; set; }  


        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }



        [EmailAddress]
        [Required(ErrorMessage = "Email is reaquired")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is reaquired")]
        public string password { get; set; }
    }
}
