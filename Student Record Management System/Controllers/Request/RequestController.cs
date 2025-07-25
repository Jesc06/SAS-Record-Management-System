using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Student_Record_Management_System.Controllers.Request
{
    [Authorize(Roles = "Student")]
    public class RequestController : Controller
    {
        public IActionResult RequestDocuments()
        {
            return View();
        }
    }
}
