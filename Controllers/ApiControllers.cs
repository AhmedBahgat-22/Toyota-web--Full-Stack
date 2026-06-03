using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyotaProject.Data;
using ToyotaProject.Models;

namespace ToyotaProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly AppDbContext _db;
        public VehiclesController(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int? categoryId)
        {
            var query = _db.Vehicles.Include(v => v.Category).AsQueryable();
            if (categoryId.HasValue)
                query = query.Where(v => v.CategoryId == categoryId.Value);

            var vehicles = await query.Select(v => new
            {
                v.Id, v.Name, v.Year, v.StartingMSRP,
                v.AsShownPrice, v.Badge, v.ImageUrl,
                v.DriveType, v.Engine, v.Description,
                CategoryName = v.Category!.Name
            }).ToListAsync();

            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var v = await _db.Vehicles
                .Include(v => v.Category)
                .FirstOrDefaultAsync(v => v.Id == id);
            if (v == null) return NotFound();
            return Ok(new
            {
                v.Id, v.Name, v.Year, v.StartingMSRP,
                v.AsShownPrice, v.Badge, v.ImageUrl,
                v.DriveType, v.Engine, v.Description,
                CategoryName = v.Category!.Name,
                v.CategoryId
            });
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _db;
        public CategoriesController(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _db.Categories.ToListAsync());
    }

    [ApiController]
    [Route("api/[controller]")]
    public class EngineersController : ControllerBase
    {
        private readonly AppDbContext _db;
        public EngineersController(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _db.Engineers.ToListAsync());
    }

    [ApiController]
    [Route("api/[controller]")]
    public class ManagersController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ManagersController(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _db.Managers.ToListAsync());
    }

    [ApiController]
    [Route("api/[controller]")]
    public class OffersController : ControllerBase
    {
        private readonly AppDbContext _db;
        public OffersController(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _db.Offers.ToListAsync());
    }
}