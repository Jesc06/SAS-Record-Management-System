using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Record_Management_System.Controllers.Submit
{
    [Authorize(Roles = "Admin")]
    public class SubmitController : Controller
    {
        public IActionResult submit()
        {
            return View();
        }
    }
}
