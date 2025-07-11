using Microsoft.AspNetCore.Mvc;
using Admin_Record_Management_System.ViewModels.Account;

namespace Admin_Record_Management_System.Controllers.Account
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }


    }
}
