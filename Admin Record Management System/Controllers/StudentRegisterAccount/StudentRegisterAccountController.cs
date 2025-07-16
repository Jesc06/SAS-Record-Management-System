using Microsoft.AspNetCore.Mvc;
using SAS_Record_Management_System.Application.Features.ViewAllStudentAccount.Interfaces;

namespace Admin_Record_Management_System.Controllers.StudentRegisterAccount
{
    public class StudentRegisterAccountController : Controller
    {
        private readonly IGetAllAccounts _getAllAccounts;
        public StudentRegisterAccountController(IGetAllAccounts getAllAccounts)
        {
            _getAllAccounts = getAllAccounts;
        }

        public async Task<IActionResult> Register()
        {
            var GetAllAccounts = await _getAllAccounts.GetAllAccounts();
            return View(GetAllAccounts);
        }
    }
}
