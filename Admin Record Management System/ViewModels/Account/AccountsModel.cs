using SAS_Record_Management_System.Application.Features.Account.DTO;
using Admin_Record_Management_System.ViewModels.Account;
namespace Admin_Record_Management_System.ViewModels.Account
{
    public class AccountsModel
    {
        public List<StudentAccountRegistrationDTO> studentAccountRegistrationDTOs { get; set; }
        public RegisterStudentAccountViewModel RegisterStudentAccountViewModel { get; set; } = new RegisterStudentAccountViewModel();
    }
}
