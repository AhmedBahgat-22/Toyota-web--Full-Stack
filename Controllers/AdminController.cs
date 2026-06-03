using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToyotaProject.Data;
using ToyotaProject.Filters;
using ToyotaProject.Models;

namespace ToyotaProject.Controllers
{
    [AdminAuthFilter]
    public class AdminController : Controller
    {
        private readonly AppDbContext _db;
        public AdminController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            ViewBag.VehiclesCount  = await _db.Vehicles.CountAsync();
            ViewBag.EngineersCount = await _db.Engineers.CountAsync();
            ViewBag.ManagersCount  = await _db.Managers.CountAsync();
            return View();
        }

        // ── Vehicles ──────────────────────────────────────
        public async Task<IActionResult> Vehicles() =>
            View(await _db.Vehicles.Include(v => v.Category).ToListAsync());

        public async Task<IActionResult> CreateVehicle()
        {
            ViewBag.Categories = new SelectList(await _db.Categories.ToListAsync(), "Id", "Name");
            return View(new Vehicle());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVehicle(Vehicle v)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(await _db.Categories.ToListAsync(), "Id", "Name");
                return View(v);
            }
            _db.Vehicles.Add(v);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Vehicles));
        }

        public async Task<IActionResult> EditVehicle(int id)
        {
            var v = await _db.Vehicles.FindAsync(id);
            if (v == null) return NotFound();
            ViewBag.Categories = new SelectList(await _db.Categories.ToListAsync(), "Id", "Name", v.CategoryId);
            return View(v);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditVehicle(Vehicle v)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(await _db.Categories.ToListAsync(), "Id", "Name");
                return View(v);
            }
            _db.Update(v);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Vehicles));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var v = await _db.Vehicles.FindAsync(id);
            if (v != null) { _db.Vehicles.Remove(v); await _db.SaveChangesAsync(); }
            return RedirectToAction(nameof(Vehicles));
        }

        // ── Engineers ─────────────────────────────────────
        public async Task<IActionResult> Engineers() =>
            View(await _db.Engineers.ToListAsync());

        public IActionResult CreateEngineer() => View(new Engineer());

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEngineer(Engineer e)
        {
            if (!ModelState.IsValid) return View(e);
            _db.Engineers.Add(e);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Engineers));
        }

        public async Task<IActionResult> EditEngineer(int id)
        {
            var e = await _db.Engineers.FindAsync(id);
            return e == null ? NotFound() : View(e);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEngineer(Engineer e)
        {
            if (!ModelState.IsValid) return View(e);
            _db.Update(e);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Engineers));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteEngineer(int id)
        {
            var e = await _db.Engineers.FindAsync(id);
            if (e != null) { _db.Engineers.Remove(e); await _db.SaveChangesAsync(); }
            return RedirectToAction(nameof(Engineers));
        }

        // ── Managers ──────────────────────────────────────
        public async Task<IActionResult> Managers() =>
            View(await _db.Managers.ToListAsync());

        public IActionResult CreateManager() => View(new Manager());

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateManager(Manager m)
        {
            if (!ModelState.IsValid) return View(m);
            _db.Managers.Add(m);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Managers));
        }

        public async Task<IActionResult> EditManager(int id)
        {
            var m = await _db.Managers.FindAsync(id);
            return m == null ? NotFound() : View(m);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditManager(Manager m)
        {
            if (!ModelState.IsValid) return View(m);
            _db.Update(m);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Managers));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteManager(int id)
        {
            var m = await _db.Managers.FindAsync(id);
            if (m != null) { _db.Managers.Remove(m); await _db.SaveChangesAsync(); }
            return RedirectToAction(nameof(Managers));
        }
    }
}