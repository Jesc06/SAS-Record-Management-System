using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Record_Management_System.Controllers.Request
{
    [Authorize(Roles = "Admin")]
    public class RequestController : Controller
    {
        public IActionResult request()
        {
            return View();
        }
    }
}
