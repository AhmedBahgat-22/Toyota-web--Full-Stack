using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyotaProject.Data;

namespace ToyotaProject.Controllers
{
    public class VehiclePageController : Controller
    {
        private readonly AppDbContext _db;
        public VehiclePageController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var categories = await _db.Categories.ToListAsync();
            return View(categories);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var v = await _db.Vehicles
                .Include(v => v.Category)
                .FirstOrDefaultAsync(v => v.Id == id);
            if (v == null) return NotFound();
            return View(v);
        }
    }
}