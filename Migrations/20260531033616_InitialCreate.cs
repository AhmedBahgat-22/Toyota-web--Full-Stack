using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyotaProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engineers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Bio = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    FacebookUrl = table.Column<string>(type: "TEXT", nullable: true),
                    TwitterUrl = table.Column<string>(type: "TEXT", nullable: true),
                    LinkedInUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engineers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IconClass = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    StartingMSRP = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AsShownPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Badge = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DriveType = table.Column<string>(type: "TEXT", nullable: true),
                    Engine = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Crossovers & SUVs" },
                    { 2, "Cars & Minivan" },
                    { 3, "Trucks" },
                    { 4, "Performance" },
                    { 5, "Electrified" }
                });

            migrationBuilder.InsertData(
                table: "Engineers",
                columns: new[] { "Id", "Bio", "FacebookUrl", "ImageUrl", "LinkedInUrl", "Name", "Title", "TwitterUrl" },
                values: new object[,]
                {
                    { 1, "Ohno invented Lean Manufacturing, a system that eliminated waste in time and resources.", null, "/images/Taiichi Ohno.jpg", null, "Taiichi Ohno", "Industrial Engineer", null },
                    { 2, "He was the primary mechanic and engineer behind the greatest Toyota and Lexus sports cars.", null, "/images/Hiromu Naruse.webp", null, "Hiromu Naruse", "Technical Legend", null },
                    { 3, "Tada is the mastermind who designed the Toyota 86 and the new Toyota GR Supra.", null, "/images/Tetsuya Tadawebp.webp", null, "Tetsuya Tada", "Iconic Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "ImageUrl", "Name", "Role" },
                values: new object[,]
                {
                    { 1, "/images/Sakichi .jpg", "Sakichi Toyoda", "Parent company founder" },
                    { 2, "/images/Kiichiro_Toyoda.jpg", "Risaburo Toyoda", "1st President" },
                    { 3, "/images/Rizaburo_Toyoda.jpg", "Kiichiro Toyoda", "2nd President & Car division founder" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "IconClass", "Title" },
                values: new object[,]
                {
                    { 1, "We offer comprehensive insurance plans to protect your vehicle.", "fa-solid fa-car-burst", "Full Insurance" },
                    { 2, "Our professional team provides regular check-ups and repairs.", "fa-solid fa-screwdriver-wrench", "Expert Maintenance" },
                    { 3, "Link your Toyota Financial Services account to make payments.", "fa-brands fa-cc-visa", "Manage Vehicle Payments" },
                    { 4, "Get information on open safety recalls and service campaigns.", "fa-solid fa-phone", "Safety Recall Information" },
                    { 5, "Transparent contracts and verified car histories.", "fa-solid fa-handshake", "Trusted Deals" },
                    { 6, "Schedule a service appointment online at one of our dealers.", "fa-solid fa-calendar", "Schedule Toyota Service" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "AsShownPrice", "Badge", "CategoryId", "Description", "DriveType", "Engine", "ImageUrl", "Name", "StartingMSRP", "Year" },
                values: new object[,]
                {
                    { 1, 30655m, "Hybrid EV Available", 1, "Hit the road and let your story unfold.", "FWD or AWD", "2.0L Dynamic Force Engine", "/images/Crossover.webp", "Corolla Cross", 25235m, 2026 },
                    { 2, 65000m, "Hybrid EV", 1, "Our heritage. Your adventure.", "Full-Time 4WD", "2.4L i-FORCE MAX Hybrid", "/images/suv_(Off-Road).jpg", "Land Cruiser", 57880m, 2026 },
                    { 3, 34000m, "Hybrid EV Available", 2, "The legend continues to evolve.", "FWD", "2.5L 4-Cylinder", "/images/toyota_camry_ Sedan.webp", "Camry", 29495m, 2026 },
                    { 4, 28000m, null, 2, "Sport Drive Mode with Paddle Shifters.", "AWD", "2.0L Dynamic Force Engine", "/images/(Hatchback).jpg", "Corolla Hatchback", 24580m, 2026 },
                    { 5, 62000m, null, 4, "Born on the track. Built for the road.", "RWD", "3.0L Twin-Scroll Turbo I6", "/images/Coupe.jpg", "GR Supra", 56645m, 2026 },
                    { 6, 43775m, "Battery EV", 5, "Charge forward into the future.", "FWD or AWD", "Electric Motor 201 hp", "/images/EVs.webp", "bZ4X", 34900m, 2026 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CategoryId",
                table: "Vehicles",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engineers");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
