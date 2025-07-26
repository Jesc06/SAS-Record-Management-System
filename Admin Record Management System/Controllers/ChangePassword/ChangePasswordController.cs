using Microsoft.AspNetCore.Mvc;
using Admin_Record_Management_System.ViewModels.Account;

namespace Admin_Record_Management_System.Controllers.ChangePassword
{
    public class ChangePasswordController : Controller
    {
        public IActionResult ChangePassword(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("VerifyEmail", "VerifyEmail");
            }
            return View(new ChangePassViewModel { email = username });
        }
    }
}
