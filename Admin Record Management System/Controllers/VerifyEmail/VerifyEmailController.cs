using Microsoft.AspNetCore.Mvc;
using SAS_Record_Management_System.Application.Features.Account.Services;
using Admin_Record_Management_System.ViewModels.Account;
using SAS_Record_Management_System.Application.Features.Account.DTO;

namespace Admin_Record_Management_System.Controllers.VerifyEmail
{
    public class VerifyEmailController : Controller
    {
        private readonly StudentAccountRegistrationService _studentAccountRegistrationService;
        public VerifyEmailController(StudentAccountRegistrationService studentAccountRegistrationService)
        {
            _studentAccountRegistrationService = studentAccountRegistrationService;
        }


        public IActionResult VerifyEmail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CheckIfEmailIsExist(VerifyEmailViewModel emailViewModel)
        {
            StudentAccountRegistrationDTO verifyEmailExistence = new StudentAccountRegistrationDTO
            {
                Email = emailViewModel.Email,
            };
            var verify = await _studentAccountRegistrationService.VerifyEmail(verifyEmailExistence);
            if (verify)
            {
                return RedirectToAction("ChangePassword", "ChangePassword", new { username = emailViewModel.Email });
            }
            return View("VerifyEmail");
        }


    }
}
