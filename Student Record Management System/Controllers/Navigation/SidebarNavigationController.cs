using Microsoft.AspNetCore.Mvc;

namespace Student_Record_Management_System.Controllers.Navigation
{
    public class SidebarNavigationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitDocuments()
        {
            return RedirectToAction("SubmitDocuments", "Submit");
        }


        public IActionResult RequestDocuments()
        {
            return RedirectToAction("RequestDocuments", "Request");
        }


    }
}
