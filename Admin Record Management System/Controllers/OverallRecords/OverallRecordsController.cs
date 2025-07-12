using Microsoft.AspNetCore.Mvc;

namespace Admin_Record_Management_System.Controllers.OverallRecords
{
    public class OverallRecordsController : Controller
    {
        public IActionResult AllRecords()
        {
            return View();
        }
    }
}
