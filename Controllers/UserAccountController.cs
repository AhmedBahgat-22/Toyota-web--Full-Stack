using Microsoft.AspNetCore.Mvc;

namespace ToyotaProject.Controllers
{
    public class UserAccountController : Controller
    {
        // GET /UserAccount
        public IActionResult Index() => View();

        // POST /UserAccount/Register
        [HttpPost]
        public IActionResult Register(string firstName, string lastName,
            string email, string password)
        {
            HttpContext.Session.SetString("UserLoggedIn", "true");
            HttpContext.Session.SetString("UserName", firstName + " " + lastName);
            HttpContext.Session.SetString("UserEmail", email);
            return RedirectToAction("Dashboard");
        }

        // POST /UserAccount/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Demo login
            HttpContext.Session.SetString("UserLoggedIn", "true");
            HttpContext.Session.SetString("UserName", email.Split('@')[0]);
            HttpContext.Session.SetString("UserEmail", email);
            return RedirectToAction("Dashboard");
        }

        // GET /UserAccount/Dashboard
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserLoggedIn") != "true")
                return RedirectToAction("Index");
            return View();
        }

        // GET /UserAccount/Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserLoggedIn");
            HttpContext.Session.Remove("UserName");
            HttpContext.Session.Remove("UserEmail");
            return RedirectToAction("Index");
        }
    }
}