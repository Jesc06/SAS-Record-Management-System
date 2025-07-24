using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Record_Management_System.Controllers.OverallRecords
{
    [Authorize(Roles = "Admin")]
    public class OverallRecordsController : Controller
    {
        public IActionResult AllRecords()
        {
            return View();
        }
    }
}
