using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiclesLibrary.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fuel",
                table: "WaterVehicles",
                newName: "FuelType");

            migrationBuilder.RenameColumn(
                name: "Fuel",
                table: "LandVehicles",
                newName: "FuelType");

            migrationBuilder.RenameColumn(
                name: "Fuel",
                table: "AirVehicles",
                newName: "FuelType");

            migrationBuilder.AlterColumn<short>(
                name: "MaxSpeed",
                table: "WaterVehicles",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "Displacement",
                table: "WaterVehicles",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "WaterVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<short>(
                name: "MaxSpeed",
                table: "LandVehicles",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "LandVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<short>(
                name: "MaxSpeed",
                table: "AirVehicles",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "AirVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "WaterVehicles");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "LandVehicles");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "AirVehicles");

            migrationBuilder.RenameColumn(
                name: "FuelType",
                table: "WaterVehicles",
                newName: "Fuel");

            migrationBuilder.RenameColumn(
                name: "FuelType",
                table: "LandVehicles",
                newName: "Fuel");

            migrationBuilder.RenameColumn(
                name: "FuelType",
                table: "AirVehicles",
                newName: "Fuel");

            migrationBuilder.AlterColumn<int>(
                name: "MaxSpeed",
                table: "WaterVehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "Displacement",
                table: "WaterVehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "MaxSpeed",
                table: "LandVehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "MaxSpeed",
                table: "AirVehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }
    }
}
