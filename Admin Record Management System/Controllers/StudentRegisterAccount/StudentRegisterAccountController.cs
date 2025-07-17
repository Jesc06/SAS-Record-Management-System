using Microsoft.AspNetCore.Mvc;
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
            var GetAllAccounts = await _getAllAccounts.GetAllAccountsAsync();
            return View(GetAllAccounts);
        }      


    }
}
