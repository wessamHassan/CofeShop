using Microsoft.EntityFrameworkCore.Migrations;

namespace CofeShop.Server.Migrations
{
    public partial class test0406 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 100, " test", "test", "test", 20m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
