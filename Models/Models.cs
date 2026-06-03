using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyotaProject.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public int Year { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal StartingMSRP { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal AsShownPrice { get; set; }
        public string? Badge { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public string? DriveType { get; set; }
        public string? Engine { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }

    public class Engineer
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public string? Title { get; set; }
        public string? Bio { get; set; }
        public string? ImageUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? LinkedInUrl { get; set; }
    }

    public class Manager
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public string? Role { get; set; }
        public string? ImageUrl { get; set; }
    }

    public class Offer
    {
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? IconClass { get; set; }
    }




public class VehicleTrim
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? FuelType { get; set; }
    public string? MPG { get; set; }
    public string? ImageUrl { get; set; }
    public int VehicleId { get; set; }
    public Vehicle? Vehicle { get; set; }
}

public class VehicleColor
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string HexCode { get; set; } = string.Empty;
    public int VehicleId { get; set; }
    public Vehicle? Vehicle { get; set; }
}






}