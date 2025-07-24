using Admin_Record_Management_System.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SAS_Record_Management_System.Application.Features.Account.DTO;
using SAS_Record_Management_System.Application.Features.Account.Services;

namespace Admin_Record_Management_System.Controllers.Account
{
    [Authorize(Roles = "Admin")]
    public class AccountController : Controller
    {
        private readonly StudentAccountRegistrationService _studentAccountRegistrationService;
        public AccountController(StudentAccountRegistrationService studentAccountRegistrationService)
        {
            _studentAccountRegistrationService = studentAccountRegistrationService;
        }

        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            StudentAccountRegistrationDTO SignInDto = new StudentAccountRegistrationDTO
            {
                Email = model.email,
                Password = model.password
            };
            var SignIn = await _studentAccountRegistrationService.SignIn(SignInDto);
            if (SignIn)
            {
                return RedirectToAction("AdminDashboard", "AdminDashboard");
            }
            else
            {
                ModelState.AddModelError("", "Invalid Email or Password");
                return View();
            } 
        }



    }
}
