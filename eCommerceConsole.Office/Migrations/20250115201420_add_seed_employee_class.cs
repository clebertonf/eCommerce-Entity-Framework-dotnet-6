using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceConsole.Office.Migrations
{
    public partial class add_seed_employee_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Class 1" },
                    { 2, "Class 2" },
                    { 3, "Class 3" },
                    { 4, "Class 4" },
                    { 5, "Class 5" },
                    { 6, "Class 6" }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeClasses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeClasses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeClasses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeClasses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeClasses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeClasses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 1, 10 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7395), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 3, 8 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 4, 7 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7402), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 7, 4 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7404), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeeSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 10, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
