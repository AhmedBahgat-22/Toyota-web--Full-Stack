using Microsoft.AspNetCore.Mvc;

namespace ToyotaProject.Controllers
{
    public class ServiceController : Controller
    {
        // GET /Service
        public IActionResult Index() => View();

        // GET /Service/History
        public IActionResult History() => View();

        // GET /Service/Recalls
        public IActionResult Recalls() => View();

        // GET /Service/Schedule
        public IActionResult Schedule() => View();

        // POST /Service/Schedule
        [HttpPost]
        public IActionResult Schedule(string firstName, string lastName,
            string email, string phone, string vehicleModel,
            string serviceType, string preferredDate)
        {
            TempData["ScheduleSuccess"] = "true";
            TempData["CustomerName"] = firstName + " " + lastName;
            TempData["ServiceDate"] = preferredDate;
            return RedirectToAction("ScheduleConfirmation");
        }

        // GET /Service/ScheduleConfirmation
        public IActionResult ScheduleConfirmation() => View();
    }
}