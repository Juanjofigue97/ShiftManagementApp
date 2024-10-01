using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftManagementApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateShiftControls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShiftControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(type: "int", nullable: false),
                    ServiceID = table.Column<int>(type: "int", nullable: false),
                    ServiceLocationID = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShiftControls_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShiftControls_ServiceLocations_ServiceLocationID",
                        column: x => x.ServiceLocationID,
                        principalTable: "ServiceLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShiftControls_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShiftControls_PersonID",
                table: "ShiftControls",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftControls_ServiceID",
                table: "ShiftControls",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftControls_ServiceLocationID",
                table: "ShiftControls",
                column: "ServiceLocationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShiftControls");
        }
    }
}
