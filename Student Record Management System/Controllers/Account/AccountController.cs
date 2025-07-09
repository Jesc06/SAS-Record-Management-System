using Microsoft.AspNetCore.Mvc;
using Student_Record_Management_System.ViewModels.Account;

namespace Student_Record_Management_System.Controllers.Account
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View(model);
        }

    }
}
