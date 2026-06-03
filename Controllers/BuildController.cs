using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyotaProject.Data;

namespace ToyotaProject.Controllers
{
    public class BuildController : Controller
    {
        private readonly AppDbContext _db;
        public BuildController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index(int id)
        {
            var vehicle = await _db.Vehicles
                .Include(v => v.Category)
                .FirstOrDefaultAsync(v => v.Id == id);
            if (vehicle == null) return NotFound();

            ViewBag.Trims  = await _db.VehicleTrims.Where(t => t.VehicleId == id).ToListAsync();
            ViewBag.Colors = await _db.VehicleColors.Where(c => c.VehicleId == id).ToListAsync();

            return View(vehicle);
        }
    }
}