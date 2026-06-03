using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyotaProject.Data;

namespace ToyotaProject.Controllers
{
    public class OffersPageController : Controller
    {
        private readonly AppDbContext _db;
        public OffersPageController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var vehicles = await _db.Vehicles
                .Include(v => v.Category)
                .ToListAsync();
            return View(vehicles);
        }
    }
}