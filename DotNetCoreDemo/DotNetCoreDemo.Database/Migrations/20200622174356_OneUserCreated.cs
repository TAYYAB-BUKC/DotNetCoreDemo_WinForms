using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreDemo.Database.Migrations
{
    public partial class OneUserCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
