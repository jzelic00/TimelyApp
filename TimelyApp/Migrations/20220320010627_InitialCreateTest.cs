using Microsoft.EntityFrameworkCore.Migrations;

namespace TimelyApp.Migrations
{
    public partial class InitialCreateTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.LogID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Log");
        }
    }
}
