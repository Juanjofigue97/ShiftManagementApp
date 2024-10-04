using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftManagementApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateIsValidColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsValid",
                table: "Services",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsValid",
                table: "ServiceLocations",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsValid",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IsValid",
                table: "ServiceLocations");
        }
    }
}
