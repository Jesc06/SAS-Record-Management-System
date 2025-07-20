using Admin_Record_Management_System.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;
using SAS_Record_Management_System.Application.Features.Account.DTO;
using SAS_Record_Management_System.Application.Features.ViewAllStudentAccount.Services;
using System.Threading.Tasks;

namespace Admin_Record_Management_System.Controllers.StudentRegisterAccount
{
    public class StudentRegisterAccountController : Controller
    {
        private readonly GetAllAccountsServices _getAllAccounts;
             
        public StudentRegisterAccountController(GetAllAccountsServices getAllAccounts)
        {
            _getAllAccounts = getAllAccounts;
        }

        public async Task<IActionResult> Register()
        {
            var model = await _getAllAccounts.GetAllAccountsAsync();
            var map = new AccountsModel
            {
                studentAccountRegistrationDTOs = model,
                RegisterStudentAccountViewModel = new RegisterStudentAccountViewModel()
            };
            return View(map);
        }   
        

        public async Task<IActionResult> RegisterStudentAccount(AccountsModel model)
        {
            model.studentAccountRegistrationDTOs = await _getAllAccounts.GetAllAccountsAsync();
            return View("Register", model);
        }






    }
}

