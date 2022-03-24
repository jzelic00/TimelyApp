using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimelyApp.Migrations
{
    public partial class NewSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Log",
                columns: new[] { "LogID", "Duration", "EndTime", "ProjectName", "StartTime" },
                values: new object[] { 1, 1234, new DateTime(2022, 3, 23, 23, 33, 59, 735, DateTimeKind.Utc).AddTicks(4897), "test", new DateTime(2022, 3, 23, 23, 33, 59, 735, DateTimeKind.Utc).AddTicks(4675) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogID",
                keyValue: 1);
        }
    }
}
