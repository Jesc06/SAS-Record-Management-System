using Microsoft.AspNetCore.Mvc;

namespace Admin_Record_Management_System.Controllers.Dashboard
{
    public class AdminDashboardController : Controller
    {
        public IActionResult AdminDashboard()
        {
            return View();
        }
    }
}
