using Admin_Record_Management_System.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAS_Record_Management_System.Application.Features.Account.DTO;
using SAS_Record_Management_System.Application.Features.Account.Services;
using SAS_Record_Management_System.Application.Features.ViewAllStudentAccount.Services;
using System.Threading.Tasks;

namespace Admin_Record_Management_System.Controllers.StudentRegisterAccount
{
    [Authorize(Roles = "Admin")]
    public class StudentRegisterAccountController : Controller
    {
        private readonly GetAllAccountsServices _getAllAccounts;
        private readonly StudentAccountRegistrationService _studentAccountRegistrationService;
             
        public StudentRegisterAccountController(StudentAccountRegistrationService studentAccountRegistrationService, GetAllAccountsServices getAllAccounts)
        {
            _getAllAccounts = getAllAccounts;
            _studentAccountRegistrationService = studentAccountRegistrationService;
        }

        public async Task<IActionResult> Register()
        {
            AccountsModel model = new AccountsModel();
            model.studentAccountRegistrationDTOs = await _getAllAccounts.GetAllAccountsAsync();
        
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> RegisterStudentAccount(AccountsModel model)
        {
            StudentAccountRegistrationDTO registerAccount = new StudentAccountRegistrationDTO {
                FirstName = model.RegisterStudentAccountViewModel.FirstName,
                Middlename = model.RegisterStudentAccountViewModel.MiddleName,
                LastName = model.RegisterStudentAccountViewModel.LastName,
                Email = model.RegisterStudentAccountViewModel.email,
                Password = model.RegisterStudentAccountViewModel.password
            };

            await _studentAccountRegistrationService.RegisterAccount(registerAccount, model.RegisterStudentAccountViewModel.Id);

            model.studentAccountRegistrationDTOs = await _getAllAccounts.GetAllAccountsAsync();
            return View("Register", model);
        }



     




    }
}

