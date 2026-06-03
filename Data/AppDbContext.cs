using Microsoft.EntityFrameworkCore;
using ToyotaProject.Models;

namespace ToyotaProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Vehicle>   Vehicles   { get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Engineer>  Engineers  { get; set; }
        public DbSet<Manager>   Managers   { get; set; }
        public DbSet<Offer>     Offers     { get; set; }

        public DbSet<VehicleTrim>  VehicleTrims  { get; set; }
        public DbSet<VehicleColor> VehicleColors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Crossovers & SUVs" },
                new Category { Id = 2, Name = "Cars & Minivan" },
                new Category { Id = 3, Name = "Trucks" },
                new Category { Id = 4, Name = "Performance" },
                new Category { Id = 5, Name = "Electrified" }
            );

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { Id = 1, Name = "Corolla Cross", Year = 2026, StartingMSRP = 25235, AsShownPrice = 30655, Badge = "Hybrid EV Available", ImageUrl = "/images/Crossover.webp", DriveType = "FWD or AWD", Engine = "2.0L Dynamic Force Engine", Description = "Hit the road and let your story unfold.", CategoryId = 1 },
                new Vehicle { Id = 2, Name = "Land Cruiser", Year = 2026, StartingMSRP = 57880, AsShownPrice = 65000, Badge = "Hybrid EV", ImageUrl = "/images/suv_(Off-Road).jpg", DriveType = "Full-Time 4WD", Engine = "2.4L i-FORCE MAX Hybrid", Description = "Our heritage. Your adventure.", CategoryId = 1 },
                new Vehicle { Id = 3, Name = "Camry", Year = 2026, StartingMSRP = 29495, AsShownPrice = 34000, Badge = "Hybrid EV Available", ImageUrl = "/images/toyota_camry_ Sedan.webp", DriveType = "FWD", Engine = "2.5L 4-Cylinder", Description = "The legend continues to evolve.", CategoryId = 2 },
                new Vehicle { Id = 4, Name = "Corolla Hatchback", Year = 2026, StartingMSRP = 24580, AsShownPrice = 28000, Badge = null, ImageUrl = "/images/(Hatchback).jpg", DriveType = "AWD", Engine = "2.0L Dynamic Force Engine", Description = "Sport Drive Mode with Paddle Shifters.", CategoryId = 2 },
                new Vehicle { Id = 5, Name = "GR Supra", Year = 2026, StartingMSRP = 56645, AsShownPrice = 62000, Badge = null, ImageUrl = "/images/Coupe.jpg", DriveType = "RWD", Engine = "3.0L Twin-Scroll Turbo I6", Description = "Born on the track. Built for the road.", CategoryId = 4 },
                new Vehicle { Id = 6, Name = "bZ4X", Year = 2026, StartingMSRP = 34900, AsShownPrice = 43775, Badge = "Battery EV", ImageUrl = "/images/EVs.webp", DriveType = "FWD or AWD", Engine = "Electric Motor 201 hp", Description = "Charge forward into the future.", CategoryId = 5 }
            );

            modelBuilder.Entity<Engineer>().HasData(
                new Engineer { Id = 1, Name = "Taiichi Ohno", Title = "Industrial Engineer", Bio = "Ohno invented Lean Manufacturing, a system that eliminated waste in time and resources.", ImageUrl = "/images/Taiichi Ohno.jpg" },
                new Engineer { Id = 2, Name = "Hiromu Naruse", Title = "Technical Legend", Bio = "He was the primary mechanic and engineer behind the greatest Toyota and Lexus sports cars.", ImageUrl = "/images/Hiromu Naruse.webp" },
                new Engineer { Id = 3, Name = "Tetsuya Tada", Title = "Iconic Engineer", Bio = "Tada is the mastermind who designed the Toyota 86 and the new Toyota GR Supra.", ImageUrl = "/images/Tetsuya Tadawebp.webp" }
            );

            modelBuilder.Entity<Manager>().HasData(
                new Manager { Id = 1, Name = "Sakichi Toyoda",  Role = "Parent company founder",              ImageUrl = "/images/Sakichi .jpg" },
                new Manager { Id = 2, Name = "Risaburo Toyoda", Role = "1st President",                       ImageUrl = "/images/Kiichiro_Toyoda.jpg" },
                new Manager { Id = 3, Name = "Kiichiro Toyoda", Role = "2nd President & Car division founder", ImageUrl = "/images/Rizaburo_Toyoda.jpg" }
            );

            modelBuilder.Entity<Offer>().HasData(
                new Offer { Id = 1, Title = "Full Insurance",           Description = "We offer comprehensive insurance plans to protect your vehicle.", IconClass = "fa-solid fa-car-burst" },
                new Offer { Id = 2, Title = "Expert Maintenance",       Description = "Our professional team provides regular check-ups and repairs.", IconClass = "fa-solid fa-screwdriver-wrench" },
                new Offer { Id = 3, Title = "Manage Vehicle Payments",  Description = "Link your Toyota Financial Services account to make payments.", IconClass = "fa-brands fa-cc-visa" },
                new Offer { Id = 4, Title = "Safety Recall Information",Description = "Get information on open safety recalls and service campaigns.", IconClass = "fa-solid fa-phone" },
                new Offer { Id = 5, Title = "Trusted Deals",            Description = "Transparent contracts and verified car histories.", IconClass = "fa-solid fa-handshake" },
                new Offer { Id = 6, Title = "Schedule Toyota Service",  Description = "Schedule a service appointment online at one of our dealers.", IconClass = "fa-solid fa-calendar" }
            );





            // ===== Seed Trims =====
modelBuilder.Entity<VehicleTrim>().HasData(
    // Corolla Cross (id=1)
    new VehicleTrim { Id=1,  VehicleId=1, Name="L",          Price=25235, FuelType="Gas",    MPG="31/33", ImageUrl="/images/Crossover.webp" },
    new VehicleTrim { Id=2,  VehicleId=1, Name="LE",         Price=27565, FuelType="Gas",    MPG="31/33", ImageUrl="/images/Crossover.webp" },
    new VehicleTrim { Id=3,  VehicleId=1, Name="Hybrid S",   Price=29595, FuelType="Hybrid", MPG="46/39", ImageUrl="/images/Crossover.webp" },
    new VehicleTrim { Id=4,  VehicleId=1, Name="XLE",        Price=30160, FuelType="Gas",    MPG="31/33", ImageUrl="/images/Crossover.webp" },
    // Land Cruiser (id=2)
    new VehicleTrim { Id=5,  VehicleId=2, Name="1958",       Price=57880, FuelType="Hybrid", MPG="22/25", ImageUrl="/images/suv_(Off-Road).jpg" },
    new VehicleTrim { Id=6,  VehicleId=2, Name="First Edition", Price=65000, FuelType="Hybrid", MPG="22/25", ImageUrl="/images/suv_(Off-Road).jpg" },
    // Camry (id=3)
    new VehicleTrim { Id=7,  VehicleId=3, Name="LE",         Price=29495, FuelType="Hybrid", MPG="51/53", ImageUrl="/images/toyota_camry_ Sedan.webp" },
    new VehicleTrim { Id=8,  VehicleId=3, Name="SE",         Price=31270, FuelType="Hybrid", MPG="44/47", ImageUrl="/images/toyota_camry_ Sedan.webp" },
    new VehicleTrim { Id=9,  VehicleId=3, Name="XLE",        Price=35270, FuelType="Hybrid", MPG="51/53", ImageUrl="/images/toyota_camry_ Sedan.webp" },
    new VehicleTrim { Id=10, VehicleId=3, Name="XSE",        Price=36270, FuelType="Hybrid", MPG="44/47", ImageUrl="/images/toyota_camry_ Sedan.webp" },
    // Corolla Hatchback (id=4)
    new VehicleTrim { Id=11, VehicleId=4, Name="SE",         Price=24580, FuelType="Gas",    MPG="32/41", ImageUrl="/images/(Hatchback).jpg" },
    new VehicleTrim { Id=12, VehicleId=4, Name="XSE",        Price=27080, FuelType="Gas",    MPG="32/41", ImageUrl="/images/(Hatchback).jpg" },
    // GR Supra (id=5)
    new VehicleTrim { Id=13, VehicleId=5, Name="2.0",        Price=56645, FuelType="Gas",    MPG="25/32", ImageUrl="/images/Coupe.jpg" },
    new VehicleTrim { Id=14, VehicleId=5, Name="3.0",        Price=59995, FuelType="Gas",    MPG="22/30", ImageUrl="/images/Coupe.jpg" },
    new VehicleTrim { Id=15, VehicleId=5, Name="3.0 Premium",Price=66495, FuelType="Gas",    MPG="22/30", ImageUrl="/images/Coupe.jpg" },
    // bZ4X (id=6)
    new VehicleTrim { Id=16, VehicleId=6, Name="XLE",        Price=34900, FuelType="Electric", MPG="116 MPGe", ImageUrl="/images/EVs.webp" },
    new VehicleTrim { Id=17, VehicleId=6, Name="Limited",    Price=44900, FuelType="Electric", MPG="113 MPGe", ImageUrl="/images/EVs.webp" }
);

// ===== Seed Colors =====
modelBuilder.Entity<VehicleColor>().HasData(
    // Corolla Cross
    new VehicleColor { Id=1,  VehicleId=1, Name="Wind Chill Pearl",    HexCode="#F0F0F0" },
    new VehicleColor { Id=2,  VehicleId=1, Name="Midnight Black",      HexCode="#1a1a1a" },
    new VehicleColor { Id=3,  VehicleId=1, Name="Blueprint",           HexCode="#2B4C8C" },
    new VehicleColor { Id=4,  VehicleId=1, Name="Supersonic Red",      HexCode="#CC2200" },
    // Land Cruiser
    new VehicleColor { Id=5,  VehicleId=2, Name="White Pearl",         HexCode="#F5F5F0" },
    new VehicleColor { Id=6,  VehicleId=2, Name="Midnight Black",      HexCode="#1a1a1a" },
    new VehicleColor { Id=7,  VehicleId=2, Name="Sandstorm",           HexCode="#C8A882" },
    new VehicleColor { Id=8,  VehicleId=2, Name="Army Green",          HexCode="#4A5240" },
    // Camry
    new VehicleColor { Id=9,  VehicleId=3, Name="Midnight Black",      HexCode="#1a1a1a" },
    new VehicleColor { Id=10, VehicleId=3, Name="Wind Chill Pearl",    HexCode="#F0F0F0" },
    new VehicleColor { Id=11, VehicleId=3, Name="Supersonic Red",      HexCode="#CC2200" },
    new VehicleColor { Id=12, VehicleId=3, Name="Cavalry Blue",        HexCode="#2B4C8C" },
    // Corolla Hatchback
    new VehicleColor { Id=13, VehicleId=4, Name="Midnight Black",      HexCode="#1a1a1a" },
    new VehicleColor { Id=14, VehicleId=4, Name="White Pearl",         HexCode="#F5F5F0" },
    new VehicleColor { Id=15, VehicleId=4, Name="Supersonic Red",      HexCode="#CC2200" },
    new VehicleColor { Id=16, VehicleId=4, Name="Ice Cap",             HexCode="#E8E8E8" },
    // GR Supra
    new VehicleColor { Id=17, VehicleId=5, Name="Absolute Zero White", HexCode="#F8F8F8" },
    new VehicleColor { Id=18, VehicleId=5, Name="Midnight Black",      HexCode="#1a1a1a" },
    new VehicleColor { Id=19, VehicleId=5, Name="Renaissance Red",     HexCode="#AA1100" },
    new VehicleColor { Id=20, VehicleId=5, Name="Refraction Blue",     HexCode="#1E3A8A" },
    // bZ4X
    new VehicleColor { Id=21, VehicleId=6, Name="Wind Chill Pearl",    HexCode="#F0F0F0" },
    new VehicleColor { Id=22, VehicleId=6, Name="Midnight Black",      HexCode="#1a1a1a" },
    new VehicleColor { Id=23, VehicleId=6, Name="Heavy Metal",         HexCode="#6B7280" },
    new VehicleColor { Id=24, VehicleId=6, Name="Blueprint",           HexCode="#2B4C8C" }
);




















        }
    }
}