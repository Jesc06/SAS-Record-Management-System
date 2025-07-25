using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Student_Record_Management_System.Controllers.StudentDashboard
{
    [Authorize(Roles = "Student")]
    public class SubmitController : Controller
    {
        public IActionResult SubmitDocuments()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
    }
}
