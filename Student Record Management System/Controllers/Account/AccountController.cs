using Microsoft.AspNetCore.Mvc;

namespace Student_Record_Management_System.Controllers.Account
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
