using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftManagementApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DeleteRestrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceLocations_Services_ServiceID",
                table: "ServiceLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftControls_Persons_PersonID",
                table: "ShiftControls");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftControls_ServiceLocations_ServiceLocationID",
                table: "ShiftControls");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftControls_Services_ServiceID",
                table: "ShiftControls");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceLocations_Services_ServiceID",
                table: "ServiceLocations",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftControls_Persons_PersonID",
                table: "ShiftControls",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftControls_ServiceLocations_ServiceLocationID",
                table: "ShiftControls",
                column: "ServiceLocationID",
                principalTable: "ServiceLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftControls_Services_ServiceID",
                table: "ShiftControls",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceLocations_Services_ServiceID",
                table: "ServiceLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftControls_Persons_PersonID",
                table: "ShiftControls");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftControls_ServiceLocations_ServiceLocationID",
                table: "ShiftControls");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftControls_Services_ServiceID",
                table: "ShiftControls");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceLocations_Services_ServiceID",
                table: "ServiceLocations",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftControls_Persons_PersonID",
                table: "ShiftControls",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftControls_ServiceLocations_ServiceLocationID",
                table: "ShiftControls",
                column: "ServiceLocationID",
                principalTable: "ServiceLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftControls_Services_ServiceID",
                table: "ShiftControls",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
