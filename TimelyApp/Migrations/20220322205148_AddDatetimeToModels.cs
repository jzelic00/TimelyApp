using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimelyApp.Migrations
{
    public partial class AddDatetimeToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogID",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Log",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Log",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Log",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "Log",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "Log",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Log",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Log",
                columns: new[] { "LogID", "Duration", "EndTime", "ProjectName", "StartTime" },
                values: new object[] { 1, "testIsto", "test", "Obitelj", "test" });

            migrationBuilder.InsertData(
                table: "Log",
                columns: new[] { "LogID", "Duration", "EndTime", "ProjectName", "StartTime" },
                values: new object[] { 2, "testIsto", "test", "Prijatelj", "test" });

            migrationBuilder.InsertData(
                table: "Log",
                columns: new[] { "LogID", "Duration", "EndTime", "ProjectName", "StartTime" },
                values: new object[] { 3, "testIsto", "test", "Posao", "test" });
        }
    }
}
