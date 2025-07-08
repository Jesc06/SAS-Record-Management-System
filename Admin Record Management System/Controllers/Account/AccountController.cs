using Microsoft.AspNetCore.Mvc;

namespace Admin_Record_Management_System.Controllers.Account
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
