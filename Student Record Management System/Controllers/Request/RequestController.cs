using Microsoft.AspNetCore.Mvc;

namespace Student_Record_Management_System.Controllers.Request
{
    public class RequestController : Controller
    {
        public IActionResult RequestDocuments()
        {
            return View();
        }
    }
}
