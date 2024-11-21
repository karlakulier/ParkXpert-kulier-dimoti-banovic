using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkXplore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImeMigracije : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParkingSpotTypeId",
                table: "ParkingSpots");

            migrationBuilder.DropColumn(
                name: "ParkingTypeId",
                table: "Parkings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParkingSpotTypeId",
                table: "ParkingSpots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParkingTypeId",
                table: "Parkings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
