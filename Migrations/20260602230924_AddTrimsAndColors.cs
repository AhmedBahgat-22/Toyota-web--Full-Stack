using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyotaProject.Migrations
{
    /// <inheritdoc />
    public partial class AddTrimsAndColors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    HexCode = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleColors_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTrims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    FuelType = table.Column<string>(type: "TEXT", nullable: true),
                    MPG = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    VehicleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTrims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleTrims_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VehicleColors",
                columns: new[] { "Id", "HexCode", "Name", "VehicleId" },
                values: new object[,]
                {
                    { 1, "#F0F0F0", "Wind Chill Pearl", 1 },
                    { 2, "#1a1a1a", "Midnight Black", 1 },
                    { 3, "#2B4C8C", "Blueprint", 1 },
                    { 4, "#CC2200", "Supersonic Red", 1 },
                    { 5, "#F5F5F0", "White Pearl", 2 },
                    { 6, "#1a1a1a", "Midnight Black", 2 },
                    { 7, "#C8A882", "Sandstorm", 2 },
                    { 8, "#4A5240", "Army Green", 2 },
                    { 9, "#1a1a1a", "Midnight Black", 3 },
                    { 10, "#F0F0F0", "Wind Chill Pearl", 3 },
                    { 11, "#CC2200", "Supersonic Red", 3 },
                    { 12, "#2B4C8C", "Cavalry Blue", 3 },
                    { 13, "#1a1a1a", "Midnight Black", 4 },
                    { 14, "#F5F5F0", "White Pearl", 4 },
                    { 15, "#CC2200", "Supersonic Red", 4 },
                    { 16, "#E8E8E8", "Ice Cap", 4 },
                    { 17, "#F8F8F8", "Absolute Zero White", 5 },
                    { 18, "#1a1a1a", "Midnight Black", 5 },
                    { 19, "#AA1100", "Renaissance Red", 5 },
                    { 20, "#1E3A8A", "Refraction Blue", 5 },
                    { 21, "#F0F0F0", "Wind Chill Pearl", 6 },
                    { 22, "#1a1a1a", "Midnight Black", 6 },
                    { 23, "#6B7280", "Heavy Metal", 6 },
                    { 24, "#2B4C8C", "Blueprint", 6 }
                });

            migrationBuilder.InsertData(
                table: "VehicleTrims",
                columns: new[] { "Id", "FuelType", "ImageUrl", "MPG", "Name", "Price", "VehicleId" },
                values: new object[,]
                {
                    { 1, "Gas", "/images/Crossover.webp", "31/33", "L", 25235m, 1 },
                    { 2, "Gas", "/images/Crossover.webp", "31/33", "LE", 27565m, 1 },
                    { 3, "Hybrid", "/images/Crossover.webp", "46/39", "Hybrid S", 29595m, 1 },
                    { 4, "Gas", "/images/Crossover.webp", "31/33", "XLE", 30160m, 1 },
                    { 5, "Hybrid", "/images/suv_(Off-Road).jpg", "22/25", "1958", 57880m, 2 },
                    { 6, "Hybrid", "/images/suv_(Off-Road).jpg", "22/25", "First Edition", 65000m, 2 },
                    { 7, "Hybrid", "/images/toyota_camry_ Sedan.webp", "51/53", "LE", 29495m, 3 },
                    { 8, "Hybrid", "/images/toyota_camry_ Sedan.webp", "44/47", "SE", 31270m, 3 },
                    { 9, "Hybrid", "/images/toyota_camry_ Sedan.webp", "51/53", "XLE", 35270m, 3 },
                    { 10, "Hybrid", "/images/toyota_camry_ Sedan.webp", "44/47", "XSE", 36270m, 3 },
                    { 11, "Gas", "/images/(Hatchback).jpg", "32/41", "SE", 24580m, 4 },
                    { 12, "Gas", "/images/(Hatchback).jpg", "32/41", "XSE", 27080m, 4 },
                    { 13, "Gas", "/images/Coupe.jpg", "25/32", "2.0", 56645m, 5 },
                    { 14, "Gas", "/images/Coupe.jpg", "22/30", "3.0", 59995m, 5 },
                    { 15, "Gas", "/images/Coupe.jpg", "22/30", "3.0 Premium", 66495m, 5 },
                    { 16, "Electric", "/images/EVs.webp", "116 MPGe", "XLE", 34900m, 6 },
                    { 17, "Electric", "/images/EVs.webp", "113 MPGe", "Limited", 44900m, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColors_VehicleId",
                table: "VehicleColors",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTrims_VehicleId",
                table: "VehicleTrims",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleColors");

            migrationBuilder.DropTable(
                name: "VehicleTrims");
        }
    }
}
