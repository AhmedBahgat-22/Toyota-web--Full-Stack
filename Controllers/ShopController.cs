using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyotaProject.Data;

namespace ToyotaProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _db;
        public ShopController(AppDbContext db) => _db = db;

        // GET /Shop
        public async Task<IActionResult> Index()
        {
            var vehicles = await _db.Vehicles
                .Include(v => v.Category)
                .ToListAsync();
            return View(vehicles);
        }

        // GET /Shop/Checkout/5
        public async Task<IActionResult> Checkout(int id)
        {
            var vehicle = await _db.Vehicles
                .Include(v => v.Category)
                .FirstOrDefaultAsync(v => v.Id == id);
            if (vehicle == null) return NotFound();
            return View(vehicle);
        }

        // POST /Shop/PlaceOrder
        [HttpPost]
        public IActionResult PlaceOrder(int vehicleId, string firstName,
            string lastName, string email, string phone,
            string cardNumber, string expiry, string cvv)
        {
            // هنا ممكن تحفظ الأوردر في DB لاحقاً
            TempData["OrderSuccess"] = "true";
            TempData["OrderName"] = firstName + " " + lastName;
            return RedirectToAction("OrderConfirmation", new { vehicleId });
        }

        // GET /Shop/OrderConfirmation
        public async Task<IActionResult> OrderConfirmation(int vehicleId)
        {
            var vehicle = await _db.Vehicles.FindAsync(vehicleId);
            return View(vehicle);
        }
    }
}