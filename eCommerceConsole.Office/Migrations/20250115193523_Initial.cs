using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceConsole.Office.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEmployeeClass",
                columns: table => new
                {
                    EmployeeClassesId = table.Column<int>(type: "int", nullable: false),
                    EmployeesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEmployeeClass", x => new { x.EmployeeClassesId, x.EmployeesId });
                    table.ForeignKey(
                        name: "FK_EmployeeEmployeeClass_EmployeeClasses_EmployeeClassesId",
                        column: x => x.EmployeeClassesId,
                        principalTable: "EmployeeClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeEmployeeClass_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSectors",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSectors", x => new { x.EmployeeId, x.SectorId });
                    table.ForeignKey(
                        name: "FK_EmployeeSectors_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSectors_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeVehicle",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeVehicle", x => new { x.EmployeesId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_EmployeeVehicle_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeVehicle_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Jane Smith" },
                    { 3, "Michael Johnson" },
                    { 4, "Emily Davis" },
                    { 5, "William Brown" },
                    { 6, "Sophia Wilson" },
                    { 7, "James Anderson" },
                    { 8, "Olivia Martinez" },
                    { 9, "Alexander Garcia" },
                    { 10, "Emma Thomas" }
                });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Human Resources" },
                    { 2, "Finance" },
                    { 3, "Marketing" },
                    { 4, "Sales" },
                    { 5, "IT Support" },
                    { 6, "Research and Development" },
                    { 7, "Customer Service" },
                    { 8, "Logistics" },
                    { 9, "Operations" },
                    { 10, "Legal" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeSectors",
                columns: new[] { "EmployeeId", "SectorId", "CreatedAt" },
                values: new object[,]
                {
                    { 1, 10, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 2, 9, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7395), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 3, 8, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 4, 7, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 5, 6, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 6, 5, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7402), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 7, 4, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7404), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 8, 3, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 9, 2, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 10, 1, new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, -3, 0, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEmployeeClass_EmployeesId",
                table: "EmployeeEmployeeClass",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSectors_SectorId",
                table: "EmployeeSectors",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVehicle_VehiclesId",
                table: "EmployeeVehicle",
                column: "VehiclesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeEmployeeClass");

            migrationBuilder.DropTable(
                name: "EmployeeSectors");

            migrationBuilder.DropTable(
                name: "EmployeeVehicle");

            migrationBuilder.DropTable(
                name: "EmployeeClasses");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
