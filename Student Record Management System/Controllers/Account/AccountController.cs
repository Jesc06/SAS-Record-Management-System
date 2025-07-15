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
            await _studentAccountRegistrationService.RegisterAccountAsync(dto);
            return RedirectToAction("Login","Account");
        }



        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View(model);
        }

    }
}
