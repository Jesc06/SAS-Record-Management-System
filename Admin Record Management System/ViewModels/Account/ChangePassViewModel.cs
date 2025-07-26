namespace Admin_Record_Management_System.ViewModels.Account
{
    public class ChangePassViewModel
    {
        public string email { get; set; }   
        public string currentPassword { get; set; } 
        public string newPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
