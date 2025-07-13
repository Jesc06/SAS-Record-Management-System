using Microsoft.AspNetCore.Mvc;
using Student_Record_Management_System.ViewModels.Account;
using SAS_Record_Management_System.Application.Services;
using SAS_Record_Management_System.Domain.Entities;
using AutoMapper;

namespace Student_Record_Management_System.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly StudentAccountRegistrationService _studentAccountRegistrationService;

        public AccountController( StudentAccountRegistrationService studentAccountRegistrationService)
        {
            _studentAccountRegistrationService = studentAccountRegistrationService;
      
        }

        public IActionResult Login()
        {
            return View();
        }



        public IActionResult Register()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> RegisterStudent(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
               ModelState.AddModelError("", "Please fill in all required fields correctly.");
                return View("Register", "Account");
            }
            StudentAccountRegistration dto = new StudentAccountRegistration
            {
                FirstName = model.FirstName,
                Middlename = model.Middlename,
                LastName = model.LastName,
                Gender = model.Gender,
                YearOfBirth = model.YearOfBirth,
                MonthOfBirth = model.MonthOfBirth,
                DateOfBirth = model.DateOfBirth,
                HomeAddress = model.HomeAddress,
                MobileNumber = model.MobileNumber,
                Email = model.Email,
                Program = model.Program,
                YearLevel = model.YearLevel,
                StudentID = model.StudentID,
                Password = model.Password,
                ConfirmPassword = model.ConfirmPassword

            };

            try
            {
                var result = await _studentAccountRegistrationService.RegisterAccountAsync(dto);

                if (!result || dto is null || model is null)
                {
                    ModelState.AddModelError("", "Registration failed. Please try again.");
                    return View("Register", model);
                }

                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error occurred during registration: {ex.Message}");
                return View("Register", model);
            }


        }



        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View(model);
        }

    }
}
