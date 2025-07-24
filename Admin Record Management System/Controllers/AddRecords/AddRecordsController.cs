using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Record_Management_System.Controllers.AddRecords
{
    [Authorize(Roles = "Admin")]
    public class AddRecordsController : Controller
    {
        public IActionResult AddRecords()
        {
            return View();
        }
    }
}
