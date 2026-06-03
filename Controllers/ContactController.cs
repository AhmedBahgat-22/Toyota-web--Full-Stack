using Microsoft.AspNetCore.Mvc;

namespace ToyotaProject.Controllers
{
    public class ContactController : Controller
    {
        // GET /Contact
        public IActionResult Index() => View();

        // POST /Contact/Send
        [HttpPost]
        public IActionResult Send(string firstName, string lastName,
            string email, string phone, string subject, string message)
        {
            TempData["ContactSuccess"] = "true";
            TempData["ContactName"] = firstName + " " + lastName;
            return RedirectToAction("Confirmation");
        }

        // GET /Contact/Confirmation
        public IActionResult Confirmation() => View();
    }
}