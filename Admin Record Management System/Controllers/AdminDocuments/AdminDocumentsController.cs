using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Record_Management_System.Controllers.AdminDocuments
{
    [Authorize(Roles = "Admin")]
    public class AdminDocumentsController : Controller
    {
        public IActionResult AdminDocuments()
        {
            return View();
        }
    }
}
