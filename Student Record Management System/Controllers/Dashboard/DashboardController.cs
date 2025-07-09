using Microsoft.AspNetCore.Mvc;

namespace Student_Record_Management_System.Controllers.StudentDashboard
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
