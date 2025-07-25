using Microsoft.AspNetCore.Mvc;
using Student_Record_Management_System.ViewModels.Account;
using SAS_Record_Management_System.Domain.Entities;
using AutoMapper;
using SAS_Record_Management_System.Application.Features.Account.DTO;
using SAS_Record_Management_System.Application.Features.Account.Services;


namespace Student_Record_Management_System.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly StudentAccountRegistrationService _studentAccountRegistrationService;
        private readonly IMapper _mapper;
        public AccountController(IMapper mapper, StudentAccountRegistrationService studentAccountRegistrationService)
        {
            _studentAccountRegistrationService = studentAccountRegistrationService;
            _mapper = mapper;
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("SubmitDocuments", "Submit");
            }
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
               return View("Register",model);
            }
            var dto = _mapper.Map<StudentAccountRegistrationDTO>(model);
            await _studentAccountRegistrationService.AddAccount(dto);
            return RedirectToAction("Login","Account");
        }



        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            StudentAccountRegistrationDTO dto = new StudentAccountRegistrationDTO
            {
                Email = model.email,
                Password = model.password   
            };
            var SignIn = await _studentAccountRegistrationService.SignIn(dto);
            if (SignIn)
            {
                return RedirectToAction("SubmitDocuments", "Submit");
            }
            else
            {
                return View(model);
            }
               
        }


        public async Task<IActionResult> Logout()
        {
            await _studentAccountRegistrationService.Logout();
            return RedirectToAction("Login","Account");
        }



    }
}
