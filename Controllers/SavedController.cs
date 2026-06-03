using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyotaProject.Data;

namespace ToyotaProject.Controllers
{
    public class SavedController : Controller
    {
        private readonly AppDbContext _db;
        public SavedController(AppDbContext db) => _db = db;

        // GET /Saved
        public async Task<IActionResult> Index()
        {
            var savedIds = HttpContext.Session.GetString("SavedVehicles");
            if (string.IsNullOrEmpty(savedIds))
                return View(new List<ToyotaProject.Models.Vehicle>());

            var ids = savedIds.Split(',')
                .Where(x => int.TryParse(x, out _))
                .Select(int.Parse)
                .ToList();

            var vehicles = await _db.Vehicles
                .Include(v => v.Category)
                .Where(v => ids.Contains(v.Id))
                .ToListAsync();

            return View(vehicles);
        }

        // POST /Saved/Toggle
        [HttpPost]
        public IActionResult Toggle(int vehicleId)
        {
            var savedIds = HttpContext.Session.GetString("SavedVehicles") ?? "";
            var ids = savedIds.Split(',')
                .Where(x => !string.IsNullOrEmpty(x))
                .ToList();

            if (ids.Contains(vehicleId.ToString()))
                ids.Remove(vehicleId.ToString());
            else
                ids.Add(vehicleId.ToString());

            HttpContext.Session.SetString("SavedVehicles", string.Join(',', ids));
            return Json(new { saved = ids.Contains(vehicleId.ToString()), count = ids.Count });
        }
    }
}