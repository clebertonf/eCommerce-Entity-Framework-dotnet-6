using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceConsole.Office.Migrations
{
    public partial class employee_vehicle_many_to_many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeVehicle_Employees_EmployeesId",
                table: "EmployeeVehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeVehicle_Vehicles_VehiclesId",
                table: "EmployeeVehicle");

            migrationBuilder.RenameColumn(
                name: "VehiclesId",
                table: "EmployeeVehicle",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "EmployeeVehicle",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeVehicle_VehiclesId",
                table: "EmployeeVehicle",
                newName: "IX_EmployeeVehicle_VehicleId");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "VehicleStartDate",
                table: "EmployeeVehicle",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 1, 10 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6144), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6169), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 3, 8 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6170), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 4, 7 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6172), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6174), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6176), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 7, 4 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6177), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6179), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6181), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 10, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 20, 22, 29, 343, DateTimeKind.Unspecified).AddTicks(6182), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "EmployeeId", "Name", "Plate" },
                values: new object[,]
                {
                    { 1, 0, "Toyota Corolla", "ABC-1234" },
                    { 2, 0, "Honda Civic", "DEF-5678" },
                    { 3, 0, "Ford Ranger", "GHI-9012" },
                    { 4, 0, "Chevrolet Onix", "JKL-3456" },
                    { 5, 0, "Volkswagen Golf", "MNO-7890" },
                    { 6, 0, "Jeep Renegade", "PQR-1235" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeVehicle_Employees_EmployeeId",
                table: "EmployeeVehicle",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeVehicle_Vehicles_VehicleId",
                table: "EmployeeVehicle",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeVehicle_Employees_EmployeeId",
                table: "EmployeeVehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeVehicle_Vehicles_VehicleId",
                table: "EmployeeVehicle");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "VehicleStartDate",
                table: "EmployeeVehicle");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "EmployeeVehicle",
                newName: "VehiclesId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "EmployeeVehicle",
                newName: "EmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeVehicle_VehicleId",
                table: "EmployeeVehicle",
                newName: "IX_EmployeeVehicle_VehiclesId");

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 1, 10 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(504), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(532), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 3, 8 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(534), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 4, 7 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(536), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(575), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(577), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 7, 4 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 10, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 17, 14, 20, 549, DateTimeKind.Unspecified).AddTicks(584), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeVehicle_Employees_EmployeesId",
                table: "EmployeeVehicle",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeVehicle_Vehicles_VehiclesId",
                table: "EmployeeVehicle",
                column: "VehiclesId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
